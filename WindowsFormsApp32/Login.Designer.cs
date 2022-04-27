
namespace WindowsFormsApp32
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblSingUp = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSingUp
            // 
            this.lblSingUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSingUp.AutoSize = true;
            this.lblSingUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSingUp.ForeColor = System.Drawing.Color.White;
            this.lblSingUp.Location = new System.Drawing.Point(872, 286);
            this.lblSingUp.Name = "lblSingUp";
            this.lblSingUp.Size = new System.Drawing.Size(45, 13);
            this.lblSingUp.TabIndex = 5;
            this.lblSingUp.Text = "Sign Up";
            this.lblSingUp.Click += new System.EventHandler(this.lblSingUp_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(723, 286);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(86, 13);
            this.lblForgotPassword.TabIndex = 4;
            this.lblForgotPassword.Text = "Forgot Password";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(720, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginEmail.ForeColor = System.Drawing.Color.White;
            this.lblLoginEmail.Location = new System.Drawing.Point(720, 120);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(47, 17);
            this.lblLoginEmail.TabIndex = 13;
            this.lblLoginEmail.Text = "E-mail";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(720, 472);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(410, 130);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.AutoEllipsis = true;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(723, 238);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(192, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginPassword.BackColor = System.Drawing.Color.DarkGray;
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.Location = new System.Drawing.Point(723, 194);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(192, 20);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginEmail.BackColor = System.Drawing.Color.DarkGray;
            this.txtLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginEmail.ForeColor = System.Drawing.Color.Black;
            this.txtLoginEmail.Location = new System.Drawing.Point(723, 140);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoginEmail.Size = new System.Drawing.Size(194, 20);
            this.txtLoginEmail.TabIndex = 1;
            this.txtLoginEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Script MT Bold", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.White;
            this.lblProjectName.Location = new System.Drawing.Point(713, 25);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(469, 162);
            this.lblProjectName.TabIndex = 7;
            this.lblProjectName.Text = "Calorie Tracking";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp32.Properties.Resources.uygulamagirişfoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.lblSingUp);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.lblProjectName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Calorie Tracking(Login)";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSingUp;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Label lblProjectName;
    }
}