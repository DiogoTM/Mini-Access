namespace prjCSwinMiniAccess.GUI
{
    partial class frmRelations
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
            this.cboTable1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboTable2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tleRel = new MetroFramework.Controls.MetroTile();
            this.txtRelation = new MetroFramework.Controls.MetroTextBox();
            this.txtTbl1 = new MetroFramework.Controls.MetroTextBox();
            this.txtTbl2 = new MetroFramework.Controls.MetroTextBox();
            this.lblTbl1 = new MetroFramework.Controls.MetroLabel();
            this.lblTbl2 = new MetroFramework.Controls.MetroLabel();
            this.tleExit = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lvwTbl1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwTbl2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTable1
            // 
            this.cboTable1.FormattingEnabled = true;
            this.cboTable1.ItemHeight = 23;
            this.cboTable1.Location = new System.Drawing.Point(135, 106);
            this.cboTable1.Name = "cboTable1";
            this.cboTable1.Size = new System.Drawing.Size(167, 29);
            this.cboTable1.TabIndex = 46;
            this.metroToolTip1.SetToolTip(this.cboTable1, "Click here to select the Primary Table");
            this.cboTable1.UseSelectable = true;
            this.cboTable1.SelectedIndexChanged += new System.EventHandler(this.cboTable1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(135, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "Primary Table";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(135, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(151, 25);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "Create Relations";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.Location = new System.Drawing.Point(326, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "Foreign Table";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // cboTable2
            // 
            this.cboTable2.FormattingEnabled = true;
            this.cboTable2.ItemHeight = 23;
            this.cboTable2.Location = new System.Drawing.Point(326, 108);
            this.cboTable2.Name = "cboTable2";
            this.cboTable2.Size = new System.Drawing.Size(167, 29);
            this.cboTable2.TabIndex = 50;
            this.metroToolTip1.SetToolTip(this.cboTable2, "Click here to select the Foreign Table");
            this.cboTable2.UseSelectable = true;
            this.cboTable2.SelectedIndexChanged += new System.EventHandler(this.cboTable2_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.Location = new System.Drawing.Point(135, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(429, 38);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "To create a relation, please select 2 tables from the current Database.\r\nIn the s" +
    "equence, please select the fields from each table. ";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.Location = new System.Drawing.Point(11, 17);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 54;
            this.metroLabel5.Text = "Relation Name";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.Location = new System.Drawing.Point(11, 62);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 56;
            this.metroLabel6.Text = "Primary Field";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.Location = new System.Drawing.Point(11, 109);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 58;
            this.metroLabel7.Text = "Foreign Field";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // tleRel
            // 
            this.tleRel.ActiveControl = null;
            this.tleRel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleRel.Enabled = false;
            this.tleRel.Location = new System.Drawing.Point(11, 160);
            this.tleRel.Name = "tleRel";
            this.tleRel.Size = new System.Drawing.Size(173, 64);
            this.tleRel.TabIndex = 59;
            this.tleRel.Text = "Create Relation";
            this.tleRel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleRel.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Add_Link_48px;
            this.tleRel.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleRel, "Click here to create the Relation");
            this.tleRel.UseCustomBackColor = true;
            this.tleRel.UseSelectable = true;
            this.tleRel.UseTileImage = true;
            this.tleRel.Click += new System.EventHandler(this.tleRel_Click);
            // 
            // txtRelation
            // 
            // 
            // 
            // 
            this.txtRelation.CustomButton.Image = null;
            this.txtRelation.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtRelation.CustomButton.Name = "";
            this.txtRelation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRelation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRelation.CustomButton.TabIndex = 1;
            this.txtRelation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRelation.CustomButton.UseSelectable = true;
            this.txtRelation.CustomButton.Visible = false;
            this.txtRelation.Lines = new string[0];
            this.txtRelation.Location = new System.Drawing.Point(11, 37);
            this.txtRelation.MaxLength = 32767;
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.PasswordChar = '\0';
            this.txtRelation.PromptText = "Please enter the relation name";
            this.txtRelation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRelation.SelectedText = "";
            this.txtRelation.SelectionLength = 0;
            this.txtRelation.SelectionStart = 0;
            this.txtRelation.ShortcutsEnabled = true;
            this.txtRelation.Size = new System.Drawing.Size(204, 23);
            this.txtRelation.TabIndex = 60;
            this.metroToolTip1.SetToolTip(this.txtRelation, "Insert the Relation name here");
            this.txtRelation.UseSelectable = true;
            this.txtRelation.WaterMark = "Please enter the relation name";
            this.txtRelation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRelation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRelation.TextChanged += new System.EventHandler(this.txtRelation_TextChanged);
            // 
            // txtTbl1
            // 
            // 
            // 
            // 
            this.txtTbl1.CustomButton.Image = null;
            this.txtTbl1.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtTbl1.CustomButton.Name = "";
            this.txtTbl1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTbl1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTbl1.CustomButton.TabIndex = 1;
            this.txtTbl1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTbl1.CustomButton.UseSelectable = true;
            this.txtTbl1.CustomButton.Visible = false;
            this.txtTbl1.Lines = new string[0];
            this.txtTbl1.Location = new System.Drawing.Point(11, 84);
            this.txtTbl1.MaxLength = 32767;
            this.txtTbl1.Name = "txtTbl1";
            this.txtTbl1.PasswordChar = '\0';
            this.txtTbl1.PromptText = "<-Please select the field on the table";
            this.txtTbl1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTbl1.SelectedText = "";
            this.txtTbl1.SelectionLength = 0;
            this.txtTbl1.SelectionStart = 0;
            this.txtTbl1.ShortcutsEnabled = true;
            this.txtTbl1.Size = new System.Drawing.Size(204, 23);
            this.txtTbl1.TabIndex = 61;
            this.txtTbl1.UseSelectable = true;
            this.txtTbl1.WaterMark = "<-Please select the field on the table";
            this.txtTbl1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTbl1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTbl2
            // 
            // 
            // 
            // 
            this.txtTbl2.CustomButton.Image = null;
            this.txtTbl2.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtTbl2.CustomButton.Name = "";
            this.txtTbl2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTbl2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTbl2.CustomButton.TabIndex = 1;
            this.txtTbl2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTbl2.CustomButton.UseSelectable = true;
            this.txtTbl2.CustomButton.Visible = false;
            this.txtTbl2.Lines = new string[0];
            this.txtTbl2.Location = new System.Drawing.Point(11, 131);
            this.txtTbl2.MaxLength = 32767;
            this.txtTbl2.Name = "txtTbl2";
            this.txtTbl2.PasswordChar = '\0';
            this.txtTbl2.PromptText = "<-Please select the field on the table";
            this.txtTbl2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTbl2.SelectedText = "";
            this.txtTbl2.SelectionLength = 0;
            this.txtTbl2.SelectionStart = 0;
            this.txtTbl2.ShortcutsEnabled = true;
            this.txtTbl2.Size = new System.Drawing.Size(204, 23);
            this.txtTbl2.TabIndex = 62;
            this.txtTbl2.UseSelectable = true;
            this.txtTbl2.WaterMark = "<-Please select the field on the table";
            this.txtTbl2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTbl2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTbl1
            // 
            this.lblTbl1.AutoSize = true;
            this.lblTbl1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTbl1.Location = new System.Drawing.Point(135, 138);
            this.lblTbl1.Name = "lblTbl1";
            this.lblTbl1.Size = new System.Drawing.Size(12, 19);
            this.lblTbl1.TabIndex = 63;
            this.lblTbl1.Text = ".";
            this.lblTbl1.UseCustomBackColor = true;
            this.lblTbl1.UseCustomForeColor = true;
            this.lblTbl1.Visible = false;
            // 
            // lblTbl2
            // 
            this.lblTbl2.AutoSize = true;
            this.lblTbl2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTbl2.Location = new System.Drawing.Point(326, 139);
            this.lblTbl2.Name = "lblTbl2";
            this.lblTbl2.Size = new System.Drawing.Size(12, 19);
            this.lblTbl2.TabIndex = 64;
            this.lblTbl2.Text = ".";
            this.lblTbl2.UseCustomBackColor = true;
            this.lblTbl2.UseCustomForeColor = true;
            this.lblTbl2.Visible = false;
            // 
            // tleExit
            // 
            this.tleExit.ActiveControl = null;
            this.tleExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleExit.Location = new System.Drawing.Point(684, 12);
            this.tleExit.Name = "tleExit";
            this.tleExit.Size = new System.Drawing.Size(70, 49);
            this.tleExit.TabIndex = 65;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tleRel);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtTbl2);
            this.groupBox1.Controls.Add(this.txtRelation);
            this.groupBox1.Controls.Add(this.txtTbl1);
            this.groupBox1.Location = new System.Drawing.Point(521, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 248);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lvwTbl1
            // 
            this.lvwTbl1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwTbl1.GridLines = true;
            this.lvwTbl1.Location = new System.Drawing.Point(135, 161);
            this.lvwTbl1.Name = "lvwTbl1";
            this.lvwTbl1.Size = new System.Drawing.Size(167, 172);
            this.lvwTbl1.TabIndex = 67;
            this.metroToolTip1.SetToolTip(this.lvwTbl1, "Click here to select the Primary Field\r\n* indicates that the field is Primary Key" +
        "");
            this.lvwTbl1.UseCompatibleStateImageBehavior = false;
            this.lvwTbl1.View = System.Windows.Forms.View.Details;
            this.lvwTbl1.Visible = false;
            this.lvwTbl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwTbl1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Field Name";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Type";
            this.columnHeader2.Width = 85;
            // 
            // lvwTbl2
            // 
            this.lvwTbl2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvwTbl2.GridLines = true;
            this.lvwTbl2.Location = new System.Drawing.Point(326, 161);
            this.lvwTbl2.Name = "lvwTbl2";
            this.lvwTbl2.Size = new System.Drawing.Size(167, 172);
            this.lvwTbl2.TabIndex = 68;
            this.metroToolTip1.SetToolTip(this.lvwTbl2, "Click here to select the Foreign Field\r\n* indicates that the field is Primary Key" +
        "");
            this.lvwTbl2.UseCompatibleStateImageBehavior = false;
            this.lvwTbl2.View = System.Windows.Forms.View.Details;
            this.lvwTbl2.Visible = false;
            this.lvwTbl2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwTbl2_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Field Name";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data Type";
            this.columnHeader4.Width = 85;
            // 
            // frmRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::prjCSwinMiniAccess.Properties.Resources.Link_104px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(766, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lvwTbl2);
            this.Controls.Add(this.lvwTbl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tleExit);
            this.Controls.Add(this.lblTbl2);
            this.Controls.Add(this.lblTbl1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cboTable2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboTable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmRelations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRelations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cboTable1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cboTable2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile tleRel;
        private MetroFramework.Controls.MetroTextBox txtRelation;
        private MetroFramework.Controls.MetroTextBox txtTbl1;
        private MetroFramework.Controls.MetroTextBox txtTbl2;
        private MetroFramework.Controls.MetroLabel lblTbl1;
        private MetroFramework.Controls.MetroLabel lblTbl2;
        private MetroFramework.Controls.MetroTile tleExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.ListView lvwTbl1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvwTbl2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}