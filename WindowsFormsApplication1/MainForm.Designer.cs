namespace PaymentProcessingProject
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.greetingLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.servicesAndPayGridView = new System.Windows.Forms.DataGridView();
            this.newPaymentLabel = new System.Windows.Forms.Label();
            this.enterAmountLabel = new System.Windows.Forms.Label();
            this.paymentAmountTextBox = new System.Windows.Forms.TextBox();
            this.payButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndPayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(12, 9);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(55, 13);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = Constants.MAIN_FORM_GREETINGS_LABEL_STRING;
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new System.Drawing.Point(12, 32);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(163, 13);
            this.servicesLabel.TabIndex = 2;
            this.servicesLabel.Text = Constants.MAIN_FORM_PROVIDED_DERVICES_LABEL_STRING;
            // 
            // servicesAndPayGridView
            // 
            this.servicesAndPayGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.servicesAndPayGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.servicesAndPayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesAndPayGridView.Location = new System.Drawing.Point(15, 48);
            this.servicesAndPayGridView.Name = "servicesAndPayGridView";
            this.servicesAndPayGridView.Size = new System.Drawing.Size(600, 140);
            this.servicesAndPayGridView.TabIndex = 3;
            // 
            // newPaymentLabel
            // 
            this.newPaymentLabel.AutoSize = true;
            this.newPaymentLabel.Location = new System.Drawing.Point(12, 201);
            this.newPaymentLabel.Name = "newPaymentLabel";
            this.newPaymentLabel.Size = new System.Drawing.Size(75, 13);
            this.newPaymentLabel.TabIndex = 4;
            this.newPaymentLabel.Text = Constants.MAIN_FORM_NEW_PAYMENT_LABEL_STRING;
            // 
            // enterAmountLabel
            // 
            this.enterAmountLabel.AutoSize = true;
            this.enterAmountLabel.Location = new System.Drawing.Point(12, 220);
            this.enterAmountLabel.Name = "enterAmountLabel";
            this.enterAmountLabel.Size = new System.Drawing.Size(73, 13);
            this.enterAmountLabel.TabIndex = 5;
            this.enterAmountLabel.Text = Constants.MAIN_FORM_ENTER_AMOUNT_LABEL_STRING;
            // 
            // paymentAmountTextBox
            // 
            this.paymentAmountTextBox.Location = new System.Drawing.Point(91, 217);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(84, 20);
            this.paymentAmountTextBox.TabIndex = 6;
            this.paymentAmountTextBox.Text = Constants.MAIN_FORM_AMOUNT_DEFAULT_STRING;
            this.paymentAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.paymentAmountTextBox.Enter += new System.EventHandler(this.textBox1_Focused);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(181, 215);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 7;
            this.payButton.Text = Constants.MAIN_FORM_PAY_BUTTON_STRING;
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(540, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = Constants.MAIN_FORM_EXIT_BUTTON_STRING;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 248);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.paymentAmountTextBox);
            this.Controls.Add(this.enterAmountLabel);
            this.Controls.Add(this.newPaymentLabel);
            this.Controls.Add(this.servicesAndPayGridView);
            this.Controls.Add(this.servicesLabel);
            this.Controls.Add(this.greetingLabel);
            this.Name = "MainForm";
            this.Text = Constants.MAIN_FORM_TITLE_STRING;
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndPayGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.DataGridView servicesAndPayGridView;
        private System.Windows.Forms.Label newPaymentLabel;
        private System.Windows.Forms.Label enterAmountLabel;
        private System.Windows.Forms.TextBox paymentAmountTextBox;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button exitButton;
    }
}

