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
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = Color.White;
            lbLogin.Location = new Point(478, 21);
            lbLogin.Name = "lbLogin";
            lbLogin.RightToLeft = RightToLeft.Yes;
            lbLogin.Size = new Size(76, 30);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "LOGIN";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(15, 15, 15);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(294, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "USERNAME";
            txtUsername.Size = new Size(445, 22);
            txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(15, 15, 15);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(294, 255);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(445, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // panLeftSide
            // 
            panLeftSide.BackColor = SystemColors.ControlDarkDark;
            panLeftSide.Dock = DockStyle.Left;
            panLeftSide.Location = new Point(0, 0);
            panLeftSide.Name = "panLeftSide";
            panLeftSide.Size = new Size(250, 330);
            panLeftSide.TabIndex = 4;
            // 
            // unUnderline
            // 
            unUnderline.BackColor = SystemColors.ControlDarkDark;
            unUnderline.Location = new Point(294, 129);
            unUnderline.Name = "unUnderline";
            unUnderline.Size = new Size(445, 1);
            unUnderline.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(294, 164);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "PASSWORD";
            txtPassword.Size = new Size(445, 22);
            txtPassword.TabIndex = 2;
            // 
            // passUnderline
            // 
            passUnderline.BackColor = SystemColors.ControlDarkDark;
            passUnderline.Location = new Point(294, 188);
            passUnderline.Name = "passUnderline";
            passUnderline.Size = new Size(445, 1);
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
            btnClose.Location = new Point(750, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 25);
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
            btnMinimize.Location = new Point(720, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 25);
            btnMinimize.TabIndex = 8;
            btnMinimize.Text = "";
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(passUnderline);
            Controls.Add(txtPassword);
            Controls.Add(unUnderline);
            Controls.Add(panLeftSide);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lbLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
    }
}
