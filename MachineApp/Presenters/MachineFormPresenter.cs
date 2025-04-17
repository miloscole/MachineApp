using MachineApp.Helpers;
using MachineApp.Models;
using MachineApp.Repositories.MachineRepository;
using MachineApp.Views.Machines.MachineForm;

namespace MachineApp.Presenters
{
    public class MachineFormPresenter
    {
        private readonly IMachineForm _view;
        private readonly IMachineRepo _repo;
        private readonly Machine? _machineToEdit;

        public MachineFormPresenter(IMachineForm view, IMachineRepo repo, Machine? machineToEdit = null)
        {
            _view = view;
            _repo = repo;
            _machineToEdit = machineToEdit;

            try
            {
                _view.MachineTypes = _repo.GetAllMachineTypes();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessageBox(ex.Message);
                _view.MachineTypes = new List<MachineType>();
            }

            _view.SaveMachineRequested += OnSaveMachineRequested;

            if (_machineToEdit != null) InitilizeEditForm(_machineToEdit);
        }

        //  Event Handlers

        private void OnSaveMachineRequested()
        {
            var machine = _view.GetMachineData();

            if (!Session.IsAdmin)
            {
                _view.ShowErrorMessageBox(Constants.OnlyAdminAllowed);
                return;
            }

            if (!HandleInvalidForm(machine)) return;

            HandleValidForm(machine);

            _view.SetDialogResult(DialogResult.OK);
            _view.CloseForm();
        }

        //  Initialization helpers

        private void InitilizeEditForm(Machine machine)
        {
            _view.SetFormTitle(Constants.EditMachineTitle);
            _view.FillForm(machine);
        }

        //  Helper methods

        private void HandleValidForm(Machine machine)
        {
            try
            {
                if (_machineToEdit == null)
                {
                    _repo.Insert(machine);
                    _view.ShowInfoMessageBox(Constants.CreateSuccess);
                }
                else
                {
                    _repo.Update(machine);
                    _view.ShowInfoMessageBox(Constants.UpdateSuccess);
                }
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessageBox(ex.Message);
            }
        }

        private bool HandleInvalidForm(Machine machine)
        {
            var errors = ValidationUtils.ValidateRequiredFields(
                (machine.Name, "Name"),
                (machine.SerialNumber, "Serial Number")
            );

            if (errors.Count != 0)
            {
                _view.ShowValidationErrors(errors);
                return false;
            }

            return true;
        }
    }
}
