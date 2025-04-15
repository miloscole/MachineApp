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

            SetUpLogForm();
            _view.SaveLogRequested += OnSaveLogRequested;
        }

        private void SetUpLogForm()
        {
            _machineLog = _repo.GetByMachineId(_machineId);
            _view.SetMachineId(_machineId);

            if (_machineLog != null) _view.FillForm(_machineLog);
        }

        private void OnSaveLogRequested()
        {
            var logData = _view.GetFormData();
            var allDatesUnset = AreAllDatesUnSet(logData);

            if (allDatesUnset) HandleEmptyForm(logData);
            else HandleFilledForm(logData);
        }

        private static bool AreAllDatesUnSet(MachineLog log) =>
            log.StartProductionDate == null &&
            log.EndProductionDate == null &&
            log.DeliveryDate == null;

        private void HandleEmptyForm(MachineLog logData)
        {
            if (_machineLog == null)
            {
                _view.ShowInfoMessageBox("Please set at least one log to be able to Save.");
            }
            else
            {
                _repo.Delete(logData.Id);
                _view.ShowInfoMessageBox("All dates are unset and log is removed from DB.");
                _view.CloseForm();
            }
        }

        private void HandleFilledForm(MachineLog logData)
        {
            if (_machineLog == null)
            {
                _repo.Insert(logData);
                _view.ShowInfoMessageBox("Successfully saved!");

            }
            else
            {
                _repo.Update(logData);
                _view.ShowInfoMessageBox("Successfully updated!");
            }
            _view.CloseForm();
        }
    }
}
