using MachineApp.Helpers;
using MachineApp.Repositories.UserRepository;
using MachineApp.Views.Login;

namespace MachineApp.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUserRepo _repo;

        public LoginPresenter(ILoginView view, IUserRepo repo)
        {
            _view = view;
            _repo = repo;

            _view.LoginAttempted += OnLoginAttempted;
        }
        private void OnLoginAttempted(object? sender, EventArgs e)
        {
            try
            {
                var user = _repo.GetUser(_view.Username, _view.Password);
                if (user == null)
                    _view.ShowError("Invalid username or password.");
                else
                {
                    _view.LoginSucceeded(user);
                    Session.SetUpSession(user);
                    _view.Close();
                }
            }
            catch (Exception ex)
            {
                _view.ShowError($"Unexpected error: {ex.Message}");
            }
        }
    }
}
