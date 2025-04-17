using MachineApp.Helpers;
using MachineApp.Models;
using MachineApp.Repositories.MachineLogRepository;
using MachineApp.Views.Machines.MachineLogForm;

namespace MachineApp.Presenters
{
    public class MachineLogPresenter
    {
        private readonly IMachineLogForm _view;
        private readonly IMachineLogRepo _repo;
        private readonly int _machineId;
        private MachineLog? _machineLog;

        public MachineLogPresenter(IMachineLogForm view, IMachineLogRepo repo, int machineId)
        {
            _view = view;
            _repo = repo;
            _machineId = machineId;

            InitializeLogForm();

            if (!Session.IsAdmin) _view.HideAdminControls();

            _view.SaveLogRequested += OnSaveLogRequested;
        }

        //  Event Handlers

        private void OnSaveLogRequested()
        {
            if (!Session.IsAdmin)
            {
                _view.ShowErrorMessageBox(Constants.OnlyAdminAllowed);
                return;
            }

            var logData = _view.GetFormData();
            var allDatesUnset = AreAllDatesUnset(logData);

            if (allDatesUnset) HandleInvalidForm(logData);
            else HandleValidForm(logData);
        }

        //  Initialization helpers

        private void InitializeLogForm()
        {
            _machineLog = _repo.GetByMachineId(_machineId);
            _view.SetMachineId(_machineId);

            if (_machineLog != null) _view.FillForm(_machineLog);
        }

        //  Helper methods

        private static bool AreAllDatesUnset(MachineLog log) =>
            log.StartProductionDate == null &&
            log.EndProductionDate == null &&
            log.DeliveryDate == null;

        private void HandleInvalidForm(MachineLog logData)
        {
            if (_machineLog == null)
            {
                _view.ShowInfoMessageBox(Constants.EmptyLogInfoNew);
            }
            else
            {
                _repo.Delete(logData.Id);
                _view.ShowInfoMessageBox(Constants.EmptyLogInfoEdit);
                _view.CloseForm();
            }
        }

        private void HandleValidForm(MachineLog logData)
        {
            if (_machineLog == null)
            {
                _repo.Insert(logData);
                _view.ShowInfoMessageBox(Constants.CreateSuccess);

            }
            else
            {
                _repo.Update(logData);
                _view.ShowInfoMessageBox(Constants.UpdateSuccess);
            }
            _view.CloseForm();
        }
    }
}
