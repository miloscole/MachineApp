
using MachineApp.Models;

namespace MachineApp.Views.Machines.MachineForm
{
    public interface IMachineForm
    {
        event Action SaveMachineRequested;
        void FillForm(Machine machine);
        void CloseForm();
        void SetDialogResult(DialogResult result);
        void SetFormTitle(string title);
        void ShowValidationErrors(List<string> errors);
        List<MachineType> MachineTypes { set; }
        Machine GetMachineData();
    }
}
