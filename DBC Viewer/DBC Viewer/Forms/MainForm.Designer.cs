﻿namespace DBCViewer
{
    partial class MainForm
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
                components.Dispose();
            if (disposing && (m_catalog != null))
                m_catalog.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetColumnsFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difinitionEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new MyDataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.columnContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCellsExceptHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayedCellsExceptHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayedCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.columnContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.reloadDefinitionsToolStripMenuItem,
            this.runPluginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // reloadDefinitionsToolStripMenuItem
            // 
            this.reloadDefinitionsToolStripMenuItem.Name = "reloadDefinitionsToolStripMenuItem";
            this.reloadDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.reloadDefinitionsToolStripMenuItem.Text = "Reload Definitions";
            this.reloadDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.reloadDefinitionsToolStripMenuItem_Click);
            // 
            // runPluginToolStripMenuItem
            // 
            this.runPluginToolStripMenuItem.Name = "runPluginToolStripMenuItem";
            this.runPluginToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.runPluginToolStripMenuItem.Text = "Run plugin...";
            this.runPluginToolStripMenuItem.Click += new System.EventHandler(this.runPluginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.resetFilterToolStripMenuItem,
            this.columnsFilterToolStripMenuItem,
            this.resetColumnsFilterToolStripMenuItem,
            this.difinitionEditorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.filterToolStripMenuItem.Text = "Filter...";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // resetFilterToolStripMenuItem
            // 
            this.resetFilterToolStripMenuItem.Name = "resetFilterToolStripMenuItem";
            this.resetFilterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.resetFilterToolStripMenuItem.Text = "Reset Filter";
            this.resetFilterToolStripMenuItem.Click += new System.EventHandler(this.resetFilterToolStripMenuItem_Click);
            // 
            // columnsFilterToolStripMenuItem
            // 
            this.columnsFilterToolStripMenuItem.Name = "columnsFilterToolStripMenuItem";
            this.columnsFilterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.columnsFilterToolStripMenuItem.Text = "Columns Filter...";
            // 
            // resetColumnsFilterToolStripMenuItem
            // 
            this.resetColumnsFilterToolStripMenuItem.Name = "resetColumnsFilterToolStripMenuItem";
            this.resetColumnsFilterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.resetColumnsFilterToolStripMenuItem.Text = "Reset Columns Filter";
            this.resetColumnsFilterToolStripMenuItem.Click += new System.EventHandler(this.resetColumnsFilterToolStripMenuItem_Click);
            // 
            // difinitionEditorToolStripMenuItem
            // 
            this.difinitionEditorToolStripMenuItem.Name = "difinitionEditorToolStripMenuItem";
            this.difinitionEditorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.difinitionEditorToolStripMenuItem.Text = "Definition Editor";
            this.difinitionEditorToolStripMenuItem.Click += new System.EventHandler(this.difinitionEditorToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(691, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Ready.";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "WoW Client DB Files|*.dbc;*.db2;*.adb;*.wdb|All files|*.*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(691, 296);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridView1_CellToolTipTextNeeded);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Cell: 0x0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 377);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rows Displayed: 0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // columnContextMenuStrip
            // 
            this.columnContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.autoSizeModeToolStripMenuItem});
            this.columnContextMenuStrip.Name = "columnContextMenuStrip";
            this.columnContextMenuStrip.Size = new System.Drawing.Size(160, 48);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // autoSizeModeToolStripMenuItem
            // 
            this.autoSizeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notSetToolStripMenuItem,
            this.noneToolStripMenuItem,
            this.columnHeaderToolStripMenuItem,
            this.allCellsExceptHeaderToolStripMenuItem,
            this.allCellsToolStripMenuItem,
            this.displayedCellsExceptHeaderToolStripMenuItem,
            this.displayedCellsToolStripMenuItem,
            this.fillToolStripMenuItem});
            this.autoSizeModeToolStripMenuItem.Name = "autoSizeModeToolStripMenuItem";
            this.autoSizeModeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.autoSizeModeToolStripMenuItem.Text = "Auto Size Mode";
            // 
            // notSetToolStripMenuItem
            // 
            this.notSetToolStripMenuItem.CheckOnClick = true;
            this.notSetToolStripMenuItem.Name = "notSetToolStripMenuItem";
            this.notSetToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.notSetToolStripMenuItem.Tag = "NotSet";
            this.notSetToolStripMenuItem.Text = "Not Set";
            this.notSetToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.CheckOnClick = true;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.noneToolStripMenuItem.Tag = "None";
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // columnHeaderToolStripMenuItem
            // 
            this.columnHeaderToolStripMenuItem.CheckOnClick = true;
            this.columnHeaderToolStripMenuItem.Name = "columnHeaderToolStripMenuItem";
            this.columnHeaderToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.columnHeaderToolStripMenuItem.Tag = "ColumnHeader";
            this.columnHeaderToolStripMenuItem.Text = "Column Header";
            this.columnHeaderToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // allCellsExceptHeaderToolStripMenuItem
            // 
            this.allCellsExceptHeaderToolStripMenuItem.CheckOnClick = true;
            this.allCellsExceptHeaderToolStripMenuItem.Name = "allCellsExceptHeaderToolStripMenuItem";
            this.allCellsExceptHeaderToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.allCellsExceptHeaderToolStripMenuItem.Tag = "AllCellsExceptHeader";
            this.allCellsExceptHeaderToolStripMenuItem.Text = "All Cells Except Header";
            this.allCellsExceptHeaderToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // allCellsToolStripMenuItem
            // 
            this.allCellsToolStripMenuItem.CheckOnClick = true;
            this.allCellsToolStripMenuItem.Name = "allCellsToolStripMenuItem";
            this.allCellsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.allCellsToolStripMenuItem.Tag = "AllCells";
            this.allCellsToolStripMenuItem.Text = "All Cells";
            this.allCellsToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // displayedCellsExceptHeaderToolStripMenuItem
            // 
            this.displayedCellsExceptHeaderToolStripMenuItem.CheckOnClick = true;
            this.displayedCellsExceptHeaderToolStripMenuItem.Name = "displayedCellsExceptHeaderToolStripMenuItem";
            this.displayedCellsExceptHeaderToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.displayedCellsExceptHeaderToolStripMenuItem.Tag = "DisplayedCellsExceptHeader";
            this.displayedCellsExceptHeaderToolStripMenuItem.Text = "Displayed Cells Except Header";
            this.displayedCellsExceptHeaderToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // displayedCellsToolStripMenuItem
            // 
            this.displayedCellsToolStripMenuItem.CheckOnClick = true;
            this.displayedCellsToolStripMenuItem.Name = "displayedCellsToolStripMenuItem";
            this.displayedCellsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.displayedCellsToolStripMenuItem.Tag = "DisplayedCells";
            this.displayedCellsToolStripMenuItem.Text = "Displayed Cells";
            this.displayedCellsToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.CheckOnClick = true;
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.fillToolStripMenuItem.Tag = "Fill";
            this.fillToolStripMenuItem.Text = "Fill";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.autoSizeColumnsModeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DBC Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.columnContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MyDataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFilterToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem runPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetColumnsFilterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip columnContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSizeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCellsExceptHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayedCellsExceptHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayedCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difinitionEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadDefinitionsToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

