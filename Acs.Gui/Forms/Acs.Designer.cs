namespace Acs.Gui.Forms
{
    partial class Acs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acs));
            this.systemTrace = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hideBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NewAcsDumperBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NewAcsFinderBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemTrace
            // 
            this.systemTrace.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrace.Icon")));
            this.systemTrace.Visible = true;
            this.systemTrace.DoubleClick += new System.EventHandler(this.systemTrace_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideBtn,
            this.ExitBtn});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 36);
            this.toolStripMenuItem1.Text = "File";
            // 
            // hideBtn
            // 
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(99, 22);
            this.hideBtn.Text = "Hide";
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(99, 22);
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2vSeparator1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 404);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 321);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.NewAcsDumperBtn);
            this.panel4.Location = new System.Drawing.Point(3, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 37);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "AcsDumper";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewAcsDumperBtn
            // 
            this.NewAcsDumperBtn.Animated = true;
            this.NewAcsDumperBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewAcsDumperBtn.BackgroundImage")));
            this.NewAcsDumperBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NewAcsDumperBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NewAcsDumperBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NewAcsDumperBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NewAcsDumperBtn.FillColor = System.Drawing.Color.Transparent;
            this.NewAcsDumperBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewAcsDumperBtn.ForeColor = System.Drawing.Color.White;
            this.NewAcsDumperBtn.Location = new System.Drawing.Point(3, 3);
            this.NewAcsDumperBtn.Name = "NewAcsDumperBtn";
            this.NewAcsDumperBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NewAcsDumperBtn.Size = new System.Drawing.Size(28, 28);
            this.NewAcsDumperBtn.TabIndex = 2;
            this.NewAcsDumperBtn.Click += new System.EventHandler(this.NewAcsDumperBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.NewAcsFinderBtn);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 37);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "AcsFinder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewAcsFinderBtn
            // 
            this.NewAcsFinderBtn.Animated = true;
            this.NewAcsFinderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewAcsFinderBtn.BackgroundImage")));
            this.NewAcsFinderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NewAcsFinderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NewAcsFinderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NewAcsFinderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NewAcsFinderBtn.FillColor = System.Drawing.Color.Transparent;
            this.NewAcsFinderBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewAcsFinderBtn.ForeColor = System.Drawing.Color.White;
            this.NewAcsFinderBtn.Location = new System.Drawing.Point(3, 3);
            this.NewAcsFinderBtn.Name = "NewAcsFinderBtn";
            this.NewAcsFinderBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NewAcsFinderBtn.Size = new System.Drawing.Size(28, 28);
            this.NewAcsFinderBtn.TabIndex = 2;
            this.NewAcsFinderBtn.Click += new System.EventHandler(this.NewAcsFinderBtn_Click);
            // 
            // guna2vSeparator1
            // 
            this.guna2vSeparator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2vSeparator1.FillThickness = 3;
            this.guna2vSeparator1.Location = new System.Drawing.Point(15, 61);
            this.guna2vSeparator1.Name = "guna2vSeparator1";
            this.guna2vSeparator1.Size = new System.Drawing.Size(10, 321);
            this.guna2vSeparator1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 500, 0);
            this.label1.Size = new System.Drawing.Size(790, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here ypu can start both AcsFinder and AcsDumper new instances.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.menuStrip1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Acs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acs";
            this.Text = "Acs";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon systemTrace;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hideBtn;
        private ToolStripMenuItem ExitBtn;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton NewAcsDumperBtn;
        private Panel panel3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton NewAcsFinderBtn;
    }
}