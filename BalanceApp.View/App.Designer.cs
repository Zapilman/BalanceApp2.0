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
            this.IncomesView = new System.Windows.Forms.ListView();
            this.ExpensesView = new System.Windows.Forms.ListView();
            this.Stuff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpAddButton = new System.Windows.Forms.Button();
            this.IncAddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // IncomesView
            // 
            this.IncomesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.IncomesView.GridLines = true;
            this.IncomesView.HideSelection = false;
            this.IncomesView.Location = new System.Drawing.Point(65, 86);
            this.IncomesView.Name = "IncomesView";
            this.IncomesView.Size = new System.Drawing.Size(427, 376);
            this.IncomesView.TabIndex = 2;
            this.IncomesView.UseCompatibleStateImageBehavior = false;
            this.IncomesView.View = System.Windows.Forms.View.Details;
            // 
            // ExpensesView
            // 
            this.ExpensesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stuff,
            this.Cost});
            this.ExpensesView.GridLines = true;
            this.ExpensesView.HideSelection = false;
            this.ExpensesView.Location = new System.Drawing.Point(514, 86);
            this.ExpensesView.Name = "ExpensesView";
            this.ExpensesView.Size = new System.Drawing.Size(427, 376);
            this.ExpensesView.TabIndex = 3;
            this.ExpensesView.UseCompatibleStateImageBehavior = false;
            this.ExpensesView.View = System.Windows.Forms.View.Details;
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
            // IncAddButton
            // 
            this.IncAddButton.Location = new System.Drawing.Point(65, 57);
            this.IncAddButton.Name = "IncAddButton";
            this.IncAddButton.Size = new System.Drawing.Size(75, 23);
            this.IncAddButton.TabIndex = 5;
            this.IncAddButton.Text = "Add";
            this.IncAddButton.UseVisualStyleBackColor = true;
            this.IncAddButton.Click += new System.EventHandler(this.IncAddButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stuff";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 100;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IncAddButton);
            this.Controls.Add(this.ExpAddButton);
            this.Controls.Add(this.ExpensesView);
            this.Controls.Add(this.IncomesView);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView IncomesView;
        private System.Windows.Forms.ListView ExpensesView;
        private System.Windows.Forms.ColumnHeader Stuff;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Button ExpAddButton;
        private System.Windows.Forms.Button IncAddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}