using MachineApp.Helpers;
using MachineApp.Repositories.UserRepository;
using MachineApp.Views.Login;

namespace MachineApp.Presenters
{
    public class LoginPresenter
    {
        private readonly ILogin _view;
        private readonly IUserRepo _repo;

        public LoginPresenter(ILogin view, IUserRepo repo)
        {
            _view = view;
            _repo = repo;

            _view.LoginRequested += OnLoginRequested;
        }

        private void OnLoginRequested()
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
