using MachineApp.Models;
using MachineApp.Presenters;
using MachineApp.Repositories.MachineLogRepository;
using MachineApp.Repositories.MachineRepository;
using MachineApp.Repositories.UserRepository;
using MachineApp.Views.Login;
using MachineApp.Views.Machines.MachineForm;
using MachineApp.Views.Machines.MachineLogForm;
using MachineApp.Views.Machines.MachinesList;

namespace MachineApp.Factory
{
    public class ViewFactory : IViewFactory
    {
        public Form CreateLoginView()
        {
            var loginView = new Login();
            _ = new LoginPresenter(loginView, new UserRepo());
            return loginView;
        }

        public Form CreateMachinesListView()
        {
            var mlView = new MachinesList();
            _ = new MachinesListPresenter(mlView, new MachineRepo(), this);
            return mlView;
        }

        public Form CreateMachineFormView(Machine? machine = null)
        {
            var formView = new MachineForm();
            _ = new MachineFormPresenter(formView, new MachineRepo(), machine);
            return formView;
        }

        public Form CreateMachineLogFormView(int id)
        {
            var mlfView = new MachineLogForm();
            _ = new MachineLogPresenter(mlfView, new MachineLogRepo(), id);
            return mlfView;
        }
    }

}
