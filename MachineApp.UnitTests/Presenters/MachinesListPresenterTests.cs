using MachineApp.Factory;
using MachineApp.Helpers;
using MachineApp.Models;
using MachineApp.Presenters;
using MachineApp.Repositories.MachineRepository;
using MachineApp.Views.Machines.MachinesList;
using Moq;

namespace MachineApp.UnitTests.Presenters
{
    [TestClass]
    public class MachinesListPresenterTests
    {
        private Mock<IMachineList> _mockView = null!;
        private Mock<IMachineRepo> _mockRepo = null!;
        private Mock<IViewFactory> _mockFactory = null!;
        private Machine _sampleMachine = null!;

        [TestInitialize]
        public void Setup()
        {
            _mockView = new Mock<IMachineList>();
            _mockRepo = new Mock<IMachineRepo>();
            _mockFactory = new Mock<IViewFactory>();
            _sampleMachine = new Machine { Id = 1, Name = "Machine A", SerialNumber = "0000" };

            CreatePresenter();
        }

        [TestCleanup]
        public void Cleanup() => Session.ClearSession();


        // Initialization Tests

        [TestMethod]
        public void SetsUserInfo_OnInit()
        {
            // Arrange
            SetAdminSession();
            var expectedInfo = string.Format(Constants.UserInfoTemplate, "name1", "admin");

            // Act
            CreatePresenter();

            // Assert
            _mockView.Verify(v => v.SetUserInfo(expectedInfo), Times.Once);
        }


        // Error Handling Tests

        [TestMethod]
        public void ShowsError_WhenNoMachinesExist()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Machine>());

            // Act
            _mockView.Raise(v => v.LoadMachines += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorOnLoad(Constants.EmptyTable), Times.Once);
            _mockView.Verify(v => v.DisplayMachines(It.IsAny<List<Machine>>()), Times.Never);
        }

        [TestMethod]
        public void ShowsError_WhenGetAllFails()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetAll()).Throws(new Exception("DB error"));

            // Act
            _mockView.Raise(v => v.LoadMachines += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorOnLoad(Constants.LoadFail + "DB error"), Times.Once);
            _mockView.Verify(v => v.DisplayMachines(It.IsAny<List<Machine>>()), Times.Never);
        }

        [TestMethod]
        public void ShowsError_ForNonAdmin_WhenDeletingMachine()
        {
            // Arrange
            SetUserSession();

            // Act
            _mockView.Raise(v => v.DeleteMachineRequested += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorMessageBox(Constants.OnlyAdminAllowed), Times.Once);
        }

        [TestMethod]
        public void ShowsError_WhenDeleting_WithNoMachineSelected()
        {
            // Arrange
            SetAdminSession();
            _mockView.Setup(v => v.SelectedMachine).Returns((Machine?)null);

            // Act
            _mockView.Raise(v => v.DeleteMachineRequested += null);

            // Assert
            _mockView.Verify(v => v.ShowErrorMessageBox(Constants.NoneSelected), Times.Once);
        }


        // Action Tests

        [TestMethod]
        public void DisplaysMachines_OnLoad()
        {
            // Arrange
            var machines = new List<Machine> { _sampleMachine };
            _mockRepo.Setup(r => r.GetAll()).Returns(machines);

            // Act
            _mockView.Raise(v => v.LoadMachines += null);

            // Assert
            _mockView.Verify(v => v.DisplayMachines(machines), Times.Once);
            _mockView.Verify(v => v.ShowErrorOnLoad(It.IsAny<string>()), Times.Never);
        }

        [TestMethod]
        public void DeletesMachine_WhenConfirmed()
        {
            // Arrange
            SetAdminSession();
            var machines = new List<Machine> { _sampleMachine };
            _mockView.Setup(v => v.SelectedMachine).Returns(_sampleMachine);
            _mockView.Setup(v => v.ShouldConfirmDeletion()).Returns(true);
            _mockRepo.Setup(r => r.GetAll()).Returns(machines);

            // Act
            _mockView.Raise(v => v.DeleteMachineRequested += null);

            // Assert
            _mockRepo.Verify(r => r.Delete(_sampleMachine.Id), Times.Once);
            _mockView.Verify(v => v.ShowInfoMessageBox(Constants.DeleteSuccess), Times.Once);
            _mockView.Verify(v => v.DisplayMachines(machines), Times.Once);
        }

        [TestMethod]
        public void ClosesForm_OnLogout()
        {
            // Arrange
            SetUserSession();

            // Act
            _mockView.Raise(v => v.LogoutRequested += null);

            // Assert
            _mockView.Verify(v => v.CloseForm(), Times.Once);
            Assert.IsNull(Session.CurrentUser);
        }


        // Helper Methods

        private void SetAdminSession() =>
            Session.SetUpSession(new User { Username = "name1", RoleName = "admin" });

        private void SetUserSession() =>
            Session.SetUpSession(new User { Username = "name2", RoleName = "user" });

        private MachinesListPresenter CreatePresenter() =>
            new MachinesListPresenter(_mockView.Object, _mockRepo.Object, _mockFactory.Object);
    }
}