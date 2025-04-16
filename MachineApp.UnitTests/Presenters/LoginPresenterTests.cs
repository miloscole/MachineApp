using MachineApp.Helpers;
using MachineApp.Models;
using MachineApp.Presenters;
using MachineApp.Repositories.UserRepository;
using MachineApp.Views.Login;
using Moq;

namespace MachineApp.UnitTests.Presenters
{
    [TestClass]
    public class LoginPresenterTests
    {
        private Mock<ILogin> mockView = null!;
        private Mock<IUserRepo> mockRepo = null!;
        private LoginPresenter presenter = null!;
        private readonly string userCredential = "credential";

        [TestInitialize]
        public void Setup()
        {
            mockView = new Mock<ILogin>();
            mockRepo = new Mock<IUserRepo>();
            presenter = new LoginPresenter(mockView.Object, mockRepo.Object);
        }

        [TestMethod]
        public void ShowsError_When_InvalidCredentials()
        {
            // Arrange  
            mockView.Setup(v => v.Username).Returns(userCredential);
            mockView.Setup(v => v.Password).Returns(userCredential);
            mockRepo.Setup(r => r.GetUser(userCredential, userCredential)).Returns((User?)null);

            // Act  
            mockView.Raise(v => v.LoginRequested += null);

            // Assert  
            mockView.Verify(v => v.ShowErrorMessageBox(Constants.InvalidCredentials), Times.Once);
        }

        [TestMethod]
        public void ShowsErrorMessage_When_LoginFails()
        {
            // Arrange  
            mockView.Setup(v => v.Username).Returns(userCredential);
            mockView.Setup(v => v.Password).Returns(userCredential);
            mockRepo.Setup(r => r.GetUser(userCredential, userCredential)).Throws(new Exception("DB error"));

            // Act  
            mockView.Raise(v => v.LoginRequested += null);

            // Assert  
            mockView.Verify(v => v.ShowErrorMessageBox("DB error"), Times.Once);
        }

        [TestMethod]
        public void LoginSucceeded_When_ValidCredentials()
        {
            // Arrange  
            var user = new User { Username = userCredential, RoleName = "admin" };

            mockView.Setup(v => v.Username).Returns(userCredential);
            mockView.Setup(v => v.Password).Returns(userCredential);
            mockRepo.Setup(r => r.GetUser(userCredential, userCredential)).Returns(user);

            // Act  
            mockView.Raise(v => v.LoginRequested += null);

            // Assert  
            mockView.Verify(v => v.LoginSucceeded(user), Times.Once);
            mockView.Verify(v => v.CloseForm(), Times.Once);
        }

    }
}

