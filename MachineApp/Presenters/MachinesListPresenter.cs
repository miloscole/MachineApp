using MachineApp.Helpers;
using MachineApp.Repositories.MachineRepository;
using MachineApp.Views.Machines.MachinesList;

namespace MachineApp.Presenters
{
    public class MachinesListPresenter
    {
        private readonly IMachineListView _view;
        private readonly IMachineRepo _repository;

        public MachinesListPresenter(IMachineListView view, IMachineRepo repository)
        {
            _view = view;
            _repository = repository;

            _view.LoadMachines += OnLoadMachines;
            _view.LogoutRequested += OnLogoutRequested;
        }

        private void OnLoadMachines(object? sender, EventArgs e)
        {
            try
            {
                var machines = _repository.GetAll();
                if (machines.Count != 0)
                    _view.DisplayMachines(machines);
                else
                    _view.ShowError("Nothing to show!");
            }
            catch (Exception ex)
            {
                _view.ShowError($"Unexpected error: {ex.Message}");
            }
        }

        private void OnLogoutRequested(object? sender, EventArgs e)
        {
            Session.ClearSession();
            _view.Close();
        }
    }
}
