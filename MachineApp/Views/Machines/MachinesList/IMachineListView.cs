

using MachineApp.Models;

namespace MachineApp.Views.Machines.MachinesList
{
    public interface IMachineListView
    {
        event EventHandler? LoadMachines;
        event EventHandler AddMachineRequested;
        event EventHandler EditMachineRequested;
        event EventHandler DeleteMachineRequested;
        event EventHandler LogoutRequested;
        void DisplayMachines(List<Machine> machines);
        void ShowError(string message);
        void HideAdminControls();
        void Close();
    }
}
