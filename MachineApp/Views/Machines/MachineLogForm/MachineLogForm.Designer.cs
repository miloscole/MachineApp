namespace MachineApp.Views.Machines.MachineLogForm
{
    partial class MachineLogForm
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
            btnSave = new Button();
            lbTitle = new Label();
            btnCancel = new Button();
            lbStartProduction = new Label();
            lbId = new Label();
            dtStartProduction = new DateTimePicker();
            dtEndProduction = new DateTimePicker();
            lbEndProduction = new Label();
            dtDeliveryDate = new DateTimePicker();
            lbDeliveryDate = new Label();
            lbMachineId = new Label();
            lbMachineIdTextWrapper = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(15, 15, 15);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnSave.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Location = new Point(32, 453);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(270, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = SystemColors.ControlLight;
            lbTitle.Location = new Point(17, 31);
            lbTitle.Margin = new Padding(5, 0, 5, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.RightToLeft = RightToLeft.Yes;
            lbTitle.Size = new Size(635, 36);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "TRACK PRODUCTION AND DELIVERY";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(15, 15, 15);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnCancel.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlLight;
            btnCancel.Location = new Point(362, 453);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(270, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lbStartProduction
            // 
            lbStartProduction.ForeColor = SystemColors.ControlDarkDark;
            lbStartProduction.Location = new Point(32, 143);
            lbStartProduction.Name = "lbStartProduction";
            lbStartProduction.Size = new Size(270, 24);
            lbStartProduction.TabIndex = 7;
            lbStartProduction.Text = "START PRODUCTION DATE";
            lbStartProduction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(578, 81);
            lbId.Name = "lbId";
            lbId.Size = new Size(0, 21);
            lbId.TabIndex = 20;
            lbId.Visible = false;
            // 
            // dtStartProduction
            // 
            dtStartProduction.CalendarMonthBackground = Color.FromArgb(15, 15, 15);
            dtStartProduction.Checked = false;
            dtStartProduction.Location = new Point(32, 170);
            dtStartProduction.Name = "dtStartProduction";
            dtStartProduction.ShowCheckBox = true;
            dtStartProduction.Size = new Size(600, 29);
            dtStartProduction.TabIndex = 1;
            // 
            // dtEndProduction
            // 
            dtEndProduction.CalendarMonthBackground = Color.FromArgb(15, 15, 15);
            dtEndProduction.Checked = false;
            dtEndProduction.Location = new Point(32, 262);
            dtEndProduction.Name = "dtEndProduction";
            dtEndProduction.ShowCheckBox = true;
            dtEndProduction.Size = new Size(600, 29);
            dtEndProduction.TabIndex = 2;
            // 
            // lbEndProduction
            // 
            lbEndProduction.ForeColor = SystemColors.ControlDarkDark;
            lbEndProduction.Location = new Point(32, 235);
            lbEndProduction.Name = "lbEndProduction";
            lbEndProduction.Size = new Size(270, 24);
            lbEndProduction.TabIndex = 8;
            lbEndProduction.Text = "END PRODUCTION DATE";
            lbEndProduction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtDeliveryDate
            // 
            dtDeliveryDate.CalendarMonthBackground = Color.FromArgb(15, 15, 15);
            dtDeliveryDate.Checked = false;
            dtDeliveryDate.Location = new Point(32, 360);
            dtDeliveryDate.Name = "dtDeliveryDate";
            dtDeliveryDate.ShowCheckBox = true;
            dtDeliveryDate.Size = new Size(600, 29);
            dtDeliveryDate.TabIndex = 3;
            // 
            // lbDeliveryDate
            // 
            lbDeliveryDate.ForeColor = SystemColors.ControlDarkDark;
            lbDeliveryDate.Location = new Point(32, 333);
            lbDeliveryDate.Name = "lbDeliveryDate";
            lbDeliveryDate.Size = new Size(270, 24);
            lbDeliveryDate.TabIndex = 9;
            lbDeliveryDate.Text = "DELIVERY DATE";
            lbDeliveryDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMachineId
            // 
            lbMachineId.AutoSize = true;
            lbMachineId.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMachineId.ForeColor = SystemColors.ControlLight;
            lbMachineId.Location = new Point(119, 83);
            lbMachineId.Name = "lbMachineId";
            lbMachineId.Size = new Size(0, 20);
            lbMachineId.TabIndex = 21;
            lbMachineId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMachineIdTextWrapper
            // 
            lbMachineIdTextWrapper.AutoSize = true;
            lbMachineIdTextWrapper.ForeColor = SystemColors.ControlLight;
            lbMachineIdTextWrapper.Location = new Point(32, 82);
            lbMachineIdTextWrapper.Name = "lbMachineIdTextWrapper";
            lbMachineIdTextWrapper.Size = new Size(90, 21);
            lbMachineIdTextWrapper.TabIndex = 22;
            lbMachineIdTextWrapper.Text = "MachineId:";
            lbMachineIdTextWrapper.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe MDL2 Assets", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(628, 2);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 35);
            btnClose.TabIndex = 25;
            btnClose.Text = "";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // MachineLogForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(666, 545);
            Controls.Add(btnClose);
            Controls.Add(lbMachineIdTextWrapper);
            Controls.Add(lbMachineId);
            Controls.Add(dtDeliveryDate);
            Controls.Add(lbDeliveryDate);
            Controls.Add(dtEndProduction);
            Controls.Add(lbEndProduction);
            Controls.Add(dtStartProduction);
            Controls.Add(lbId);
            Controls.Add(lbStartProduction);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbTitle);
            Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MachineLogForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Machine Logs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label lbTitle;
        private Button btnCancel;
        private Label lbStartProduction;
        private Label lbId;
        private DateTimePicker dtStartProduction;
        private DateTimePicker dtEndProduction;
        private Label lbEndProduction;
        private DateTimePicker dtDeliveryDate;
        private Label lbDeliveryDate;
        private Label lbMachineId;
        private Label lbMachineIdTextWrapper;
        private Button btnClose;
    }
}