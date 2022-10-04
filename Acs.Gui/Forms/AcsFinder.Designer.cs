namespace Acs.Gui.Forms
{
    partial class AcsFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcsFinder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.stringToSearchForBox = new System.Windows.Forms.TextBox();
            this.SearchInFilesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2vSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.latestLog = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recentLogs = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenRecLogBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.occurrencesOption = new Guna.UI2.WinForms.Guna2RadioButton();
            this.differencesOption = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filesList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFilesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.guna2vSeparator2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2vSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 404);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.stringToSearchForBox);
            this.panel6.Controls.Add(this.SearchInFilesBtn);
            this.panel6.Location = new System.Drawing.Point(25, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 90);
            this.panel6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.label5.Size = new System.Drawing.Size(237, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select one or more files to continue.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stringToSearchForBox
            // 
            this.stringToSearchForBox.Location = new System.Drawing.Point(5, 47);
            this.stringToSearchForBox.Name = "stringToSearchForBox";
            this.stringToSearchForBox.PlaceholderText = "Digit a string to search for";
            this.stringToSearchForBox.Size = new System.Drawing.Size(183, 23);
            this.stringToSearchForBox.TabIndex = 4;
            // 
            // SearchInFilesBtn
            // 
            this.SearchInFilesBtn.Animated = true;
            this.SearchInFilesBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchInFilesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchInFilesBtn.BackgroundImage")));
            this.SearchInFilesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchInFilesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchInFilesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchInFilesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchInFilesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchInFilesBtn.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.SearchInFilesBtn.FillColor = System.Drawing.Color.Transparent;
            this.SearchInFilesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchInFilesBtn.ForeColor = System.Drawing.Color.White;
            this.SearchInFilesBtn.Location = new System.Drawing.Point(194, 35);
            this.SearchInFilesBtn.Name = "SearchInFilesBtn";
            this.SearchInFilesBtn.Size = new System.Drawing.Size(48, 48);
            this.SearchInFilesBtn.TabIndex = 1;
            this.SearchInFilesBtn.UseTransparentBackground = true;
            this.SearchInFilesBtn.Click += new System.EventHandler(this.SearchInFilesBtn_Click);
            // 
            // guna2vSeparator2
            // 
            this.guna2vSeparator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2vSeparator2.FillThickness = 3;
            this.guna2vSeparator2.Location = new System.Drawing.Point(340, 12);
            this.guna2vSeparator2.Name = "guna2vSeparator2";
            this.guna2vSeparator2.Size = new System.Drawing.Size(10, 179);
            this.guna2vSeparator2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.latestLog);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.recentLogs);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.OpenRecLogBtn);
            this.panel4.Location = new System.Drawing.Point(356, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 159);
            this.panel4.TabIndex = 5;
            // 
            // latestLog
            // 
            this.latestLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.latestLog.Location = new System.Drawing.Point(3, 125);
            this.latestLog.Name = "latestLog";
            this.latestLog.Size = new System.Drawing.Size(217, 19);
            this.latestLog.TabIndex = 6;
            this.latestLog.Click += new System.EventHandler(this.latestLog_Click);
            this.latestLog.MouseHover += new System.EventHandler(this.latestLog_MouseHover);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 96);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 130, 0);
            this.label6.Size = new System.Drawing.Size(217, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Latest log:";
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.occurrencesOption);
            this.panel3.Controls.Add(this.differencesOption);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SearchBtn);
            this.panel3.Location = new System.Drawing.Point(25, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 100);
            this.panel3.TabIndex = 4;
            // 
            // occurrencesOption
            // 
            this.occurrencesOption.Animated = true;
            this.occurrencesOption.AutoSize = true;
            this.occurrencesOption.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.occurrencesOption.CheckedState.BorderThickness = 0;
            this.occurrencesOption.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.occurrencesOption.CheckedState.InnerColor = System.Drawing.Color.White;
            this.occurrencesOption.CheckedState.InnerOffset = -4;
            this.occurrencesOption.Location = new System.Drawing.Point(17, 67);
            this.occurrencesOption.Name = "occurrencesOption";
            this.occurrencesOption.Size = new System.Drawing.Size(89, 19);
            this.occurrencesOption.TabIndex = 6;
            this.occurrencesOption.Text = "occurrences";
            this.occurrencesOption.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.occurrencesOption.UncheckedState.BorderThickness = 2;
            this.occurrencesOption.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.occurrencesOption.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // differencesOption
            // 
            this.differencesOption.Animated = true;
            this.differencesOption.AutoSize = true;
            this.differencesOption.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.differencesOption.CheckedState.BorderThickness = 0;
            this.differencesOption.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.differencesOption.CheckedState.InnerColor = System.Drawing.Color.White;
            this.differencesOption.CheckedState.InnerOffset = -4;
            this.differencesOption.Location = new System.Drawing.Point(17, 42);
            this.differencesOption.Name = "differencesOption";
            this.differencesOption.Size = new System.Drawing.Size(83, 19);
            this.differencesOption.TabIndex = 5;
            this.differencesOption.Text = "differences";
            this.differencesOption.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.differencesOption.UncheckedState.BorderThickness = 2;
            this.differencesOption.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.differencesOption.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Animated = true;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.SearchBtn.FillColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(3, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(28, 28);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.UseTransparentBackground = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.filesList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SelectFilesBtn);
            this.panel2.Location = new System.Drawing.Point(25, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 77);
            this.panel2.TabIndex = 2;
            // 
            // filesList
            // 
            this.filesList.BackColor = System.Drawing.Color.Transparent;
            this.filesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filesList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filesList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filesList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filesList.ItemHeight = 20;
            this.filesList.Location = new System.Drawing.Point(3, 37);
            this.filesList.MaxDropDownItems = 100;
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(217, 26);
            this.filesList.TabIndex = 3;
            this.toolTip.SetToolTip(this.filesList, "Select a file to remove it from the list.");
            this.filesList.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select file/s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectFilesBtn
            // 
            this.SelectFilesBtn.Animated = true;
            this.SelectFilesBtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectFilesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectFilesBtn.BackgroundImage")));
            this.SelectFilesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFilesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectFilesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectFilesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectFilesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectFilesBtn.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.SelectFilesBtn.FillColor = System.Drawing.Color.Transparent;
            this.SelectFilesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectFilesBtn.ForeColor = System.Drawing.Color.White;
            this.SelectFilesBtn.Location = new System.Drawing.Point(3, 3);
            this.SelectFilesBtn.Name = "SelectFilesBtn";
            this.SelectFilesBtn.Size = new System.Drawing.Size(28, 28);
            this.SelectFilesBtn.TabIndex = 1;
            this.SelectFilesBtn.UseTransparentBackground = true;
            this.SelectFilesBtn.Click += new System.EventHandler(this.SelectFilesBtn_Click);
            // 
            // guna2vSeparator1
            // 
            this.guna2vSeparator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2vSeparator1.FillThickness = 3;
            this.guna2vSeparator1.Location = new System.Drawing.Point(9, 12);
            this.guna2vSeparator1.Name = "guna2vSeparator1";
            this.guna2vSeparator1.Size = new System.Drawing.Size(10, 305);
            this.guna2vSeparator1.TabIndex = 0;
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
            this.toolTip.ReshowDelay = 100;
            // 
            // AcsFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AcsFinder";
            this.Text = "AcsFinder";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ExitBtn;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Guna.UI2.WinForms.Guna2Button SelectFilesBtn;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox filesList;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private ToolTip toolTip;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2RadioButton occurrencesOption;
        private Guna.UI2.WinForms.Guna2RadioButton differencesOption;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Panel panel4;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox recentLogs;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button OpenRecLogBtn;
        private Panel panel6;
        private Label label5;
        private TextBox stringToSearchForBox;
        private Guna.UI2.WinForms.Guna2Button SearchInFilesBtn;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator2;
        private Label latestLog;
        private Label label6;
    }
}