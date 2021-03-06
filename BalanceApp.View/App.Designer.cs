﻿namespace BalanceApp.View
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
            this.components = new System.ComponentModel.Container();
            this.IncomesView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpensesView = new System.Windows.Forms.ListView();
            this.Stuff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpAddButton = new System.Windows.Forms.Button();
            this.IncAddButton = new System.Windows.Forms.Button();
            this.ShowIncomes = new System.Windows.Forms.Label();
            this.ShowExpenses = new System.Windows.Forms.Label();
            this.ShowResult = new System.Windows.Forms.Label();
            this.IncClearButton = new System.Windows.Forms.Button();
            this.ExpClearButton = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncomesView
            // 
            this.IncomesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.category});
            this.IncomesView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomesView.FullRowSelect = true;
            this.IncomesView.GridLines = true;
            this.IncomesView.HideSelection = false;
            this.IncomesView.Location = new System.Drawing.Point(50, 86);
            this.IncomesView.Name = "IncomesView";
            this.IncomesView.ShowItemToolTips = true;
            this.IncomesView.Size = new System.Drawing.Size(502, 427);
            this.IncomesView.TabIndex = 2;
            this.toolTip1.SetToolTip(this.IncomesView, "kek");
            this.IncomesView.UseCompatibleStateImageBehavior = false;
            this.IncomesView.View = System.Windows.Forms.View.Details;
            this.IncomesView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.IncomesView_AfterLabelEdit);
            this.IncomesView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.IncomesView_ColumnClick);
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 100;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 150;
            // 
            // ExpensesView
            // 
            this.ExpensesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stuff,
            this.Cost,
            this.date,
            this.incCategory});
            this.ExpensesView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpensesView.FullRowSelect = true;
            this.ExpensesView.GridLines = true;
            this.ExpensesView.HideSelection = false;
            this.ExpensesView.Location = new System.Drawing.Point(621, 86);
            this.ExpensesView.Name = "ExpensesView";
            this.ExpensesView.ShowItemToolTips = true;
            this.ExpensesView.Size = new System.Drawing.Size(468, 427);
            this.ExpensesView.TabIndex = 3;
            this.ExpensesView.UseCompatibleStateImageBehavior = false;
            this.ExpensesView.View = System.Windows.Forms.View.Details;
            this.ExpensesView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ExpensesView_AfterLabelEdit);
            this.ExpensesView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ExpensesView_ColumnClick);
            // 
            // Stuff
            // 
            this.Stuff.Text = "Stuff";
            this.Stuff.Width = 100;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 120;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 100;
            // 
            // incCategory
            // 
            this.incCategory.Text = "Category";
            this.incCategory.Width = 100;
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
            // ShowIncomes
            // 
            this.ShowIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowIncomes.ForeColor = System.Drawing.Color.ForestGreen;
            this.ShowIncomes.Location = new System.Drawing.Point(53, 542);
            this.ShowIncomes.Name = "ShowIncomes";
            this.ShowIncomes.Size = new System.Drawing.Size(499, 62);
            this.ShowIncomes.TabIndex = 7;
            this.ShowIncomes.Text = "Incomes: ";
            // 
            // ShowExpenses
            // 
            this.ShowExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowExpenses.ForeColor = System.Drawing.Color.Red;
            this.ShowExpenses.Location = new System.Drawing.Point(621, 542);
            this.ShowExpenses.Name = "ShowExpenses";
            this.ShowExpenses.Size = new System.Drawing.Size(468, 62);
            this.ShowExpenses.TabIndex = 8;
            this.ShowExpenses.Text = "Expenses: ";
            // 
            // ShowResult
            // 
            this.ShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowResult.Location = new System.Drawing.Point(462, 641);
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.Size = new System.Drawing.Size(539, 39);
            this.ShowResult.TabIndex = 9;
            this.ShowResult.Text = "Total: ";
            // 
            // IncClearButton
            // 
            this.IncClearButton.Location = new System.Drawing.Point(462, 57);
            this.IncClearButton.Name = "IncClearButton";
            this.IncClearButton.Size = new System.Drawing.Size(90, 23);
            this.IncClearButton.TabIndex = 12;
            this.IncClearButton.Text = "Clear";
            this.IncClearButton.UseVisualStyleBackColor = true;
            // 
            // ExpClearButton
            // 
            this.ExpClearButton.Location = new System.Drawing.Point(999, 57);
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
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem1.Text = "Remove";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem3.Text = "Edit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.allToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.editToolStripMenuItem,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(133, 100);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem2.Text = "Remove";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem1,
            this.allToolStripMenuItem1});
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.copyToolStripMenuItem1.Text = "Copy";
            // 
            // nameToolStripMenuItem1
            // 
            this.nameToolStripMenuItem1.Name = "nameToolStripMenuItem1";
            this.nameToolStripMenuItem1.Size = new System.Drawing.Size(132, 26);
            this.nameToolStripMenuItem1.Text = "Name";
            this.nameToolStripMenuItem1.Click += new System.EventHandler(this.nameToolStripMenuItem1_Click);
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(132, 26);
            this.allToolStripMenuItem1.Text = "All";
            this.allToolStripMenuItem1.Click += new System.EventHandler(this.allToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 703);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.ExpClearButton);
            this.Controls.Add(this.IncClearButton);
            this.Controls.Add(this.ShowResult);
            this.Controls.Add(this.ShowExpenses);
            this.Controls.Add(this.ShowIncomes);
            this.Controls.Add(this.IncAddButton);
            this.Controls.Add(this.ExpAddButton);
            this.Controls.Add(this.ExpensesView);
            this.Controls.Add(this.IncomesView);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label ShowIncomes;
        private System.Windows.Forms.Label ShowExpenses;
        private System.Windows.Forms.Label ShowResult;
        private System.Windows.Forms.Button IncClearButton;
        private System.Windows.Forms.Button ExpClearButton;
        private System.Windows.Forms.Label Profile;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader incCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
    }
}