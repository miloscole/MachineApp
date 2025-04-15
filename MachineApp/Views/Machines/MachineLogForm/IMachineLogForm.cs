

using MachineApp.Models;

namespace MachineApp.Views.Machines.MachineLogForm
{
    public interface IMachineLogForm
    {
        event Action SaveLogRequested;
        void FillForm(MachineLog log);
        void CloseForm();
        void SetMachineId(int id);
        void ShowInfoMessageBox(string msg);
        MachineLog GetFormData();
    }
}
