
using MachineApp.Models;

namespace MachineApp.Views.Machines.MachineLogForm
{
    public partial class MachineLogForm : Form, IMachineLogForm
    {
        public event Action? SaveLogRequested;

        public MachineLogForm()
        {
            InitializeComponent();
            AttachEvents();
        }

        public MachineLog GetFormData()
        {
            return new MachineLog
            {
                Id = int.TryParse(lbId.Text, out var id) ? id : 0,
                MachineId = int.Parse(lbMachineId.Text),
                StartProductionDate = dtStartProduction.Checked ? dtStartProduction.Value : null,
                EndProductionDate = dtEndProduction.Checked ? dtEndProduction.Value : null,
                DeliveryDate = dtDeliveryDate.Checked ? dtDeliveryDate.Value : null
            };
        }

        public void SetMachineId(int id) => lbMachineId.Text = id.ToString();

        public void FillForm(MachineLog log)
        {
            lbId.Text = log.Id.ToString();
            lbMachineId.Text = log.MachineId.ToString();
            InitilizeDateFields(log.StartProductionDate, log.EndProductionDate, log.DeliveryDate);
        }

        public void ShowInfoMessageBox(string msg) =>
            MessageBox.Show(msg, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void ShowErrorMessageBox(string msg) =>
            MessageBox.Show(msg, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void CloseForm() => this.Close();

        private void AttachEvents()
        {
            btnSave.Click += (s, e) => SaveLogRequested?.Invoke();
            btnCancel.Click += (s, e) => Close();
        }

        private void InitilizeDateFields(DateTime? sDate, DateTime? eDate, DateTime? dDate)
        {
            dtStartProduction.Checked = sDate.HasValue;
            if (sDate.HasValue) dtStartProduction.Value = sDate.Value;

            dtEndProduction.Checked = eDate.HasValue;
            if (eDate.HasValue) dtEndProduction.Value = eDate.Value;

            dtDeliveryDate.Checked = dDate.HasValue;
            if (dDate.HasValue) dtDeliveryDate.Value = dDate.Value;
        }
    }
}
