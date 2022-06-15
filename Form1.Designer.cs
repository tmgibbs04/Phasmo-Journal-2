namespace Phasmo_Journal_2
{
    partial class Form1
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
            this.bDots = new System.Windows.Forms.CheckBox();
            this.bWriting = new System.Windows.Forms.CheckBox();
            this.bEMF = new System.Windows.Forms.CheckBox();
            this.bOrbs = new System.Windows.Forms.CheckBox();
            this.bPrints = new System.Windows.Forms.CheckBox();
            this.bTemps = new System.Windows.Forms.CheckBox();
            this.bSpiritBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xSpiritBox = new System.Windows.Forms.CheckBox();
            this.xTemps = new System.Windows.Forms.CheckBox();
            this.xPrints = new System.Windows.Forms.CheckBox();
            this.xOrbs = new System.Windows.Forms.CheckBox();
            this.xEMF = new System.Windows.Forms.CheckBox();
            this.xWriting = new System.Windows.Forms.CheckBox();
            this.xDots = new System.Windows.Forms.CheckBox();
            this.outputListView = new System.Windows.Forms.ListView();
            this.Ghost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ev1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ev2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ev3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ev4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDots
            // 
            this.bDots.Appearance = System.Windows.Forms.Appearance.Button;
            this.bDots.BackColor = System.Drawing.Color.DimGray;
            this.bDots.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bDots.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.bDots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDots.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDots.ForeColor = System.Drawing.SystemColors.Control;
            this.bDots.Location = new System.Drawing.Point(12, 40);
            this.bDots.Name = "bDots";
            this.bDots.Padding = new System.Windows.Forms.Padding(10);
            this.bDots.Size = new System.Drawing.Size(274, 68);
            this.bDots.TabIndex = 0;
            this.bDots.Text = "D.O.T.S Projector";
            this.bDots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bDots.UseVisualStyleBackColor = false;
            this.bDots.CheckedChanged += new System.EventHandler(this.BDots_CheckedChanged);
            // 
            // bWriting
            // 
            this.bWriting.Appearance = System.Windows.Forms.Appearance.Button;
            this.bWriting.BackColor = System.Drawing.Color.DimGray;
            this.bWriting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bWriting.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.bWriting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bWriting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bWriting.ForeColor = System.Drawing.SystemColors.Control;
            this.bWriting.Location = new System.Drawing.Point(12, 114);
            this.bWriting.Name = "bWriting";
            this.bWriting.Padding = new System.Windows.Forms.Padding(10);
            this.bWriting.Size = new System.Drawing.Size(274, 68);
            this.bWriting.TabIndex = 2;
            this.bWriting.Text = "Ghost Writing";
            this.bWriting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bWriting.UseVisualStyleBackColor = false;
            this.bWriting.CheckedChanged += new System.EventHandler(this.BWriting_CheckedChanged);
            // 
            // bEMF
            // 
            this.bEMF.Appearance = System.Windows.Forms.Appearance.Button;
            this.bEMF.BackColor = System.Drawing.Color.DimGray;
            this.bEMF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEMF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.bEMF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEMF.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEMF.ForeColor = System.Drawing.SystemColors.Control;
            this.bEMF.Location = new System.Drawing.Point(12, 188);
            this.bEMF.Name = "bEMF";
            this.bEMF.Padding = new System.Windows.Forms.Padding(10);
            this.bEMF.Size = new System.Drawing.Size(274, 68);
            this.bEMF.TabIndex = 4;
            this.bEMF.Text = "EMF Level 5";
            this.bEMF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bEMF.UseVisualStyleBackColor = false;
            this.bEMF.CheckedChanged += new System.EventHandler(this.BEMF_CheckedChanged);
            // 
            // bOrbs
            // 
            this.bOrbs.Appearance = System.Windows.Forms.Appearance.Button;
            this.bOrbs.BackColor = System.Drawing.Color.DimGray;
            this.bOrbs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bOrbs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.bOrbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrbs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrbs.ForeColor = System.Drawing.SystemColors.Control;
            this.bOrbs.Location = new System.Drawing.Point(12, 262);
            this.bOrbs.Name = "bOrbs";
            this.bOrbs.Padding = new System.Windows.Forms.Padding(10);
            this.bOrbs.Size = new System.Drawing.Size(274, 68);
            this.bOrbs.TabIndex = 6;
            this.bOrbs.Text = "Ghost Orb";
            this.bOrbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bOrbs.UseVisualStyleBackColor = false;
            this.bOrbs.CheckedChanged += new System.EventHandler(this.BOrbs_CheckedChanged);
            // 
            // bPrints
            // 
            this.bPrints.Appearance = System.Windows.Forms.Appearance.Button;
            this.bPrints.BackColor = System.Drawing.Color.DimGray;
            this.bPrints.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bPrints.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.bPrints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrints.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrints.ForeColor = System.Drawing.SystemColors.Control;
            this.bPrints.Location = new System.Drawing.Point(12, 336);
            this.bPrints.Name = "bPrints";
            this.bPrints.Padding = new System.Windows.Forms.Padding(10);
            this.bPrints.Size = new System.Drawing.Size(274, 68);
            this.bPrints.TabIndex = 8;
            this.bPrints.Text = "Fingerprints";
            this.bPrints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bPrints.UseVisualStyleBackColor = false;
            this.bPrints.CheckedChanged += new System.EventHandler(this.BPrints_CheckedChanged);
            // 
            // bTemps
            // 
            this.bTemps.Appearance = System.Windows.Forms.Appearance.Button;
            this.bTemps.BackColor = System.Drawing.Color.DimGray;
            this.bTemps.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bTemps.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.bTemps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTemps.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemps.ForeColor = System.Drawing.SystemColors.Control;
            this.bTemps.Location = new System.Drawing.Point(12, 410);
            this.bTemps.Name = "bTemps";
            this.bTemps.Padding = new System.Windows.Forms.Padding(10);
            this.bTemps.Size = new System.Drawing.Size(274, 68);
            this.bTemps.TabIndex = 10;
            this.bTemps.Text = "Freezing Temps";
            this.bTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bTemps.UseVisualStyleBackColor = false;
            this.bTemps.CheckedChanged += new System.EventHandler(this.BTemps_CheckedChanged);
            // 
            // bSpiritBox
            // 
            this.bSpiritBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.bSpiritBox.BackColor = System.Drawing.Color.DimGray;
            this.bSpiritBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bSpiritBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.bSpiritBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSpiritBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpiritBox.ForeColor = System.Drawing.SystemColors.Control;
            this.bSpiritBox.Location = new System.Drawing.Point(12, 484);
            this.bSpiritBox.Name = "bSpiritBox";
            this.bSpiritBox.Padding = new System.Windows.Forms.Padding(10);
            this.bSpiritBox.Size = new System.Drawing.Size(274, 68);
            this.bSpiritBox.TabIndex = 12;
            this.bSpiritBox.Text = "Spirit Box";
            this.bSpiritBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bSpiritBox.UseVisualStyleBackColor = false;
            this.bSpiritBox.CheckedChanged += new System.EventHandler(this.BSpiritBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(12, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 68);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reset Evidence";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xSpiritBox
            // 
            this.xSpiritBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.xSpiritBox.BackColor = System.Drawing.Color.DimGray;
            this.xSpiritBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xSpiritBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.xSpiritBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xSpiritBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xSpiritBox.ForeColor = System.Drawing.SystemColors.Control;
            this.xSpiritBox.Location = new System.Drawing.Point(292, 484);
            this.xSpiritBox.Name = "xSpiritBox";
            this.xSpiritBox.Padding = new System.Windows.Forms.Padding(10);
            this.xSpiritBox.Size = new System.Drawing.Size(68, 68);
            this.xSpiritBox.TabIndex = 13;
            this.xSpiritBox.Text = "X";
            this.xSpiritBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xSpiritBox.UseVisualStyleBackColor = false;
            this.xSpiritBox.CheckedChanged += new System.EventHandler(this.XSpiritBox_CheckedChanged);
            // 
            // xTemps
            // 
            this.xTemps.Appearance = System.Windows.Forms.Appearance.Button;
            this.xTemps.BackColor = System.Drawing.Color.DimGray;
            this.xTemps.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xTemps.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.xTemps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xTemps.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xTemps.ForeColor = System.Drawing.SystemColors.Control;
            this.xTemps.Location = new System.Drawing.Point(292, 410);
            this.xTemps.Name = "xTemps";
            this.xTemps.Padding = new System.Windows.Forms.Padding(10);
            this.xTemps.Size = new System.Drawing.Size(68, 68);
            this.xTemps.TabIndex = 11;
            this.xTemps.Text = "X";
            this.xTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xTemps.UseVisualStyleBackColor = false;
            this.xTemps.CheckedChanged += new System.EventHandler(this.XTemps_CheckedChanged);
            // 
            // xPrints
            // 
            this.xPrints.Appearance = System.Windows.Forms.Appearance.Button;
            this.xPrints.BackColor = System.Drawing.Color.DimGray;
            this.xPrints.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xPrints.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.xPrints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xPrints.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPrints.ForeColor = System.Drawing.SystemColors.Control;
            this.xPrints.Location = new System.Drawing.Point(292, 336);
            this.xPrints.Name = "xPrints";
            this.xPrints.Padding = new System.Windows.Forms.Padding(10);
            this.xPrints.Size = new System.Drawing.Size(68, 68);
            this.xPrints.TabIndex = 9;
            this.xPrints.Text = "X";
            this.xPrints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xPrints.UseVisualStyleBackColor = false;
            this.xPrints.CheckedChanged += new System.EventHandler(this.XPrints_CheckedChanged);
            // 
            // xOrbs
            // 
            this.xOrbs.Appearance = System.Windows.Forms.Appearance.Button;
            this.xOrbs.BackColor = System.Drawing.Color.DimGray;
            this.xOrbs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xOrbs.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.xOrbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xOrbs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xOrbs.ForeColor = System.Drawing.SystemColors.Control;
            this.xOrbs.Location = new System.Drawing.Point(292, 262);
            this.xOrbs.Name = "xOrbs";
            this.xOrbs.Padding = new System.Windows.Forms.Padding(10);
            this.xOrbs.Size = new System.Drawing.Size(68, 68);
            this.xOrbs.TabIndex = 7;
            this.xOrbs.Text = "X";
            this.xOrbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xOrbs.UseVisualStyleBackColor = false;
            this.xOrbs.CheckedChanged += new System.EventHandler(this.XOrbs_CheckedChanged);
            // 
            // xEMF
            // 
            this.xEMF.Appearance = System.Windows.Forms.Appearance.Button;
            this.xEMF.BackColor = System.Drawing.Color.DimGray;
            this.xEMF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xEMF.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.xEMF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xEMF.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xEMF.ForeColor = System.Drawing.SystemColors.Control;
            this.xEMF.Location = new System.Drawing.Point(292, 188);
            this.xEMF.Name = "xEMF";
            this.xEMF.Padding = new System.Windows.Forms.Padding(10);
            this.xEMF.Size = new System.Drawing.Size(68, 68);
            this.xEMF.TabIndex = 5;
            this.xEMF.Text = "X";
            this.xEMF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xEMF.UseVisualStyleBackColor = false;
            this.xEMF.CheckedChanged += new System.EventHandler(this.XEMF_CheckedChanged);
            // 
            // xWriting
            // 
            this.xWriting.Appearance = System.Windows.Forms.Appearance.Button;
            this.xWriting.BackColor = System.Drawing.Color.DimGray;
            this.xWriting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xWriting.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.xWriting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xWriting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWriting.ForeColor = System.Drawing.SystemColors.Control;
            this.xWriting.Location = new System.Drawing.Point(292, 114);
            this.xWriting.Name = "xWriting";
            this.xWriting.Padding = new System.Windows.Forms.Padding(10);
            this.xWriting.Size = new System.Drawing.Size(68, 68);
            this.xWriting.TabIndex = 3;
            this.xWriting.Text = "X";
            this.xWriting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xWriting.UseVisualStyleBackColor = false;
            this.xWriting.CheckedChanged += new System.EventHandler(this.XWriting_CheckedChanged);
            // 
            // xDots
            // 
            this.xDots.Appearance = System.Windows.Forms.Appearance.Button;
            this.xDots.BackColor = System.Drawing.Color.DimGray;
            this.xDots.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xDots.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.xDots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xDots.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xDots.ForeColor = System.Drawing.SystemColors.Control;
            this.xDots.Location = new System.Drawing.Point(292, 40);
            this.xDots.Name = "xDots";
            this.xDots.Padding = new System.Windows.Forms.Padding(10);
            this.xDots.Size = new System.Drawing.Size(68, 68);
            this.xDots.TabIndex = 1;
            this.xDots.Text = "X";
            this.xDots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xDots.UseVisualStyleBackColor = false;
            this.xDots.CheckedChanged += new System.EventHandler(this.XDots_CheckedChanged);
            // 
            // outputListView
            // 
            this.outputListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ghost,
            this.Ev1,
            this.Ev2,
            this.Ev3,
            this.Ev4});
            this.outputListView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputListView.FullRowSelect = true;
            this.outputListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.outputListView.HideSelection = false;
            this.outputListView.Location = new System.Drawing.Point(366, 40);
            this.outputListView.MultiSelect = false;
            this.outputListView.Name = "outputListView";
            this.outputListView.Size = new System.Drawing.Size(750, 586);
            this.outputListView.TabIndex = 16;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.Details;
            // 
            // Ghost
            // 
            this.Ghost.Text = "Ghost";
            this.Ghost.Width = 150;
            // 
            // Ev1
            // 
            this.Ev1.Text = "Evidence";
            this.Ev1.Width = 150;
            // 
            // Ev2
            // 
            this.Ev2.Text = "Evidence";
            this.Ev2.Width = 150;
            // 
            // Ev3
            // 
            this.Ev3.Text = "Evidence";
            this.Ev3.Width = 150;
            // 
            // Ev4
            // 
            this.Ev4.Text = "Evidence";
            this.Ev4.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.infoToolStripMenuItem.Text = "Help";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1129, 636);
            this.Controls.Add(this.outputListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xSpiritBox);
            this.Controls.Add(this.bSpiritBox);
            this.Controls.Add(this.xTemps);
            this.Controls.Add(this.bTemps);
            this.Controls.Add(this.xPrints);
            this.Controls.Add(this.bPrints);
            this.Controls.Add(this.xOrbs);
            this.Controls.Add(this.bOrbs);
            this.Controls.Add(this.xEMF);
            this.Controls.Add(this.bEMF);
            this.Controls.Add(this.xWriting);
            this.Controls.Add(this.bWriting);
            this.Controls.Add(this.xDots);
            this.Controls.Add(this.bDots);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Phasmo Journal 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bDots;
        private System.Windows.Forms.CheckBox bWriting;
        private System.Windows.Forms.CheckBox bEMF;
        private System.Windows.Forms.CheckBox bOrbs;
        private System.Windows.Forms.CheckBox bPrints;
        private System.Windows.Forms.CheckBox bTemps;
        private System.Windows.Forms.CheckBox bSpiritBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox xSpiritBox;
        private System.Windows.Forms.CheckBox xTemps;
        private System.Windows.Forms.CheckBox xPrints;
        private System.Windows.Forms.CheckBox xOrbs;
        private System.Windows.Forms.CheckBox xEMF;
        private System.Windows.Forms.CheckBox xWriting;
        private System.Windows.Forms.CheckBox xDots;
        private System.Windows.Forms.ListView outputListView;
        private System.Windows.Forms.ColumnHeader Ghost;
        private System.Windows.Forms.ColumnHeader Ev1;
        private System.Windows.Forms.ColumnHeader Ev2;
        private System.Windows.Forms.ColumnHeader Ev3;
        private System.Windows.Forms.ColumnHeader Ev4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
    }
}

