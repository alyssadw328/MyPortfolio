namespace ExceptionHandlersGroupProject1
{
    partial class SignupForm
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
            this.userNameCreate = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLblCreate = new System.Windows.Forms.Label();
            this.createPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teamSelectCombo = new System.Windows.Forms.ComboBox();
            this.loginNowButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameCreate
            // 
            this.userNameCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameCreate.Location = new System.Drawing.Point(169, 102);
            this.userNameCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameCreate.Name = "userNameCreate";
            this.userNameCreate.Size = new System.Drawing.Size(165, 25);
            this.userNameCreate.TabIndex = 0;
            this.userNameCreate.Text = "Create Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(367, 102);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 27);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordLblCreate
            // 
            this.passwordLblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLblCreate.Location = new System.Drawing.Point(172, 153);
            this.passwordLblCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLblCreate.Name = "passwordLblCreate";
            this.passwordLblCreate.Size = new System.Drawing.Size(160, 25);
            this.passwordLblCreate.TabIndex = 2;
            this.passwordLblCreate.Text = "Create Password:";
            // 
            // createPasswordTextBox
            // 
            this.createPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPasswordTextBox.Location = new System.Drawing.Point(365, 156);
            this.createPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.createPasswordTextBox.Name = "createPasswordTextBox";
            this.createPasswordTextBox.Size = new System.Drawing.Size(200, 27);
            this.createPasswordTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please Select Your Favorite Team:";
            // 
            // teamSelectCombo
            // 
            this.teamSelectCombo.FormattingEnabled = true;
            this.teamSelectCombo.Location = new System.Drawing.Point(367, 299);
            this.teamSelectCombo.Margin = new System.Windows.Forms.Padding(4);
            this.teamSelectCombo.Name = "teamSelectCombo";
            this.teamSelectCombo.Size = new System.Drawing.Size(160, 24);
            this.teamSelectCombo.TabIndex = 7;
            // 
            // loginNowButton
            // 
            this.loginNowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNowButton.Location = new System.Drawing.Point(173, 466);
            this.loginNowButton.Name = "loginNowButton";
            this.loginNowButton.Size = new System.Drawing.Size(260, 65);
            this.loginNowButton.TabIndex = 9;
            this.loginNowButton.Text = "Already Have an Account? Login Now";
            this.loginNowButton.UseVisualStyleBackColor = true;
            this.loginNowButton.Click += new System.EventHandler(this.loginNowButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(365, 207);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(200, 27);
            this.confirmPasswordTextBox.TabIndex = 5;
            // 
            // signupButton
            // 
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(226, 368);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(151, 64);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 605);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginNowButton);
            this.Controls.Add(this.teamSelectCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPasswordTextBox);
            this.Controls.Add(this.passwordLblCreate);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userNameCreate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignupForm";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameCreate;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLblCreate;
        private System.Windows.Forms.TextBox createPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teamSelectCombo;
        private System.Windows.Forms.Button loginNowButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button signupButton;
    }
}