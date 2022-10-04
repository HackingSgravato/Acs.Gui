namespace Acs.Gui.Forms
{
    partial class AcsDumper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcsDumper));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.processList = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lastRecentLogs = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recentLogs = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenRecLogBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.DumpSelectedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpAvailableBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshProcessesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitBtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(93, 22);
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 460);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.processList, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 224);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here, the list of running processes.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processList
            // 
            this.processList.AllowUserToAddRows = false;
            this.processList.AllowUserToOrderColumns = true;
            this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ProcessId,
            this.ProcessSize});
            this.processList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processList.Location = new System.Drawing.Point(3, 43);
            this.processList.Name = "processList";
            this.processList.ReadOnly = true;
            this.processList.RowTemplate.Height = 25;
            this.processList.Size = new System.Drawing.Size(782, 178);
            this.processList.TabIndex = 1;
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Width = 500;
            // 
            // ProcessId
            // 
            this.ProcessId.HeaderText = "Id";
            this.ProcessId.Name = "ProcessId";
            this.ProcessId.ReadOnly = true;
            // 
            // ProcessSize
            // 
            this.ProcessSize.HeaderText = "Size (MB)";
            this.ProcessSize.Name = "ProcessSize";
            this.ProcessSize.ReadOnly = true;
            this.ProcessSize.Width = 138;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 233);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(788, 224);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.guna2vSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 178);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lastRecentLogs);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.recentLogs);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.OpenRecLogBtn);
            this.panel4.Location = new System.Drawing.Point(29, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 159);
            this.panel4.TabIndex = 6;
            // 
            // lastRecentLogs
            // 
            this.lastRecentLogs.BackColor = System.Drawing.Color.Transparent;
            this.lastRecentLogs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lastRecentLogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lastRecentLogs.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastRecentLogs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastRecentLogs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastRecentLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.lastRecentLogs.ItemHeight = 20;
            this.lastRecentLogs.Location = new System.Drawing.Point(3, 128);
            this.lastRecentLogs.MaxDropDownItems = 100;
            this.lastRecentLogs.Name = "lastRecentLogs";
            this.lastRecentLogs.Size = new System.Drawing.Size(217, 26);
            this.lastRecentLogs.TabIndex = 6;
            this.toolTip.SetToolTip(this.lastRecentLogs, "Select log to open.");
            this.lastRecentLogs.SelectedIndexChanged += new System.EventHandler(this.lastRecentLogs_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 96);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 130, 0);
            this.label6.Size = new System.Drawing.Size(231, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Latest scan logs:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 40, 0);
            this.label4.Size = new System.Drawing.Size(217, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select a recent log to open";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recentLogs
            // 
            this.recentLogs.BackColor = System.Drawing.Color.Transparent;
            this.recentLogs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recentLogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recentLogs.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recentLogs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recentLogs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.recentLogs.ItemHeight = 20;
            this.recentLogs.Location = new System.Drawing.Point(3, 67);
            this.recentLogs.MaxDropDownItems = 100;
            this.recentLogs.Name = "recentLogs";
            this.recentLogs.Size = new System.Drawing.Size(217, 26);
            this.recentLogs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Open log";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenRecLogBtn
            // 
            this.OpenRecLogBtn.Animated = true;
            this.OpenRecLogBtn.BackColor = System.Drawing.Color.Transparent;
            this.OpenRecLogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenRecLogBtn.BackgroundImage")));
            this.OpenRecLogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenRecLogBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenRecLogBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenRecLogBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenRecLogBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenRecLogBtn.FillColor = System.Drawing.Color.Transparent;
            this.OpenRecLogBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenRecLogBtn.ForeColor = System.Drawing.Color.White;
            this.OpenRecLogBtn.Location = new System.Drawing.Point(3, 3);
            this.OpenRecLogBtn.Name = "OpenRecLogBtn";
            this.OpenRecLogBtn.Size = new System.Drawing.Size(28, 28);
            this.OpenRecLogBtn.TabIndex = 1;
            this.OpenRecLogBtn.UseTransparentBackground = true;
            this.OpenRecLogBtn.Click += new System.EventHandler(this.OpenRecLogBtn_Click);
            // 
            // guna2vSeparator1
            // 
            this.guna2vSeparator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2vSeparator1.FillThickness = 3;
            this.guna2vSeparator1.Location = new System.Drawing.Point(13, 9);
            this.guna2vSeparator1.Name = "guna2vSeparator1";
            this.guna2vSeparator1.Size = new System.Drawing.Size(10, 166);
            this.guna2vSeparator1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.menuStrip2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(782, 34);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(629, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Protected processes will result empty dump files.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DumpSelectedBtn,
            this.DumpAvailableBtn,
            this.RefreshProcessesBtn});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(625, 34);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // DumpSelectedBtn
            // 
            this.DumpSelectedBtn.Name = "DumpSelectedBtn";
            this.DumpSelectedBtn.Size = new System.Drawing.Size(98, 30);
            this.DumpSelectedBtn.Text = "Dump selected";
            this.DumpSelectedBtn.Click += new System.EventHandler(this.DumpSelectedBtn_Click);
            // 
            // DumpAvailableBtn
            // 
            this.DumpAvailableBtn.Name = "DumpAvailableBtn";
            this.DumpAvailableBtn.Size = new System.Drawing.Size(155, 30);
            this.DumpAvailableBtn.Text = "Dump available processes";
            this.DumpAvailableBtn.Click += new System.EventHandler(this.DumpAvailableBtn_Click);
            // 
            // RefreshProcessesBtn
            // 
            this.RefreshProcessesBtn.Margin = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.RefreshProcessesBtn.Name = "RefreshProcessesBtn";
            this.RefreshProcessesBtn.Size = new System.Drawing.Size(58, 30);
            this.RefreshProcessesBtn.Text = "Refresh";
            this.RefreshProcessesBtn.Click += new System.EventHandler(this.RefreshProcessesBtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.menuStrip1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 1500;
            this.toolTip.InitialDelay = 50;
            this.toolTip.ReshowDelay = 200;
            // 
            // AcsDumper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AcsDumper";
            this.Text = "AcsDumper";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ExitBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Panel panel4;
        private Label label6;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox recentLogs;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button OpenRecLogBtn;
        private ToolTip toolTip;
        private TableLayoutPanel tableLayoutPanel5;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem DumpSelectedBtn;
        private ToolStripMenuItem DumpAvailableBtn;
        private Label label5;
        private ToolStripMenuItem RefreshProcessesBtn;
        private DataGridView processList;
        private DataGridViewTextBoxColumn ProcessName;
        private DataGridViewTextBoxColumn ProcessId;
        private DataGridViewTextBoxColumn ProcessSize;
        private Guna.UI2.WinForms.Guna2ComboBox lastRecentLogs;
    }
}