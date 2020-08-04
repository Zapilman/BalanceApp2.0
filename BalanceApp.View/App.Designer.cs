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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpensesView = new System.Windows.Forms.ListView();
            this.Stuff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpAddButton = new System.Windows.Forms.Button();
            this.IncAddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowIncomes = new System.Windows.Forms.Label();
            this.ShowExpenses = new System.Windows.Forms.Label();
            this.ShowResult = new System.Windows.Forms.Label();
            this.IncRemButton = new System.Windows.Forms.Button();
            this.ExpRemButton = new System.Windows.Forms.Button();
            this.IncClearButton = new System.Windows.Forms.Button();
            this.ExpClearButton = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IncomesView
            // 
            this.IncomesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.IncomesView.GridLines = true;
            this.IncomesView.HideSelection = false;
            this.IncomesView.Location = new System.Drawing.Point(50, 86);
            this.IncomesView.Name = "IncomesView";
            this.IncomesView.Size = new System.Drawing.Size(502, 427);
            this.IncomesView.TabIndex = 2;
            this.IncomesView.UseCompatibleStateImageBehavior = false;
            this.IncomesView.View = System.Windows.Forms.View.Details;
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
            // ExpensesView
            // 
            this.ExpensesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stuff,
            this.Cost});
            this.ExpensesView.GridLines = true;
            this.ExpensesView.HideSelection = false;
            this.ExpensesView.Location = new System.Drawing.Point(621, 86);
            this.ExpensesView.Name = "ExpensesView";
            this.ExpensesView.Size = new System.Drawing.Size(468, 427);
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
            this.ExpAddButton.Location = new System.Drawing.Point(621, 57);
            this.ExpAddButton.Name = "ExpAddButton";
            this.ExpAddButton.Size = new System.Drawing.Size(75, 23);
            this.ExpAddButton.TabIndex = 4;
            this.ExpAddButton.Text = "Add";
            this.ExpAddButton.UseVisualStyleBackColor = true;
            // 
            // IncAddButton
            // 
            this.IncAddButton.Location = new System.Drawing.Point(50, 57);
            this.IncAddButton.Name = "IncAddButton";
            this.IncAddButton.Size = new System.Drawing.Size(75, 23);
            this.IncAddButton.TabIndex = 5;
            this.IncAddButton.Text = "Add";
            this.IncAddButton.UseVisualStyleBackColor = true;
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
            // ShowIncomes
            // 
            this.ShowIncomes.AutoSize = true;
            this.ShowIncomes.Location = new System.Drawing.Point(125, 542);
            this.ShowIncomes.Name = "ShowIncomes";
            this.ShowIncomes.Size = new System.Drawing.Size(68, 17);
            this.ShowIncomes.TabIndex = 7;
            this.ShowIncomes.Text = "Incomes: ";
            // 
            // ShowExpenses
            // 
            this.ShowExpenses.AutoSize = true;
            this.ShowExpenses.Location = new System.Drawing.Point(661, 542);
            this.ShowExpenses.Name = "ShowExpenses";
            this.ShowExpenses.Size = new System.Drawing.Size(77, 17);
            this.ShowExpenses.TabIndex = 8;
            this.ShowExpenses.Text = "Expenses: ";
            // 
            // ShowResult
            // 
            this.ShowResult.AutoSize = true;
            this.ShowResult.Location = new System.Drawing.Point(525, 641);
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.Size = new System.Drawing.Size(56, 17);
            this.ShowResult.TabIndex = 9;
            this.ShowResult.Text = "Result: ";
            // 
            // IncRemButton
            // 
            this.IncRemButton.Location = new System.Drawing.Point(147, 57);
            this.IncRemButton.Name = "IncRemButton";
            this.IncRemButton.Size = new System.Drawing.Size(90, 23);
            this.IncRemButton.TabIndex = 10;
            this.IncRemButton.Text = "Delete";
            this.IncRemButton.UseVisualStyleBackColor = true;
            // 
            // ExpRemButton
            // 
            this.ExpRemButton.Location = new System.Drawing.Point(723, 57);
            this.ExpRemButton.Name = "ExpRemButton";
            this.ExpRemButton.Size = new System.Drawing.Size(75, 23);
            this.ExpRemButton.TabIndex = 11;
            this.ExpRemButton.Text = "Delete";
            this.ExpRemButton.UseVisualStyleBackColor = true;
            // 
            // IncClearButton
            // 
            this.IncClearButton.Location = new System.Drawing.Point(260, 57);
            this.IncClearButton.Name = "IncClearButton";
            this.IncClearButton.Size = new System.Drawing.Size(90, 23);
            this.IncClearButton.TabIndex = 12;
            this.IncClearButton.Text = "Clear";
            this.IncClearButton.UseVisualStyleBackColor = true;
            // 
            // ExpClearButton
            // 
            this.ExpClearButton.Location = new System.Drawing.Point(820, 57);
            this.ExpClearButton.Name = "ExpClearButton";
            this.ExpClearButton.Size = new System.Drawing.Size(90, 23);
            this.ExpClearButton.TabIndex = 13;
            this.ExpClearButton.Text = "Clear";
            this.ExpClearButton.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Location = new System.Drawing.Point(50, 13);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(48, 17);
            this.Profile.TabIndex = 14;
            this.Profile.Text = "Profile";
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 703);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.ExpClearButton);
            this.Controls.Add(this.IncClearButton);
            this.Controls.Add(this.ExpRemButton);
            this.Controls.Add(this.IncRemButton);
            this.Controls.Add(this.ShowResult);
            this.Controls.Add(this.ShowExpenses);
            this.Controls.Add(this.ShowIncomes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IncAddButton);
            this.Controls.Add(this.ExpAddButton);
            this.Controls.Add(this.ExpensesView);
            this.Controls.Add(this.IncomesView);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label ShowIncomes;
        private System.Windows.Forms.Label ShowExpenses;
        private System.Windows.Forms.Label ShowResult;
        private System.Windows.Forms.Button IncRemButton;
        private System.Windows.Forms.Button ExpRemButton;
        private System.Windows.Forms.Button IncClearButton;
        private System.Windows.Forms.Button ExpClearButton;
        private System.Windows.Forms.Label Profile;
    }
}