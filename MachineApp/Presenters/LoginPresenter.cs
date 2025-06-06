﻿using MachineApp.Helpers;
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

        //  Event Handlers

        private void OnLoginRequested()
        {
            if (string.IsNullOrWhiteSpace(_view.Username) || string.IsNullOrWhiteSpace(_view.Password))
            {
                _view.ShowErrorMessageBox(Constants.ProvideCredentials);
                return;
            }

            try
            {
                var user = _repo.GetUser(_view.Username, _view.Password);
                if (user == null)
                    _view.ShowErrorMessageBox(Constants.InvalidCredentials);
                else
                {
                    _view.LoginSucceeded(user);
                    Session.SetUpSession(user);
                    _view.CloseForm();
                }
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessageBox(ex.Message);
            }
        }
    }
}
