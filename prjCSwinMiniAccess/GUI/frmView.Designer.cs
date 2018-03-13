namespace prjCSwinMiniAccess.GUI
{
    partial class frmView
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
            this.lblDatabase = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lbxFieldTbl = new System.Windows.Forms.ListBox();
            this.lbxIndTbl = new System.Windows.Forms.ListBox();
            this.lbxTables = new System.Windows.Forms.ListBox();
            this.lbxFieldInd = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwRel = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbxRel = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tleExit = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatabase.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatabase.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDatabase.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDatabase.Location = new System.Drawing.Point(134, 46);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(17, 25);
            this.lblDatabase.TabIndex = 58;
            this.lblDatabase.Text = ".";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDatabase.UseCustomBackColor = true;
            this.lblDatabase.UseCustomForeColor = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lbxFieldTbl
            // 
            this.lbxFieldTbl.FormattingEnabled = true;
            this.lbxFieldTbl.Location = new System.Drawing.Point(58, 180);
            this.lbxFieldTbl.Name = "lbxFieldTbl";
            this.lbxFieldTbl.Size = new System.Drawing.Size(105, 95);
            this.lbxFieldTbl.TabIndex = 60;
            // 
            // lbxIndTbl
            // 
            this.lbxIndTbl.FormattingEnabled = true;
            this.lbxIndTbl.Location = new System.Drawing.Point(187, 180);
            this.lbxIndTbl.Name = "lbxIndTbl";
            this.lbxIndTbl.Size = new System.Drawing.Size(105, 95);
            this.lbxIndTbl.TabIndex = 61;
            this.metroToolTip1.SetToolTip(this.lbxIndTbl, "Click in a Index to display it\'s fields");
            this.lbxIndTbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxIndTbl_MouseClick);
            // 
            // lbxTables
            // 
            this.lbxTables.FormattingEnabled = true;
            this.lbxTables.Location = new System.Drawing.Point(121, 37);
            this.lbxTables.Name = "lbxTables";
            this.lbxTables.Size = new System.Drawing.Size(105, 95);
            this.lbxTables.TabIndex = 62;
            this.metroToolTip1.SetToolTip(this.lbxTables, "Click in a Table to display it\'s contents");
            this.lbxTables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxTables_MouseClick);
            // 
            // lbxFieldInd
            // 
            this.lbxFieldInd.FormattingEnabled = true;
            this.lbxFieldInd.Location = new System.Drawing.Point(250, 311);
            this.lbxFieldInd.Name = "lbxFieldInd";
            this.lbxFieldInd.Size = new System.Drawing.Size(105, 95);
            this.lbxFieldInd.TabIndex = 63;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(121, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 72;
            this.metroLabel1.Text = "Tables";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(58, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 73;
            this.metroLabel2.Text = "Fields";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(129, 15);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 76;
            this.metroLabel5.Text = "Relations";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(187, 158);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 77;
            this.metroLabel6.Text = "Indexes";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(313, 289);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 78;
            this.metroLabel7.Text = "Fields";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lbxFieldTbl);
            this.groupBox1.Controls.Add(this.lbxIndTbl);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.lbxTables);
            this.groupBox1.Controls.Add(this.lbxFieldInd);
            this.groupBox1.Location = new System.Drawing.Point(32, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 434);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvwRel);
            this.groupBox2.Controls.Add(this.lbxRel);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Location = new System.Drawing.Point(456, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 261);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // lvwRel
            // 
            this.lvwRel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwRel.GridLines = true;
            this.lvwRel.Location = new System.Drawing.Point(18, 180);
            this.lvwRel.Name = "lvwRel";
            this.lvwRel.Size = new System.Drawing.Size(324, 45);
            this.lvwRel.TabIndex = 80;
            this.lvwRel.UseCompatibleStateImageBehavior = false;
            this.lvwRel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Primary Table";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Primary Field";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Foreign Table";
            this.columnHeader7.Width = 79;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Foreign Field";
            this.columnHeader8.Width = 73;
            // 
            // lbxRel
            // 
            this.lbxRel.FormattingEnabled = true;
            this.lbxRel.Location = new System.Drawing.Point(129, 37);
            this.lbxRel.Name = "lbxRel";
            this.lbxRel.Size = new System.Drawing.Size(105, 95);
            this.lbxRel.TabIndex = 79;
            this.metroToolTip1.SetToolTip(this.lbxRel, "Click in a Relation to display it\'s contents");
            this.lbxRel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxRel_MouseClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(18, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 81;
            this.metroLabel3.Text = "Relation Details";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // tleExit
            // 
            this.tleExit.ActiveControl = null;
            this.tleExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleExit.Location = new System.Drawing.Point(717, 22);
            this.tleExit.Name = "tleExit";
            this.tleExit.Size = new System.Drawing.Size(67, 51);
            this.tleExit.TabIndex = 59;
            this.tleExit.Text = "Exit";
            this.tleExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleExit.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Door_Opened_35px;
            this.tleExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleExit, "Click to close this screen");
            this.tleExit.UseCustomBackColor = true;
            this.tleExit.UseSelectable = true;
            this.tleExit.UseTileImage = true;
            this.tleExit.Click += new System.EventHandler(this.tleExit_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::prjCSwinMiniAccess.Properties.Resources.test1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 564);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tleExit);
            this.Controls.Add(this.lblDatabase);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblDatabase;
        private MetroFramework.Controls.MetroTile tleExit;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.ListBox lbxFieldTbl;
        private System.Windows.Forms.ListBox lbxIndTbl;
        private System.Windows.Forms.ListBox lbxTables;
        private System.Windows.Forms.ListBox lbxFieldInd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxRel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListView lvwRel;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}