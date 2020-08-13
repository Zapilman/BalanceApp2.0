namespace BalanceApp.View
{
    partial class AddCategoryForm
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
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.IncomeCheck = new System.Windows.Forms.CheckBox();
            this.ExpenseCheck = new System.Windows.Forms.CheckBox();
            this.ParentList = new System.Windows.Forms.ComboBox();
            this.AddCategoryButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(190, 74);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(221, 22);
            this.CategoryNameBox.TabIndex = 0;
            this.CategoryNameBox.Text = "Category Name";
            // 
            // IncomeCheck
            // 
            this.IncomeCheck.AutoSize = true;
            this.IncomeCheck.Location = new System.Drawing.Point(190, 120);
            this.IncomeCheck.Name = "IncomeCheck";
            this.IncomeCheck.Size = new System.Drawing.Size(75, 21);
            this.IncomeCheck.TabIndex = 1;
            this.IncomeCheck.Text = "Income";
            this.IncomeCheck.UseVisualStyleBackColor = true;
            this.IncomeCheck.CheckedChanged += new System.EventHandler(this.IncomeCheck_CheckedChanged_1);
            // 
            // ExpenseCheck
            // 
            this.ExpenseCheck.AutoSize = true;
            this.ExpenseCheck.Location = new System.Drawing.Point(313, 120);
            this.ExpenseCheck.Name = "ExpenseCheck";
            this.ExpenseCheck.Size = new System.Drawing.Size(84, 21);
            this.ExpenseCheck.TabIndex = 2;
            this.ExpenseCheck.Text = "Expense";
            this.ExpenseCheck.UseVisualStyleBackColor = true;
            this.ExpenseCheck.CheckedChanged += new System.EventHandler(this.ExpenseCheck_CheckedChanged);
            // 
            // ParentList
            // 
            this.ParentList.FormattingEnabled = true;
            this.ParentList.Location = new System.Drawing.Point(190, 168);
            this.ParentList.Name = "ParentList";
            this.ParentList.Size = new System.Drawing.Size(221, 24);
            this.ParentList.TabIndex = 3;
            this.ParentList.Text = "Parent Category";
            this.ParentList.Click += new System.EventHandler(this.ParentList_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.AutoSize = true;
            this.AddCategoryButton.Location = new System.Drawing.Point(190, 227);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(94, 17);
            this.AddCategoryButton.TabIndex = 4;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click_1);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.ParentList);
            this.Controls.Add(this.ExpenseCheck);
            this.Controls.Add(this.IncomeCheck);
            this.Controls.Add(this.CategoryNameBox);
            this.Name = "AddCategoryForm";
            this.Text = "AddCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.CheckBox IncomeCheck;
        private System.Windows.Forms.CheckBox ExpenseCheck;
        private System.Windows.Forms.ComboBox ParentList;
        private System.Windows.Forms.Label AddCategoryButton;
    }
}