
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

            _view.MachineTypes = _repo.GetAllMachineTypes();
            HandleEditForm();
            _view.SaveMachineRequested += OnSaveMachineRequested;
        }

        private void OnSaveMachineRequested()
        {
            var machine = _view.GetMachineData();
            var errors = ValidationErrors(machine);

            if (errors.Count != 0)
            {
                _view.ShowValidationErrors(errors);
                return;
            }

            if (_machineToEdit == null)
                _repo.Insert(machine);
            else
                _repo.Update(machine);

            _view.SetDialogResult(DialogResult.OK);
            _view.CloseForm();
        }

        private void HandleEditForm()
        {
            if (_machineToEdit != null)
            {
                _view.SetFormTitle("Edit Machine");
                _view.FillForm(_machineToEdit);
            }
        }

        private static List<string> ValidationErrors(Machine machine)
        {
            return ValidationUtils.ValidateRequiredFields(
                (machine.Name, "Name"),
                (machine.SerialNumber, "Serial Number")
            );
        }
    }
}
