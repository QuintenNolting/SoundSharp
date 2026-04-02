namespace SoundSharp
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(12, 37);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(268, 31);
            tbxUsername.TabIndex = 0;
            tbxUsername.TextChanged += tbxUsername_TextChanged;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(12, 99);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(268, 31);
            tbxPassword.TabIndex = 1;
            tbxPassword.TextChanged += tbxPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(60, 133);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(43, 169);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 3;
            lblError.Click += lblError_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 71);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 297);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Label lblError;
        private Label lblUsername;
        private Label lblPassword;
    }
}