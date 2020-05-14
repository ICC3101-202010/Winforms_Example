namespace FormsExample
{
    partial class AppForm
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
            this.LoginView = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginViewUserInput = new System.Windows.Forms.TextBox();
            this.loginViewPassWordInput = new System.Windows.Forms.TextBox();
            this.loginViewButton = new System.Windows.Forms.Button();
            this.profileView = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.profileViewUserText = new System.Windows.Forms.Label();
            this.profileViewAgeText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginViewInvalidCredentialsAlert = new System.Windows.Forms.Label();
            this.profileViewNameText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.profileViewLogOutButton = new System.Windows.Forms.Button();
            this.LoginView.SuspendLayout();
            this.profileView.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginView
            // 
            this.LoginView.Controls.Add(this.loginViewInvalidCredentialsAlert);
            this.LoginView.Controls.Add(this.loginViewButton);
            this.LoginView.Controls.Add(this.loginViewPassWordInput);
            this.LoginView.Controls.Add(this.loginViewUserInput);
            this.LoginView.Controls.Add(this.label2);
            this.LoginView.Controls.Add(this.label1);
            this.LoginView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginView.Location = new System.Drawing.Point(0, 0);
            this.LoginView.Name = "LoginView";
            this.LoginView.Size = new System.Drawing.Size(454, 450);
            this.LoginView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // loginViewUserInput
            // 
            this.loginViewUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginViewUserInput.Location = new System.Drawing.Point(186, 153);
            this.loginViewUserInput.Name = "loginViewUserInput";
            this.loginViewUserInput.Size = new System.Drawing.Size(202, 30);
            this.loginViewUserInput.TabIndex = 2;
            // 
            // loginViewPassWordInput
            // 
            this.loginViewPassWordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginViewPassWordInput.Location = new System.Drawing.Point(186, 191);
            this.loginViewPassWordInput.Name = "loginViewPassWordInput";
            this.loginViewPassWordInput.PasswordChar = '*';
            this.loginViewPassWordInput.Size = new System.Drawing.Size(202, 30);
            this.loginViewPassWordInput.TabIndex = 3;
            // 
            // loginViewButton
            // 
            this.loginViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginViewButton.Location = new System.Drawing.Point(186, 256);
            this.loginViewButton.Name = "loginViewButton";
            this.loginViewButton.Size = new System.Drawing.Size(145, 39);
            this.loginViewButton.TabIndex = 4;
            this.loginViewButton.Text = "Login";
            this.loginViewButton.UseVisualStyleBackColor = true;
            this.loginViewButton.Click += new System.EventHandler(this.loginViewButton_Click);
            // 
            // profileView
            // 
            this.profileView.Controls.Add(this.profileViewLogOutButton);
            this.profileView.Controls.Add(this.profileViewNameText);
            this.profileView.Controls.Add(this.label6);
            this.profileView.Controls.Add(this.profileViewAgeText);
            this.profileView.Controls.Add(this.label5);
            this.profileView.Controls.Add(this.profileViewUserText);
            this.profileView.Controls.Add(this.label3);
            this.profileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileView.Location = new System.Drawing.Point(0, 0);
            this.profileView.Name = "profileView";
            this.profileView.Size = new System.Drawing.Size(454, 450);
            this.profileView.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario";
            // 
            // profileViewUserText
            // 
            this.profileViewUserText.AutoSize = true;
            this.profileViewUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileViewUserText.Location = new System.Drawing.Point(123, 41);
            this.profileViewUserText.Name = "profileViewUserText";
            this.profileViewUserText.Size = new System.Drawing.Size(79, 25);
            this.profileViewUserText.TabIndex = 1;
            this.profileViewUserText.Text = "Usuario";
            // 
            // profileViewAgeText
            // 
            this.profileViewAgeText.AutoSize = true;
            this.profileViewAgeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileViewAgeText.Location = new System.Drawing.Point(123, 113);
            this.profileViewAgeText.Name = "profileViewAgeText";
            this.profileViewAgeText.Size = new System.Drawing.Size(79, 25);
            this.profileViewAgeText.TabIndex = 3;
            this.profileViewAgeText.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Edad";
            // 
            // loginViewInvalidCredentialsAlert
            // 
            this.loginViewInvalidCredentialsAlert.AutoSize = true;
            this.loginViewInvalidCredentialsAlert.Location = new System.Drawing.Point(186, 233);
            this.loginViewInvalidCredentialsAlert.Name = "loginViewInvalidCredentialsAlert";
            this.loginViewInvalidCredentialsAlert.Size = new System.Drawing.Size(46, 17);
            this.loginViewInvalidCredentialsAlert.TabIndex = 5;
            this.loginViewInvalidCredentialsAlert.Text = "label4";
            this.loginViewInvalidCredentialsAlert.Visible = false;
            // 
            // profileViewNameText
            // 
            this.profileViewNameText.AutoSize = true;
            this.profileViewNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileViewNameText.Location = new System.Drawing.Point(123, 77);
            this.profileViewNameText.Name = "profileViewNameText";
            this.profileViewNameText.Size = new System.Drawing.Size(81, 25);
            this.profileViewNameText.TabIndex = 5;
            this.profileViewNameText.Text = "Nombre";
            this.profileViewNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // profileViewLogOutButton
            // 
            this.profileViewLogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileViewLogOutButton.Location = new System.Drawing.Point(43, 192);
            this.profileViewLogOutButton.Name = "profileViewLogOutButton";
            this.profileViewLogOutButton.Size = new System.Drawing.Size(161, 47);
            this.profileViewLogOutButton.TabIndex = 6;
            this.profileViewLogOutButton.Text = "Bye!";
            this.profileViewLogOutButton.UseVisualStyleBackColor = true;
            this.profileViewLogOutButton.Click += new System.EventHandler(this.profileViewLogOutButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.profileView);
            this.Controls.Add(this.LoginView);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.LoginView.ResumeLayout(false);
            this.LoginView.PerformLayout();
            this.profileView.ResumeLayout(false);
            this.profileView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginViewButton;
        private System.Windows.Forms.TextBox loginViewPassWordInput;
        private System.Windows.Forms.TextBox loginViewUserInput;
        private System.Windows.Forms.Panel profileView;
        private System.Windows.Forms.Label profileViewAgeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label profileViewUserText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loginViewInvalidCredentialsAlert;
        private System.Windows.Forms.Label profileViewNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button profileViewLogOutButton;
    }
}