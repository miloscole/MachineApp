namespace MachineApp.Views.Machines.MachinesList
{
    partial class MachinesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panLeftSide = new Panel();
            label2 = new Label();
            lbMachineApp = new Label();
            lblUserInfo = new Label();
            btnLogout = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLogs = new Button();
            btnAdd = new Button();
            label1 = new Label();
            dgvMachines = new DataGridView();
            lblGetMachinesError = new Label();
            panLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMachines).BeginInit();
            SuspendLayout();
            // 
            // panLeftSide
            // 
            panLeftSide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panLeftSide.BackColor = SystemColors.ControlDarkDark;
            panLeftSide.Controls.Add(label2);
            panLeftSide.Controls.Add(lbMachineApp);
            panLeftSide.Controls.Add(lblUserInfo);
            panLeftSide.Controls.Add(btnLogout);
            panLeftSide.Controls.Add(btnEdit);
            panLeftSide.Controls.Add(btnDelete);
            panLeftSide.Controls.Add(btnLogs);
            panLeftSide.Controls.Add(btnAdd);
            panLeftSide.Location = new Point(0, 0);
            panLeftSide.Margin = new Padding(4);
            panLeftSide.Name = "panLeftSide";
            panLeftSide.Size = new Size(322, 681);
            panLeftSide.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(316, 34);
            label2.TabIndex = 10;
            label2.Text = "[Manage Your Machines]";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbMachineApp
            // 
            lbMachineApp.Font = new Font("Malgun Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMachineApp.Location = new Point(3, 9);
            lbMachineApp.Name = "lbMachineApp";
            lbMachineApp.Size = new Size(316, 36);
            lbMachineApp.TabIndex = 9;
            lbMachineApp.Text = "MachineApp";
            lbMachineApp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUserInfo
            // 
            lblUserInfo.Anchor = AnchorStyles.Bottom;
            lblUserInfo.BackColor = SystemColors.ControlDarkDark;
            lblUserInfo.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserInfo.Location = new Point(3, 570);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(316, 46);
            lblUserInfo.TabIndex = 8;
            lblUserInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = SystemColors.ControlDarkDark;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 15, 15);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.ControlLight;
            btnLogout.Location = new Point(37, 619);
            btnLogout.Margin = new Padding(3, 3, 3, 50);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(245, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlDarkDark;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 15, 15);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ControlLight;
            btnEdit.Location = new Point(37, 277);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(245, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT MACHINE";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDarkDark;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 15, 15);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(37, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(245, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE MACHINE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnLogs
            // 
            btnLogs.BackColor = SystemColors.ControlDarkDark;
            btnLogs.Cursor = Cursors.Hand;
            btnLogs.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnLogs.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 15, 15);
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.ForeColor = SystemColors.ControlLight;
            btnLogs.Location = new Point(37, 431);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(245, 50);
            btnLogs.TabIndex = 3;
            btnLogs.Text = "MACHINE LOG";
            btnLogs.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDarkDark;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 15, 15);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ControlLight;
            btnAdd.Location = new Point(37, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(245, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD MACHINE";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(923, 30);
            label1.TabIndex = 5;
            label1.Text = "MACHINES LIST";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvMachines
            // 
            dgvMachines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMachines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMachines.BackgroundColor = SystemColors.ControlDarkDark;
            dgvMachines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMachines.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMachines.GridColor = SystemColors.ControlDark;
            dgvMachines.Location = new Point(331, 113);
            dgvMachines.MultiSelect = false;
            dgvMachines.Name = "dgvMachines";
            dgvMachines.ReadOnly = true;
            dgvMachines.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dgvMachines.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvMachines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMachines.Size = new Size(923, 556);
            dgvMachines.TabIndex = 6;
            // 
            // lblGetMachinesError
            // 
            lblGetMachinesError.BackColor = Color.Brown;
            lblGetMachinesError.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGetMachinesError.Location = new Point(331, 89);
            lblGetMachinesError.Name = "lblGetMachinesError";
            lblGetMachinesError.Size = new Size(923, 21);
            lblGetMachinesError.TabIndex = 7;
            lblGetMachinesError.TextAlign = ContentAlignment.TopCenter;
            lblGetMachinesError.Visible = false;
            // 
            // MachinesList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1264, 681);
            Controls.Add(lblGetMachinesError);
            Controls.Add(dgvMachines);
            Controls.Add(label1);
            Controls.Add(panLeftSide);
            Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(4);
            MinimumSize = new Size(1280, 720);
            Name = "MachinesList";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Machines List";
            panLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMachines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panLeftSide;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLogs;
        private DataGridView dgvMachines;
        private Button btnLogout;
        private Label lblUserInfo;
        private Label lblGetMachinesError;
        private Label lbMachineApp;
        private Label label2;
    }
}