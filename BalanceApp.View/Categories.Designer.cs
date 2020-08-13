namespace BalanceApp.View
{
    partial class Categories
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AddCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(92, 46);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(362, 359);
            this.treeView1.TabIndex = 0;
            // 
            // AddCategoryLabel
            // 
            this.AddCategoryLabel.AutoSize = true;
            this.AddCategoryLabel.Location = new System.Drawing.Point(527, 64);
            this.AddCategoryLabel.Name = "AddCategoryLabel";
            this.AddCategoryLabel.Size = new System.Drawing.Size(94, 17);
            this.AddCategoryLabel.TabIndex = 1;
            this.AddCategoryLabel.Text = "Add Category";
            this.AddCategoryLabel.Click += new System.EventHandler(this.AddCategoryLabel_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCategoryLabel);
            this.Controls.Add(this.treeView1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label AddCategoryLabel;
    }
}