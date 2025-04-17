namespace MachineApp.Views.Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbLogin = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            panLeftSide = new Panel();
            unUnderline = new Panel();
            txtPassword = new TextBox();
            passUnderline = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            label2 = new Label();
            lbMachineApp = new Label();
            panLeftSide.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(615, 29);
            lbLogin.Margin = new Padding(4, 0, 4, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.RightToLeft = RightToLeft.Yes;
            lbLogin.Size = new Size(76, 30);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "LOGIN";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(15, 15, 15);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(378, 156);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "USERNAME";
            txtUsername.Size = new Size(572, 22);
            txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(15, 15, 15);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(378, 357);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(572, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // panLeftSide
            // 
            panLeftSide.BackColor = SystemColors.ControlDarkDark;
            panLeftSide.Controls.Add(label2);
            panLeftSide.Controls.Add(lbMachineApp);
            panLeftSide.Dock = DockStyle.Left;
            panLeftSide.Location = new Point(0, 0);
            panLeftSide.Margin = new Padding(4);
            panLeftSide.Name = "panLeftSide";
            panLeftSide.Size = new Size(321, 460);
            panLeftSide.TabIndex = 4;
            // 
            // unUnderline
            // 
            unUnderline.BackColor = SystemColors.ControlLight;
            unUnderline.Location = new Point(378, 181);
            unUnderline.Margin = new Padding(4);
            unUnderline.Name = "unUnderline";
            unUnderline.Size = new Size(572, 1);
            unUnderline.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(378, 238);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "PASSWORD";
            txtPassword.Size = new Size(572, 22);
            txtPassword.TabIndex = 2;
            // 
            // passUnderline
            // 
            passUnderline.BackColor = SystemColors.ControlLight;
            passUnderline.Location = new Point(378, 263);
            passUnderline.Margin = new Padding(4);
            passUnderline.Name = "passUnderline";
            passUnderline.Size = new Size(572, 1);
            passUnderline.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe MDL2 Assets", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(964, 0);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe MDL2 Assets", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(926, 0);
            btnMinimize.Margin = new Padding(4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(39, 35);
            btnMinimize.TabIndex = 8;
            btnMinimize.Text = "";
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 226);
            label2.Name = "label2";
            label2.Size = new Size(316, 34);
            label2.TabIndex = 12;
            label2.Text = "[Manage Your Machines]";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbMachineApp
            // 
            lbMachineApp.Font = new Font("Malgun Gothic", 19F);
            lbMachineApp.Location = new Point(2, 181);
            lbMachineApp.Name = "lbMachineApp";
            lbMachineApp.Size = new Size(316, 45);
            lbMachineApp.TabIndex = 11;
            lbMachineApp.Text = "MachineApp";
            lbMachineApp.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1003, 460);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(passUnderline);
            Controls.Add(txtPassword);
            Controls.Add(unUnderline);
            Controls.Add(panLeftSide);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lbLogin);
            Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panLeftSide.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private TextBox txtUsername;
        private Button btnLogin;
        private Panel panLeftSide;
        private Panel unUnderline;
        private TextBox txtPassword;
        private Panel passUnderline;
        private Button btnClose;
        private Button btnMinimize;
        private Label label2;
        private Label lbMachineApp;
    }
}
