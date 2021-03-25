namespace PaymentProcessingProject
{
    partial class LoginForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.devModeCheckBox = new System.Windows.Forms.CheckBox();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.initialCatalogTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.dbPasswordTextBox = new System.Windows.Forms.TextBox();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.initialCatalogLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.dbPasswordLabel = new System.Windows.Forms.Label();
            this.devModeSectionLabel = new System.Windows.Forms.Label();
            this.getLoginsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(9, 32);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 59);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // loginComboBox
            // 
            this.loginComboBox.FormattingEnabled = true;
            this.loginComboBox.Location = new System.Drawing.Point(68, 29);
            this.loginComboBox.Name = "loginComboBox";
            this.loginComboBox.Size = new System.Drawing.Size(187, 21);
            this.loginComboBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(68, 56);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(187, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 82);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(180, 82);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // devModeCheckBox
            // 
            this.devModeCheckBox.AutoSize = true;
            this.devModeCheckBox.Location = new System.Drawing.Point(12, 12);
            this.devModeCheckBox.Name = "devModeCheckBox";
            this.devModeCheckBox.Size = new System.Drawing.Size(73, 17);
            this.devModeCheckBox.TabIndex = 6;
            this.devModeCheckBox.Text = "DevMode";
            this.devModeCheckBox.UseVisualStyleBackColor = true;
            this.devModeCheckBox.CheckedChanged += new System.EventHandler(this.devModeCheckBox_CheckedChanged);
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Location = new System.Drawing.Point(68, 142);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(187, 20);
            this.dataSourceTextBox.TabIndex = 7;
            this.dataSourceTextBox.Text = Constants.LOGIN_FORM_DATA_SOURCE_DEFAULT_STRING;
            // 
            // initialCatalogTextBox
            // 
            this.initialCatalogTextBox.Location = new System.Drawing.Point(68, 169);
            this.initialCatalogTextBox.Name = "initialCatalogTextBox";
            this.initialCatalogTextBox.Size = new System.Drawing.Size(187, 20);
            this.initialCatalogTextBox.TabIndex = 8;
            this.initialCatalogTextBox.Text = Constants.LOGIN_FORM_INITIAL_CATALOG_DEFAULT_STRING;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(68, 194);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(187, 20);
            this.userIDTextBox.TabIndex = 9;
            this.userIDTextBox.Text = Constants.LOGIN_FORM_USER_ID_DEFAULT_STRING;
            // 
            // dbPasswordTextBox
            // 
            this.dbPasswordTextBox.Location = new System.Drawing.Point(68, 220);
            this.dbPasswordTextBox.Name = "dbPasswordTextBox";
            this.dbPasswordTextBox.Size = new System.Drawing.Size(187, 20);
            this.dbPasswordTextBox.TabIndex = 10;
            this.dbPasswordTextBox.Text = Constants.LOGIN_FORM_PASSWORD_DEFAULT_STRING;
            // 
            // dataSourceLabel
            // 
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Location = new System.Drawing.Point(9, 145);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(45, 13);
            this.dataSourceLabel.TabIndex = 11;
            this.dataSourceLabel.Text = "DB host";
            // 
            // initialCatalogLabel
            // 
            this.initialCatalogLabel.AutoSize = true;
            this.initialCatalogLabel.Location = new System.Drawing.Point(9, 172);
            this.initialCatalogLabel.Name = "initialCatalogLabel";
            this.initialCatalogLabel.Size = new System.Drawing.Size(51, 13);
            this.initialCatalogLabel.TabIndex = 12;
            this.initialCatalogLabel.Text = "DB name";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(9, 197);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(45, 13);
            this.userIDLabel.TabIndex = 13;
            this.userIDLabel.Text = "DB user";
            // 
            // dbPasswordLabel
            // 
            this.dbPasswordLabel.AutoSize = true;
            this.dbPasswordLabel.Location = new System.Drawing.Point(9, 223);
            this.dbPasswordLabel.Name = "dbPasswordLabel";
            this.dbPasswordLabel.Size = new System.Drawing.Size(47, 13);
            this.dbPasswordLabel.TabIndex = 14;
            this.dbPasswordLabel.Text = "DB pass";
            // 
            // devModeSectionLabel
            // 
            this.devModeSectionLabel.AutoSize = true;
            this.devModeSectionLabel.Location = new System.Drawing.Point(9, 126);
            this.devModeSectionLabel.Name = "devModeSectionLabel";
            this.devModeSectionLabel.Size = new System.Drawing.Size(115, 13);
            this.devModeSectionLabel.TabIndex = 15;
            this.devModeSectionLabel.Text = "DB connection options";
            // 
            // getLoginsButton
            // 
            this.getLoginsButton.Enabled = false;
            this.getLoginsButton.Location = new System.Drawing.Point(93, 82);
            this.getLoginsButton.Name = "getLoginsButton";
            this.getLoginsButton.Size = new System.Drawing.Size(81, 23);
            this.getLoginsButton.TabIndex = 16;
            this.getLoginsButton.Text = "Get logins";
            this.getLoginsButton.UseVisualStyleBackColor = true;
            this.getLoginsButton.Click += new System.EventHandler(this.getLoginsButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 115);
            this.Controls.Add(this.getLoginsButton);
            this.Controls.Add(this.devModeSectionLabel);
            this.Controls.Add(this.dbPasswordLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.initialCatalogLabel);
            this.Controls.Add(this.dataSourceLabel);
            this.Controls.Add(this.dbPasswordTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.initialCatalogTextBox);
            this.Controls.Add(this.dataSourceTextBox);
            this.Controls.Add(this.devModeCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginComboBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginForm";
            this.Text = "Please login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ComboBox loginComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox devModeCheckBox;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.TextBox initialCatalogTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox dbPasswordTextBox;
        private System.Windows.Forms.Label dataSourceLabel;
        private System.Windows.Forms.Label initialCatalogLabel;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label dbPasswordLabel;
        private System.Windows.Forms.Label devModeSectionLabel;
        private System.Windows.Forms.Button getLoginsButton;
    }
}