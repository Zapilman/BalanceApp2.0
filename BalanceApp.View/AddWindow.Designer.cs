namespace BalanceApp.View
{
    partial class AddWindow
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
            this.stuffBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // stuffBox
            // 
            this.stuffBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stuffBox.Location = new System.Drawing.Point(22, 30);
            this.stuffBox.Name = "stuffBox";
            this.stuffBox.Size = new System.Drawing.Size(325, 38);
            this.stuffBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countBox
            // 
            this.countBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBox.Location = new System.Drawing.Point(385, 30);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(261, 38);
            this.countBox.TabIndex = 2;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(266, 94);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(216, 24);
            this.categoryBox.TabIndex = 3;
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 158);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stuffBox);
            this.Name = "AddWindow";
            this.Text = "AddWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stuffBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}