namespace BasicInfoGUI
{
    partial class Login
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
            this.labelSignUp = new System.Windows.Forms.Label();
            this.labelDontHaveAccount = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxCredentials = new System.Windows.Forms.TextBox();
            this.labelLoginCredentials = new System.Windows.Forms.Label();
            this.GeneralLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.Location = new System.Drawing.Point(370, 328);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(62, 18);
            this.labelSignUp.TabIndex = 49;
            this.labelSignUp.Text = "SignUp";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // labelDontHaveAccount
            // 
            this.labelDontHaveAccount.AutoSize = true;
            this.labelDontHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontHaveAccount.Location = new System.Drawing.Point(201, 328);
            this.labelDontHaveAccount.Name = "labelDontHaveAccount";
            this.labelDontHaveAccount.Size = new System.Drawing.Size(163, 18);
            this.labelDontHaveAccount.TabIndex = 48;
            this.labelDontHaveAccount.Text = "Don\'t have an account?";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(96, 222);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(427, 27);
            this.textBoxPassword.TabIndex = 47;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(94, 184);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 25);
            this.labelPassword.TabIndex = 46;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(255, 276);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(122, 37);
            this.buttonLogin.TabIndex = 43;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxCredentials
            // 
            this.textBoxCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCredentials.Location = new System.Drawing.Point(96, 132);
            this.textBoxCredentials.Name = "textBoxCredentials";
            this.textBoxCredentials.Size = new System.Drawing.Size(427, 27);
            this.textBoxCredentials.TabIndex = 42;
            // 
            // labelLoginCredentials
            // 
            this.labelLoginCredentials.AutoSize = true;
            this.labelLoginCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginCredentials.Location = new System.Drawing.Point(94, 95);
            this.labelLoginCredentials.Name = "labelLoginCredentials";
            this.labelLoginCredentials.Size = new System.Drawing.Size(156, 25);
            this.labelLoginCredentials.TabIndex = 38;
            this.labelLoginCredentials.Text = "Email or Number";
            // 
            // GeneralLabel
            // 
            this.GeneralLabel.AutoSize = true;
            this.GeneralLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralLabel.Location = new System.Drawing.Point(263, 24);
            this.GeneralLabel.Name = "GeneralLabel";
            this.GeneralLabel.Size = new System.Drawing.Size(90, 32);
            this.GeneralLabel.TabIndex = 35;
            this.GeneralLabel.Text = "Login";
            this.GeneralLabel.Click += new System.EventHandler(this.GeneralLabel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 453);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelDontHaveAccount);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxCredentials);
            this.Controls.Add(this.labelLoginCredentials);
            this.Controls.Add(this.GeneralLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label labelDontHaveAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxCredentials;
        private System.Windows.Forms.Label labelLoginCredentials;
        private System.Windows.Forms.Label GeneralLabel;
    }
}