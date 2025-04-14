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

            _view.LoadMachines += OnLoadMachines;
            _view.LogoutRequested += OnLogoutRequested;
            _view.DeleteMachineRequested += OnDeleteMachineRequested;
            _view.AddMachineRequested += OnAddMachineRequested;
            _view.EditMachineRequested += (machine) => OnEditMachineRequested(machine);
        }

        private void OnLoadMachines()
        {
            try
            {
                var machines = _repo.GetAll();
                if (machines.Count != 0)
                    _view.DisplayMachines(machines);
                else
                    _view.ShowErrorOnLoad("Nothing to show!");
            }
            catch (Exception ex)
            {
                _view.ShowErrorOnLoad($"Unexpected error: {ex.Message}");
            }
        }

        private void OnLogoutRequested()
        {
            Session.ClearSession();
            _view.Close();
        }

        private void OnDeleteMachineRequested()
        {
            if (!Session.IsAdmin)
            {
                _view.ShowErrorOnDelete("Only admin can delete machines.");
                return;
            }

            var selected = _view.SelectedMachine;
            if (selected == null)
            {
                _view.ShowErrorOnDelete("No machine selected.");
                return;
            }

            try
            {
                if (_view.ShouldConfirmDeletion())
                {
                    _repo.Delete(selected.Id);
                    OnLoadMachines();
                }
            }
            catch (Exception ex)
            {
                _view.ShowErrorOnDelete($"Failed to delete machine: {ex.Message}");
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
