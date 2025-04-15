using MachineApp.Factory;
using MachineApp.Helpers;
using MachineApp.Models;
using MachineApp.Repositories.MachineRepository;
using MachineApp.Views.Machines.MachinesList;

namespace MachineApp.Presenters
{
    public class MachinesListPresenter
    {
        private readonly IMachineList _view;
        private readonly IMachineRepo _repo;
        private readonly IViewFactory _factory;

        public MachinesListPresenter(IMachineList view, IMachineRepo repo, IViewFactory factory)
        {
            _view = view;
            _repo = repo;
            _factory = factory;

            var userInfo = string.Format(
                Constants.UserInfoTemplate,
                Session.CurrentUser?.Username,
                Session.CurrentUser?.RoleName
            );
            _view.SetUserInfo(userInfo);

            if (!Session.IsAdmin) _view.HideAdminControls();

            _view.LoadMachines += OnLoadMachines;
            _view.LogoutRequested += OnLogoutRequested;
            _view.DeleteMachineRequested += OnDeleteMachineRequested;
            _view.AddMachineRequested += OnAddMachineRequested;
            _view.EditMachineRequested += (machine) => OnEditMachineRequested(machine);
            _view.MachineLogRequested += (id) => OnMachineLogRequested(id);
        }

        private void OnLoadMachines()
        {
            try
            {
                var machines = _repo.GetAll();
                if (machines.Count != 0)
                    _view.DisplayMachines(machines);
                else
                    _view.ShowErrorOnLoad(Constants.EmptyTable);
            }
            catch (Exception ex)
            {
                _view.ShowErrorOnLoad(Constants.LoadFail + ex.Message);
            }
        }

        private void OnLogoutRequested()
        {
            Session.ClearSession();
            _view.CloseForm();
        }

        private void OnDeleteMachineRequested()
        {
            if (!Session.IsAdmin)
            {
                _view.ShowErrorMessageBox(Constants.OnlyAdminAllowed);
                return;
            }

            var selected = _view.SelectedMachine;
            if (selected == null)
            {
                _view.ShowErrorMessageBox(Constants.NoneSelected);
                return;
            }
            HandleConfirmedDeletion(selected.Id);
        }

        private void OnMachineLogRequested(int id)
        {
            var form = _factory.CreateMachineLogFormView(id);
            form.ShowDialog();
        }



        private void HandleConfirmedDeletion(int id)
        {
            if (_view.ShouldConfirmDeletion())
            {
                try
                {
                    _repo.Delete(id);
                    _view.ShowInfoMessageBox(Constants.DeleteSuccess);
                    OnLoadMachines();
                }
                catch (Exception ex)
                {
                    _view.ShowErrorMessageBox(Constants.DeleteFail + ex.Message);
                }
            }
        }

        private void OnMachineFormRequested(Machine? machine = null)
        {
            var form = _factory.CreateMachineFormView(machine);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                OnLoadMachines();
        }

        private void OnEditMachineRequested(Machine machine) => OnMachineFormRequested(machine);
        private void OnAddMachineRequested() => OnMachineFormRequested();
    }
}
