namespace BalanceApp.View
{
    partial class App
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
            this.Incomes = new System.Windows.Forms.ListView();
            this.Expenses = new System.Windows.Forms.ListView();
            this.Stuff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Incomes
            // 
            this.Incomes.HideSelection = false;
            this.Incomes.Location = new System.Drawing.Point(65, 86);
            this.Incomes.Name = "Incomes";
            this.Incomes.Size = new System.Drawing.Size(427, 376);
            this.Incomes.TabIndex = 2;
            this.Incomes.UseCompatibleStateImageBehavior = false;
            this.Incomes.View = System.Windows.Forms.View.Details;
            // 
            // Expenses
            // 
            this.Expenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stuff,
            this.Cost});
            this.Expenses.GridLines = true;
            this.Expenses.HideSelection = false;
            this.Expenses.Location = new System.Drawing.Point(514, 86);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(427, 376);
            this.Expenses.TabIndex = 3;
            this.Expenses.UseCompatibleStateImageBehavior = false;
            this.Expenses.View = System.Windows.Forms.View.Details;
            // 
            // Stuff
            // 
            this.Stuff.Width = 303;
            // 
            // Cost
            // 
            this.Cost.Width = 120;
            // 
            // ExpAddButton
            // 
            this.ExpAddButton.Location = new System.Drawing.Point(514, 57);
            this.ExpAddButton.Name = "ExpAddButton";
            this.ExpAddButton.Size = new System.Drawing.Size(75, 23);
            this.ExpAddButton.TabIndex = 4;
            this.ExpAddButton.Text = "Add";
            this.ExpAddButton.UseVisualStyleBackColor = true;
            this.ExpAddButton.Click += new System.EventHandler(this.ExpAddButton_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 552);
            this.Controls.Add(this.ExpAddButton);
            this.Controls.Add(this.Expenses);
            this.Controls.Add(this.Incomes);
            this.Name = "App";
            this.Text = "App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_FormClosing);
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Incomes;
        private System.Windows.Forms.ListView Expenses;
        private System.Windows.Forms.ColumnHeader Stuff;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Button ExpAddButton;
    }
}