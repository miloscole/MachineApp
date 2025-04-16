using System.Windows.Forms;
using MachineApp.Helpers;
using MachineApp.Models;
using MachineApp.Presenters;
using MachineApp.Repositories.MachineRepository;
using MachineApp.Views.Machines.MachineForm;
using Moq;

namespace MachineApp.UnitTests.Presenters
{
    [TestClass]
    public class MachineFormPresenterTests
    {
        private Mock<IMachineForm> _mockView = null!;
        private Mock<IMachineRepo> _mockRepo = null!;
        private Machine _sampleMachine = null!;
        private Machine _machineToEdit = null!;
        private List<MachineType> _machineTypes = null!;

        [TestInitialize]
        public void Setup()
        {
            _mockView = new Mock<IMachineForm>();
            _mockRepo = new Mock<IMachineRepo>();
            _sampleMachine = new Machine { Name = "Machine A", SerialNumber = "1234" };
            _machineToEdit = new Machine { Id = 5, Name = "Existing Machine", SerialNumber = "0000" };
            _machineTypes = new List<MachineType> { new MachineType { Id = 1, TypeName = "Type A" } };

            _mockRepo.Setup(r => r.GetAllMachineTypes()).Returns(_machineTypes);
            _mockView.Setup(v => v.GetMachineData()).Returns(_sampleMachine);
        }

        [TestCleanup]
        public void Cleanup() => Session.ClearSession();


        // Initialization Tests

        [TestMethod]
        public void SetsMachineTypesOnInit()
        {
            // Act
            CreatePresenter();

            // Assert
            _mockView.VerifySet(v => v.MachineTypes = _machineTypes, Times.Once);
        }

        [TestMethod]
        public void FillsFormOnInit_WhenEditingMachine()
        {
            // Act
            CreatePresenter(_machineToEdit);

            // Assert
            _mockView.Verify(v => v.SetFormTitle(Constants.EditMachineTitle), Times.Once);
            _mockView.Verify(v => v.FillForm(_machineToEdit), Times.Once);
        }


        // Error Handling Tests

        [TestMethod]
        public void ShowsError_ForNonAdmin_WhenAddingNewMachine()
        {
            // Arrange
            SetUserSession();
            CreatePresenter();

            // Act
            _mockView.Raise(v => v.SaveMachineRequested += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorMessageBox(Constants.OnlyAdminAllowed), Times.Once);
        }

        [TestMethod]
        public void ShowsError_ForNonAdmin_WhenEditingMachine()
        {
            // Arrange
            SetUserSession();
            CreatePresenter(_machineToEdit);

            // Act
            _mockView.Raise(v => v.SaveMachineRequested += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorMessageBox(Constants.OnlyAdminAllowed), Times.Once);
        }

        [TestMethod]
        public void ShowsValidationErrors_WhenFormIsInvalid()
        {
            // Arrange
            SetAdminSession();
            CreatePresenter();

            var invalidMachine = new Machine { Name = "", SerialNumber = "" };
            _mockView.Setup(v => v.GetMachineData()).Returns(invalidMachine);

            // Act
            _mockView.Raise(v => v.SaveMachineRequested += null);

            // Assert
            _mockView.Verify(v => v.ShowValidationErrors(
                 It.Is<List<string>>(errors =>
                    errors.Any(e => e.Contains("Name")) &&
                    errors.Any(e => e.Contains("Serial Number"))
                 )), Times.Once);

            _mockView.Verify(v => v.CloseForm(), Times.Never);
        }

        [TestMethod]
        public void ShowsError_WhenGetAllMachineTypesFails()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetAllMachineTypes()).Throws(new Exception("DB error"));

            // Act
            CreatePresenter();

            // Assert
            _mockView.Verify(v => v.ShowErrorMessageBox("DB error"), Times.Once);
            _mockView.VerifySet(v => v.MachineTypes = It.Is<List<MachineType>>(types => types.Count == 0), Times.Once);
        }

        [TestMethod]
        public void ShowsError_WhenInsertFails()
        {
            // Arrange
            SetAdminSession();
            CreatePresenter();
            _mockRepo.Setup(r => r.Insert(It.IsAny<Machine>())).Throws(new Exception("Insert error"));

            // Act
            _mockView.Raise(v => v.SaveMachineRequested += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorMessageBox("Insert error"), Times.Once);
        }

        [TestMethod]
        public void ShowsError_WhenUpdateFails()
        {
            // Arrange
            SetAdminSession();
            CreatePresenter(_machineToEdit);
            _mockRepo.Setup(r => r.Update(It.IsAny<Machine>())).Throws(new Exception("Update error"));

            // Act
            _mockView.Raise(v => v.SaveMachineRequested += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorMessageBox("Update error"), Times.Once);
        }


        // Saves Successfully

        [TestMethod]
        public void InsertsMachine_WhenFormIsValid()
        {
            // Arrange
            SetAdminSession();
            CreatePresenter();

            // Act
            _mockView.Raise(v => v.SaveMachineRequested += null);

            // Assert
            _mockRepo.Verify(r => r.Insert(_sampleMachine), Times.Once);
            _mockRepo.Verify(r => r.Update(It.IsAny<Machine>()), Times.Never);
            _mockView.Verify(v => v.ShowInfoMessageBox(Constants.CreateSuccess), Times.Once);
            _mockView.Verify(v => v.SetDialogResult(DialogResult.OK), Times.Once);
            _mockView.Verify(v => v.CloseForm(), Times.Once);
        }

        [TestMethod]
        public void UpdatesMachine_WhenFormIsValid()
        {
            // Arrange
            SetAdminSession();
            CreatePresenter(_machineToEdit);

            _mockView.Setup(v => v.GetMachineData()).Returns(_machineToEdit);

            // Act
            _mockView.Raise(v => v.SaveMachineRequested += null);

            // Assert
            _mockRepo.Verify(r => r.Update(_machineToEdit), Times.Once);
            _mockRepo.Verify(r => r.Insert(It.IsAny<Machine>()), Times.Never);
            _mockView.Verify(v => v.ShowInfoMessageBox(Constants.UpdateSuccess), Times.Once);
            _mockView.Verify(v => v.SetDialogResult(DialogResult.OK), Times.Once);
            _mockView.Verify(v => v.CloseForm(), Times.Once);
        }


        // Helper methods

        private static void SetAdminSession() =>
            Session.SetUpSession(new User { RoleName = "admin" });

        private static void SetUserSession() =>
            Session.SetUpSession(new User { RoleName = "user" });

        private MachineFormPresenter CreatePresenter(Machine? machine = null) =>
            machine == null
                ? new MachineFormPresenter(_mockView.Object, _mockRepo.Object)
                : new MachineFormPresenter(_mockView.Object, _mockRepo.Object, machine);
    }
}
