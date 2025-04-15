using MachineApp.Models;

namespace MachineApp.Views.Machines.MachinesList
{
    public interface IMachineList
    {
        event Action? LoadMachines;
        event Action? AddMachineRequested;
        event Action<Machine>? EditMachineRequested;
        event Action? DeleteMachineRequested;
        event Action<int>? MachineLogRequested;
        event Action? LogoutRequested;
        void DisplayMachines(List<Machine> machines);
        void ShowErrorOnLoad(string message);
        void ShowErrorOnDelete(string message);
        bool ShouldConfirmDeletion();
        void HideAdminControls();
        void CloseForm();
        Machine? SelectedMachine { get; }
    }
}
