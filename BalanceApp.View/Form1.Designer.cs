namespace BalanceApp.View
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.warning_alarm = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.goToRegistration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(255, 102);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(329, 57);
            this.LoginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(255, 193);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(329, 52);
            this.PasswordBox.TabIndex = 1;
            // 
            // warning_alarm
            // 
            this.warning_alarm.ForeColor = System.Drawing.Color.Red;
            this.warning_alarm.Location = new System.Drawing.Point(255, 348);
            this.warning_alarm.Name = "warning_alarm";
            this.warning_alarm.Size = new System.Drawing.Size(329, 23);
            this.warning_alarm.TabIndex = 2;
            this.warning_alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(381, 274);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 3;
            this.Accept.Text = "button1";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Button1_Click);
            // 
            // goToRegistration
            // 
            this.goToRegistration.Location = new System.Drawing.Point(305, 397);
            this.goToRegistration.Name = "goToRegistration";
            this.goToRegistration.Size = new System.Drawing.Size(265, 23);
            this.goToRegistration.TabIndex = 4;
            this.goToRegistration.Text = "Don\'t have an account yet ?";
            this.goToRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goToRegistration.Visible = false;
            this.goToRegistration.Click += new System.EventHandler(this.GoToRegistration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goToRegistration);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.warning_alarm);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label warning_alarm;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label goToRegistration;
    }
}

