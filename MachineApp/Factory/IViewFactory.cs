using MachineApp.Models;

namespace MachineApp.Factory
{
    public interface IViewFactory
    {
        Form CreateLoginView();
        Form CreateMachinesListView();
        Form CreateMachineFormView(Machine? machine = null);
    }
}
