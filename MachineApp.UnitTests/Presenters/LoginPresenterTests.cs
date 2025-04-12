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
        private Mock<ILoginView> mockView = null!;
        private Mock<IUserRepo> mockRepo = null!;
        private LoginPresenter presenter = null!;
        private readonly String userCredential = "credential";

        [TestInitialize]
        public void Setup()
        {
            mockView = new Mock<ILoginView>();
            mockRepo = new Mock<IUserRepo>();
            presenter = new LoginPresenter(mockView.Object, mockRepo.Object);
        }

        [TestMethod]
        public void ShowsError_When_InvalidCredentials()
        {
            mockView.Setup(v => v.Username).Returns(userCredential);
            mockView.Setup(v => v.Password).Returns(userCredential);
            mockRepo.Setup(r => r.GetUser(userCredential, userCredential)).Returns((User?)null);

            presenter.Login();

            mockView.Verify(v => v.ShowError("Invalid username or password."), Times.Once);
        }

        [TestMethod]
        public void ShowsWelcome_When_ValidCredentials()
        {
            var role = "Admin";

            mockView.Setup(v => v.Username).Returns(userCredential);
            mockView.Setup(v => v.Password).Returns(userCredential);

            var user = new User { Username = userCredential, Role = role };
            mockRepo.Setup(r => r.GetUser(userCredential, userCredential)).Returns(user);

            presenter.Login();

            mockView.Verify(v => v.ShowWelcome(userCredential, role), Times.Once);
        }

        [TestMethod]
        public void ShowsUnexpectedError_When_RepositoryThrowsException()
        {
            mockView.Setup(v => v.Username).Returns(userCredential);
            mockView.Setup(v => v.Password).Returns(userCredential);
            mockRepo.Setup(r => r.GetUser(userCredential, userCredential)).Throws(new Exception("DB failure"));

            presenter.Login();

            mockView.Verify(v => v.ShowError(It.Is<string>(msg => msg.Contains("Unexpected error"))), Times.Once);
        }
    }
}
