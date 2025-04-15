namespace MachineApp.Views.Machines.MachineForm
{
    partial class MachineForm
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
            nameUnderline = new Panel();
            btnSave = new Button();
            txtName = new TextBox();
            lbTitle = new Label();
            txtSerialNum = new TextBox();
            snUnderline = new Panel();
            txtSpec = new TextBox();
            specUnderline = new Panel();
            ddTypes = new ComboBox();
            btnCancel = new Button();
            lbType = new Label();
            lbId = new Label();
            SuspendLayout();
            // 
            // nameUnderline
            // 
            nameUnderline.BackColor = SystemColors.ControlLight;
            nameUnderline.Location = new Point(32, 147);
            nameUnderline.Margin = new Padding(5, 6, 5, 6);
            nameUnderline.Name = "nameUnderline";
            nameUnderline.Size = new Size(600, 1);
            nameUnderline.TabIndex = 20;
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
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(15, 15, 15);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(32, 120);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "NAME";
            txtName.Size = new Size(600, 22);
            txtName.TabIndex = 1;
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
            lbTitle.TabIndex = 7;
            lbTitle.Text = "ADD MACHINE";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSerialNum
            // 
            txtSerialNum.BackColor = Color.FromArgb(15, 15, 15);
            txtSerialNum.BorderStyle = BorderStyle.None;
            txtSerialNum.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSerialNum.ForeColor = Color.White;
            txtSerialNum.Location = new Point(32, 196);
            txtSerialNum.Margin = new Padding(5, 6, 5, 6);
            txtSerialNum.Name = "txtSerialNum";
            txtSerialNum.PlaceholderText = "SERIAL NUMBER";
            txtSerialNum.Size = new Size(600, 22);
            txtSerialNum.TabIndex = 2;
            // 
            // snUnderline
            // 
            snUnderline.BackColor = SystemColors.ControlLight;
            snUnderline.Location = new Point(32, 223);
            snUnderline.Margin = new Padding(5, 6, 5, 6);
            snUnderline.Name = "snUnderline";
            snUnderline.Size = new Size(600, 1);
            snUnderline.TabIndex = 21;
            // 
            // txtSpec
            // 
            txtSpec.BackColor = Color.FromArgb(15, 15, 15);
            txtSpec.BorderStyle = BorderStyle.None;
            txtSpec.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpec.ForeColor = Color.White;
            txtSpec.Location = new Point(32, 268);
            txtSpec.Margin = new Padding(5, 6, 5, 6);
            txtSpec.Name = "txtSpec";
            txtSpec.PlaceholderText = "SPECIFICATIONS";
            txtSpec.Size = new Size(600, 22);
            txtSpec.TabIndex = 3;
            // 
            // specUnderline
            // 
            specUnderline.BackColor = SystemColors.ControlLight;
            specUnderline.Location = new Point(32, 295);
            specUnderline.Margin = new Padding(5, 6, 5, 6);
            specUnderline.Name = "specUnderline";
            specUnderline.Size = new Size(600, 1);
            specUnderline.TabIndex = 22;
            // 
            // ddTypes
            // 
            ddTypes.BackColor = Color.FromArgb(15, 15, 15);
            ddTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            ddTypes.ForeColor = SystemColors.ControlDarkDark;
            ddTypes.FormattingEnabled = true;
            ddTypes.Location = new Point(32, 366);
            ddTypes.Margin = new Padding(4);
            ddTypes.Name = "ddTypes";
            ddTypes.Size = new Size(600, 29);
            ddTypes.TabIndex = 4;
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
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lbType
            // 
            lbType.ForeColor = SystemColors.ControlDarkDark;
            lbType.Location = new Point(32, 338);
            lbType.Name = "lbType";
            lbType.Size = new Size(270, 24);
            lbType.TabIndex = 8;
            lbType.Text = "MACHINE TYPE";
            lbType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(578, 81);
            lbId.Name = "lbId";
            lbId.Size = new Size(0, 21);
            lbId.TabIndex = 23;
            lbId.Visible = false;
            // 
            // MachineForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(666, 545);
            Controls.Add(lbId);
            Controls.Add(lbType);
            Controls.Add(btnCancel);
            Controls.Add(ddTypes);
            Controls.Add(snUnderline);
            Controls.Add(specUnderline);
            Controls.Add(txtSerialNum);
            Controls.Add(txtSpec);
            Controls.Add(nameUnderline);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(lbTitle);
            Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "MachineForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MachineForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel nameUnderline;
        private Button btnSave;
        private TextBox txtName;
        private Label lbTitle;
        private TextBox txtSerialNum;
        private Panel snUnderline;
        private TextBox txtSpec;
        private Panel specUnderline;
        private ComboBox ddTypes;
        private Button btnCancel;
        private Label lbType;
        private Label lbId;
    }
}