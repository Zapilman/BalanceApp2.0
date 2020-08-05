namespace BalanceApp.View
{
    partial class MyAccount
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.changeNameLabel = new System.Windows.Forms.Label();
            this.ChangePassLabel = new System.Windows.Forms.Label();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.oldPassBox = new System.Windows.Forms.TextBox();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.succsesLabel = new System.Windows.Forms.Label();
            this.setLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(217, 81);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 23);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "label1";
            // 
            // changeNameLabel
            // 
            this.changeNameLabel.Location = new System.Drawing.Point(217, 181);
            this.changeNameLabel.Name = "changeNameLabel";
            this.changeNameLabel.Size = new System.Drawing.Size(163, 23);
            this.changeNameLabel.TabIndex = 2;
            this.changeNameLabel.Text = "Change UserName  >";
            this.changeNameLabel.Click += new System.EventHandler(this.changeNameLabel_Click);
            // 
            // ChangePassLabel
            // 
            this.ChangePassLabel.Location = new System.Drawing.Point(217, 295);
            this.ChangePassLabel.Name = "ChangePassLabel";
            this.ChangePassLabel.Size = new System.Drawing.Size(190, 23);
            this.ChangePassLabel.TabIndex = 3;
            this.ChangePassLabel.Text = "Change Password  >";
            this.ChangePassLabel.Click += new System.EventHandler(this.ChangePassLabel_Click);
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(220, 207);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(145, 22);
            this.newNameBox.TabIndex = 5;
            this.newNameBox.Text = "Old username...";
            this.newNameBox.Visible = false;
            this.newNameBox.TextChanged += new System.EventHandler(this.newNameBox_TextChanged);
            // 
            // oldPassBox
            // 
            this.oldPassBox.Location = new System.Drawing.Point(220, 321);
            this.oldPassBox.Name = "oldPassBox";
            this.oldPassBox.Size = new System.Drawing.Size(145, 22);
            this.oldPassBox.TabIndex = 6;
            this.oldPassBox.Text = "Old password...";
            this.oldPassBox.Visible = false;
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(220, 366);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(145, 22);
            this.newPassBox.TabIndex = 7;
            this.newPassBox.Text = "New password...";
            this.newPassBox.Visible = false;
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Enabled = false;
            this.ChangeNameButton.Location = new System.Drawing.Point(220, 247);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(145, 23);
            this.ChangeNameButton.TabIndex = 8;
            this.ChangeNameButton.Text = "Change username";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Visible = false;
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.Location = new System.Drawing.Point(220, 404);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(145, 23);
            this.ChangePassButton.TabIndex = 9;
            this.ChangePassButton.Text = "Change Password";
            this.ChangePassButton.UseVisualStyleBackColor = true;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(394, 326);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 17);
            this.warningLabel.TabIndex = 10;
            // 
            // succsesLabel
            // 
            this.succsesLabel.AutoSize = true;
            this.succsesLabel.Location = new System.Drawing.Point(371, 407);
            this.succsesLabel.Name = "succsesLabel";
            this.succsesLabel.Size = new System.Drawing.Size(0, 17);
            this.succsesLabel.TabIndex = 11;
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.Location = new System.Drawing.Point(501, 33);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(59, 17);
            this.setLabel.TabIndex = 12;
            this.setLabel.Text = "Settings";
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.setLabel);
            this.Controls.Add(this.succsesLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.ChangeNameButton);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.oldPassBox);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.ChangePassLabel);
            this.Controls.Add(this.changeNameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "MyAccount";
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label changeNameLabel;
        private System.Windows.Forms.Label ChangePassLabel;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.TextBox oldPassBox;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.Button ChangeNameButton;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label succsesLabel;
        private System.Windows.Forms.Label setLabel;
    }
}