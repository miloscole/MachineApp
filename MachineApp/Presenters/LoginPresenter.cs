
using MachineApp.Views.Login;
using MachineApp.Repositories;

namespace MachineApp.Presenters
{
    public class LoginPresenter(ILoginView view, IUserRepo repo)
    {
        private readonly ILoginView _view = view;
        private readonly IUserRepo _repo = repo;

        public void Login()
        {
            try
            {
                var user = _repo.GetUser(_view.Username, _view.Password);
                if (user == null)
                {
                    _view.ShowError("Invalid username or password.");
                }
                else
                {
                    _view.ShowWelcome(user.Username, user.Role);
                }
            }
            catch (Exception ex)
            {
                _view.ShowError($"Unexpected error: {ex.Message}");
            }
        }

    }
}
