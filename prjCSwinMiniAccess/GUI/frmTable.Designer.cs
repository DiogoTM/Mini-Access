namespace prjCSwinMiniAccess.GUI
{
    partial class frmTable
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
            this.tleCreate = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTableName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tleAddField = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtField = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tleSaveTbl = new MetroFramework.Controls.MetroTile();
            this.tleAddIndex = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCurrDB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cboDataType = new MetroFramework.Controls.MetroComboBox();
            this.lblSize = new MetroFramework.Controls.MetroLabel();
            this.txtSize = new MetroFramework.Controls.MetroTextBox();
            this.txtSelIndex = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lvwTable = new MetroFramework.Controls.MetroListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tleExit = new MetroFramework.Controls.MetroTile();
            this.tglPrim = new MetroFramework.Controls.MetroToggle();
            this.txtIndex = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.gbxField = new System.Windows.Forms.GroupBox();
            this.tleCancelF = new MetroFramework.Controls.MetroTile();
            this.tleRemField = new MetroFramework.Controls.MetroTile();
            this.gbxIndex = new System.Windows.Forms.GroupBox();
            this.tleCancelI = new MetroFramework.Controls.MetroTile();
            this.tleRemIndex = new MetroFramework.Controls.MetroTile();
            this.lvwIndex = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTableName = new MetroFramework.Controls.MetroLabel();
            this.tleCancelTbl = new MetroFramework.Controls.MetroTile();
            this.lblIndexes = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.gbxField.SuspendLayout();
            this.gbxIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // tleCreate
            // 
            this.tleCreate.ActiveControl = null;
            this.tleCreate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleCreate.Location = new System.Drawing.Point(282, 33);
            this.tleCreate.Name = "tleCreate";
            this.tleCreate.Size = new System.Drawing.Size(136, 54);
            this.tleCreate.TabIndex = 9;
            this.tleCreate.Text = "Create Table";
            this.tleCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleCreate.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Table_48px;
            this.metroToolTip1.SetToolTip(this.tleCreate, "Click to create a new table");
            this.tleCreate.UseCustomBackColor = true;
            this.tleCreate.UseSelectable = true;
            this.tleCreate.UseTileImage = true;
            this.tleCreate.Click += new System.EventHandler(this.tleCreate_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel2.Location = new System.Drawing.Point(119, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Table Name: ";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtTableName
            // 
            // 
            // 
            // 
            this.txtTableName.CustomButton.Image = null;
            this.txtTableName.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtTableName.CustomButton.Name = "";
            this.txtTableName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTableName.CustomButton.TabIndex = 1;
            this.txtTableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTableName.CustomButton.UseSelectable = true;
            this.txtTableName.CustomButton.Visible = false;
            this.txtTableName.Lines = new string[0];
            this.txtTableName.Location = new System.Drawing.Point(119, 64);
            this.txtTableName.MaxLength = 32767;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.PromptText = "Please enter the table name";
            this.txtTableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTableName.SelectedText = "";
            this.txtTableName.SelectionLength = 0;
            this.txtTableName.SelectionStart = 0;
            this.txtTableName.ShortcutsEnabled = true;
            this.txtTableName.Size = new System.Drawing.Size(157, 23);
            this.txtTableName.TabIndex = 7;
            this.metroToolTip1.SetToolTip(this.txtTableName, "Click to insert the table name");
            this.txtTableName.UseSelectable = true;
            this.txtTableName.WaterMark = "Please enter the table name";
            this.txtTableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel1.Location = new System.Drawing.Point(119, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Create Tables";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tleAddField
            // 
            this.tleAddField.ActiveControl = null;
            this.tleAddField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleAddField.Enabled = false;
            this.tleAddField.Location = new System.Drawing.Point(266, 19);
            this.tleAddField.Name = "tleAddField";
            this.tleAddField.Size = new System.Drawing.Size(123, 36);
            this.tleAddField.TabIndex = 14;
            this.tleAddField.Text = "Add Field";
            this.tleAddField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleAddField.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Insert_Row_25px;
            this.tleAddField.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleAddField, "Click to Add the field");
            this.tleAddField.UseCustomBackColor = true;
            this.tleAddField.UseSelectable = true;
            this.tleAddField.UseTileImage = true;
            this.tleAddField.Click += new System.EventHandler(this.tleAddField_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel3.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel3.Location = new System.Drawing.Point(6, 50);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Field Name: ";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtField
            // 
            // 
            // 
            // 
            this.txtField.CustomButton.Image = null;
            this.txtField.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtField.CustomButton.Name = "";
            this.txtField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtField.CustomButton.TabIndex = 1;
            this.txtField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtField.CustomButton.UseSelectable = true;
            this.txtField.CustomButton.Visible = false;
            this.txtField.Enabled = false;
            this.txtField.Lines = new string[0];
            this.txtField.Location = new System.Drawing.Point(95, 50);
            this.txtField.MaxLength = 32767;
            this.txtField.Name = "txtField";
            this.txtField.PasswordChar = '\0';
            this.txtField.PromptText = "Please enter the field name";
            this.txtField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtField.SelectedText = "";
            this.txtField.SelectionLength = 0;
            this.txtField.SelectionStart = 0;
            this.txtField.ShortcutsEnabled = true;
            this.txtField.Size = new System.Drawing.Size(157, 23);
            this.txtField.TabIndex = 12;
            this.metroToolTip1.SetToolTip(this.txtField, "Click to insert a new field name");
            this.txtField.UseSelectable = true;
            this.txtField.WaterMark = "Please enter the field name";
            this.txtField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtField.TextChanged += new System.EventHandler(this.txtField_TextChanged);
            this.txtField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtField_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel4.Location = new System.Drawing.Point(6, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Fields";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // tleSaveTbl
            // 
            this.tleSaveTbl.ActiveControl = null;
            this.tleSaveTbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleSaveTbl.Enabled = false;
            this.tleSaveTbl.Location = new System.Drawing.Point(653, 14);
            this.tleSaveTbl.Name = "tleSaveTbl";
            this.tleSaveTbl.Size = new System.Drawing.Size(132, 51);
            this.tleSaveTbl.TabIndex = 15;
            this.tleSaveTbl.Text = "Save Table";
            this.tleSaveTbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleSaveTbl.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Save_35px;
            this.tleSaveTbl.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleSaveTbl, "Click to Save the table");
            this.tleSaveTbl.UseCustomBackColor = true;
            this.tleSaveTbl.UseSelectable = true;
            this.tleSaveTbl.UseTileImage = true;
            this.tleSaveTbl.Click += new System.EventHandler(this.tleSave_Click);
            // 
            // tleAddIndex
            // 
            this.tleAddIndex.ActiveControl = null;
            this.tleAddIndex.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleAddIndex.Enabled = false;
            this.tleAddIndex.Location = new System.Drawing.Point(265, 104);
            this.tleAddIndex.Name = "tleAddIndex";
            this.tleAddIndex.Size = new System.Drawing.Size(124, 40);
            this.tleAddIndex.TabIndex = 16;
            this.tleAddIndex.Text = "Add Index";
            this.tleAddIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleAddIndex.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Lightning_Bolt_25px;
            this.tleAddIndex.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleAddIndex, "Click to Add the Index ");
            this.tleAddIndex.UseCustomBackColor = true;
            this.tleAddIndex.UseSelectable = true;
            this.tleAddIndex.UseTileImage = true;
            this.tleAddIndex.Click += new System.EventHandler(this.tleIndex_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel5.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel5.Location = new System.Drawing.Point(6, 119);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Primary:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // lblCurrDB
            // 
            this.lblCurrDB.AutoSize = true;
            this.lblCurrDB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurrDB.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurrDB.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCurrDB.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCurrDB.Location = new System.Drawing.Point(119, 90);
            this.lblCurrDB.Name = "lblCurrDB";
            this.lblCurrDB.Size = new System.Drawing.Size(17, 25);
            this.lblCurrDB.TabIndex = 23;
            this.lblCurrDB.Text = ".";
            this.lblCurrDB.UseCustomBackColor = true;
            this.lblCurrDB.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel8.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel8.Location = new System.Drawing.Point(6, 79);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 19);
            this.metroLabel8.TabIndex = 25;
            this.metroLabel8.Text = "Data Type: ";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // cboDataType
            // 
            this.cboDataType.Enabled = false;
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.ItemHeight = 23;
            this.cboDataType.Location = new System.Drawing.Point(95, 79);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(157, 29);
            this.cboDataType.TabIndex = 26;
            this.metroToolTip1.SetToolTip(this.cboDataType, "Click to select the datatype");
            this.cboDataType.UseSelectable = true;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSize.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblSize.Location = new System.Drawing.Point(6, 114);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 19);
            this.lblSize.TabIndex = 27;
            this.lblSize.Text = "Size:";
            this.lblSize.UseCustomBackColor = true;
            this.lblSize.UseCustomForeColor = true;
            this.lblSize.Visible = false;
            // 
            // txtSize
            // 
            // 
            // 
            // 
            this.txtSize.CustomButton.Image = null;
            this.txtSize.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtSize.CustomButton.Name = "";
            this.txtSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSize.CustomButton.TabIndex = 1;
            this.txtSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSize.CustomButton.UseSelectable = true;
            this.txtSize.CustomButton.Visible = false;
            this.txtSize.Enabled = false;
            this.txtSize.Lines = new string[0];
            this.txtSize.Location = new System.Drawing.Point(95, 114);
            this.txtSize.MaxLength = 32767;
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.PromptText = "Enter the size of text";
            this.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSize.SelectedText = "";
            this.txtSize.SelectionLength = 0;
            this.txtSize.SelectionStart = 0;
            this.txtSize.ShortcutsEnabled = true;
            this.txtSize.Size = new System.Drawing.Size(157, 23);
            this.txtSize.TabIndex = 28;
            this.metroToolTip1.SetToolTip(this.txtSize, "Click to enter the size for the text field");
            this.txtSize.UseSelectable = true;
            this.txtSize.Visible = false;
            this.txtSize.WaterMark = "Enter the size of text";
            this.txtSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSelIndex
            // 
            // 
            // 
            // 
            this.txtSelIndex.CustomButton.Image = null;
            this.txtSelIndex.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtSelIndex.CustomButton.Name = "";
            this.txtSelIndex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSelIndex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSelIndex.CustomButton.TabIndex = 1;
            this.txtSelIndex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSelIndex.CustomButton.UseSelectable = true;
            this.txtSelIndex.CustomButton.Visible = false;
            this.txtSelIndex.Enabled = false;
            this.txtSelIndex.Lines = new string[0];
            this.txtSelIndex.Location = new System.Drawing.Point(138, 46);
            this.txtSelIndex.MaxLength = 32767;
            this.txtSelIndex.Name = "txtSelIndex";
            this.txtSelIndex.PasswordChar = '\0';
            this.txtSelIndex.PromptText = "<- Please select a field from the table";
            this.txtSelIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSelIndex.SelectedText = "";
            this.txtSelIndex.SelectionLength = 0;
            this.txtSelIndex.SelectionStart = 0;
            this.txtSelIndex.ShortcutsEnabled = true;
            this.txtSelIndex.Size = new System.Drawing.Size(207, 23);
            this.txtSelIndex.TabIndex = 29;
            this.metroToolTip1.SetToolTip(this.txtSelIndex, "Shows the field selected on the table");
            this.txtSelIndex.UseSelectable = true;
            this.txtSelIndex.WaterMark = "<- Please select a field from the table";
            this.txtSelIndex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSelIndex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // lvwTable
            // 
            this.lvwTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.FieldName,
            this.DataType,
            this.Size});
            this.lvwTable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwTable.FullRowSelect = true;
            this.lvwTable.GridLines = true;
            this.lvwTable.Location = new System.Drawing.Point(559, 116);
            this.lvwTable.MultiSelect = false;
            this.lvwTable.Name = "lvwTable";
            this.lvwTable.OwnerDraw = true;
            this.lvwTable.Size = new System.Drawing.Size(431, 233);
            this.lvwTable.TabIndex = 30;
            this.metroToolTip1.SetToolTip(this.lvwTable, "Click on an item to select");
            this.lvwTable.UseCompatibleStateImageBehavior = false;
            this.lvwTable.UseSelectable = true;
            this.lvwTable.View = System.Windows.Forms.View.Details;
            this.lvwTable.Visible = false;
            this.lvwTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwTable_MouseClick_1);
            // 
            // Index
            // 
            this.Index.Text = "";
            this.Index.Width = 75;
            // 
            // FieldName
            // 
            this.FieldName.Text = "Field Name";
            this.FieldName.Width = 169;
            // 
            // DataType
            // 
            this.DataType.Text = "Data Type";
            this.DataType.Width = 123;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 58;
            // 
            // tleExit
            // 
            this.tleExit.ActiveControl = null;
            this.tleExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleExit.Location = new System.Drawing.Point(923, 14);
            this.tleExit.Name = "tleExit";
            this.tleExit.Size = new System.Drawing.Size(67, 51);
            this.tleExit.TabIndex = 32;
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
            // tglPrim
            // 
            this.tglPrim.AutoSize = true;
            this.tglPrim.Location = new System.Drawing.Point(96, 121);
            this.tglPrim.Name = "tglPrim";
            this.tglPrim.Size = new System.Drawing.Size(80, 17);
            this.tglPrim.TabIndex = 33;
            this.tglPrim.Text = "Off";
            this.metroToolTip1.SetToolTip(this.tglPrim, "Select On if index is Primary Key");
            this.tglPrim.UseSelectable = true;
            // 
            // txtIndex
            // 
            // 
            // 
            // 
            this.txtIndex.CustomButton.Image = null;
            this.txtIndex.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtIndex.CustomButton.Name = "";
            this.txtIndex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIndex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIndex.CustomButton.TabIndex = 1;
            this.txtIndex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIndex.CustomButton.UseSelectable = true;
            this.txtIndex.CustomButton.Visible = false;
            this.txtIndex.Lines = new string[0];
            this.txtIndex.Location = new System.Drawing.Point(138, 75);
            this.txtIndex.MaxLength = 32767;
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.PasswordChar = '\0';
            this.txtIndex.PromptText = "Please enter the index name";
            this.txtIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIndex.SelectedText = "";
            this.txtIndex.SelectionLength = 0;
            this.txtIndex.SelectionStart = 0;
            this.txtIndex.ShortcutsEnabled = true;
            this.txtIndex.Size = new System.Drawing.Size(207, 23);
            this.txtIndex.TabIndex = 38;
            this.metroToolTip1.SetToolTip(this.txtIndex, "Click to enter the index name");
            this.txtIndex.UseSelectable = true;
            this.txtIndex.WaterMark = "Please enter the index name";
            this.txtIndex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIndex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            this.txtIndex.Click += new System.EventHandler(this.txtIndex_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel9.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel9.Location = new System.Drawing.Point(6, 75);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 19);
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "Index Name:";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel10.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel10.Location = new System.Drawing.Point(6, 46);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(125, 19);
            this.metroLabel10.TabIndex = 40;
            this.metroLabel10.Text = "Field to be indexed:";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroLabel11.Location = new System.Drawing.Point(6, 16);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(60, 19);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Indexes";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // gbxField
            // 
            this.gbxField.Controls.Add(this.tleCancelF);
            this.gbxField.Controls.Add(this.tleRemField);
            this.gbxField.Controls.Add(this.metroLabel4);
            this.gbxField.Controls.Add(this.txtField);
            this.gbxField.Controls.Add(this.metroLabel3);
            this.gbxField.Controls.Add(this.tleAddField);
            this.gbxField.Controls.Add(this.metroLabel8);
            this.gbxField.Controls.Add(this.cboDataType);
            this.gbxField.Controls.Add(this.lblSize);
            this.gbxField.Controls.Add(this.txtSize);
            this.gbxField.Location = new System.Drawing.Point(119, 116);
            this.gbxField.Name = "gbxField";
            this.gbxField.Size = new System.Drawing.Size(402, 156);
            this.gbxField.TabIndex = 42;
            this.gbxField.TabStop = false;
            // 
            // tleCancelF
            // 
            this.tleCancelF.ActiveControl = null;
            this.tleCancelF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleCancelF.Location = new System.Drawing.Point(266, 103);
            this.tleCancelF.Name = "tleCancelF";
            this.tleCancelF.Size = new System.Drawing.Size(123, 36);
            this.tleCancelF.TabIndex = 29;
            this.tleCancelF.Text = "Cancel";
            this.tleCancelF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleCancelF.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Cancel_25px;
            this.tleCancelF.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleCancelF, "Click to Cancel operation and clear the options entered");
            this.tleCancelF.UseCustomBackColor = true;
            this.tleCancelF.UseSelectable = true;
            this.tleCancelF.UseTileImage = true;
            this.tleCancelF.Click += new System.EventHandler(this.tleCancelF_Click);
            // 
            // tleRemField
            // 
            this.tleRemField.ActiveControl = null;
            this.tleRemField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleRemField.Enabled = false;
            this.tleRemField.Location = new System.Drawing.Point(266, 61);
            this.tleRemField.Name = "tleRemField";
            this.tleRemField.Size = new System.Drawing.Size(123, 36);
            this.tleRemField.TabIndex = 30;
            this.tleRemField.Text = "Remove Field";
            this.tleRemField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleRemField.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Delete_Row_25px;
            this.tleRemField.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleRemField, "Click to Remove the field selected in the table");
            this.tleRemField.UseCustomBackColor = true;
            this.tleRemField.UseSelectable = true;
            this.tleRemField.UseTileImage = true;
            this.tleRemField.Click += new System.EventHandler(this.tleRemField_Click);
            // 
            // gbxIndex
            // 
            this.gbxIndex.Controls.Add(this.tleCancelI);
            this.gbxIndex.Controls.Add(this.tleRemIndex);
            this.gbxIndex.Controls.Add(this.metroLabel11);
            this.gbxIndex.Controls.Add(this.tleAddIndex);
            this.gbxIndex.Controls.Add(this.metroLabel5);
            this.gbxIndex.Controls.Add(this.metroLabel10);
            this.gbxIndex.Controls.Add(this.txtSelIndex);
            this.gbxIndex.Controls.Add(this.metroLabel9);
            this.gbxIndex.Controls.Add(this.tglPrim);
            this.gbxIndex.Controls.Add(this.txtIndex);
            this.gbxIndex.Location = new System.Drawing.Point(119, 280);
            this.gbxIndex.Name = "gbxIndex";
            this.gbxIndex.Size = new System.Drawing.Size(402, 230);
            this.gbxIndex.TabIndex = 43;
            this.gbxIndex.TabStop = false;
            // 
            // tleCancelI
            // 
            this.tleCancelI.ActiveControl = null;
            this.tleCancelI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleCancelI.Location = new System.Drawing.Point(265, 184);
            this.tleCancelI.Name = "tleCancelI";
            this.tleCancelI.Size = new System.Drawing.Size(124, 40);
            this.tleCancelI.TabIndex = 43;
            this.tleCancelI.Text = "Cancel";
            this.tleCancelI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleCancelI.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Cancel_25px1;
            this.tleCancelI.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleCancelI, "Click to Cancel operation and clear the options entered");
            this.tleCancelI.UseCustomBackColor = true;
            this.tleCancelI.UseSelectable = true;
            this.tleCancelI.UseTileImage = true;
            this.tleCancelI.Click += new System.EventHandler(this.tleCancelI_Click);
            // 
            // tleRemIndex
            // 
            this.tleRemIndex.ActiveControl = null;
            this.tleRemIndex.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleRemIndex.Enabled = false;
            this.tleRemIndex.Location = new System.Drawing.Point(265, 144);
            this.tleRemIndex.Name = "tleRemIndex";
            this.tleRemIndex.Size = new System.Drawing.Size(124, 40);
            this.tleRemIndex.TabIndex = 42;
            this.tleRemIndex.Text = "Remove Index";
            this.tleRemIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleRemIndex.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Minus_25px;
            this.tleRemIndex.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleRemIndex, "Click to remove the index selected on the table");
            this.tleRemIndex.UseCustomBackColor = true;
            this.tleRemIndex.UseSelectable = true;
            this.tleRemIndex.UseTileImage = true;
            this.tleRemIndex.Click += new System.EventHandler(this.tleRemIndex_Click);
            // 
            // lvwIndex
            // 
            this.lvwIndex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwIndex.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwIndex.FullRowSelect = true;
            this.lvwIndex.GridLines = true;
            this.lvwIndex.Location = new System.Drawing.Point(559, 384);
            this.lvwIndex.Name = "lvwIndex";
            this.lvwIndex.OwnerDraw = true;
            this.lvwIndex.Size = new System.Drawing.Size(431, 126);
            this.lvwIndex.TabIndex = 47;
            this.metroToolTip1.SetToolTip(this.lvwIndex, "Click on an item to select");
            this.lvwIndex.UseCompatibleStateImageBehavior = false;
            this.lvwIndex.UseSelectable = true;
            this.lvwIndex.View = System.Windows.Forms.View.Details;
            this.lvwIndex.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index Name";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Field Name";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prim.";
            this.columnHeader3.Width = 53;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Uniq.";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ign. Nulls";
            this.columnHeader5.Width = 82;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTableName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTableName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTableName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTableName.Location = new System.Drawing.Point(559, 88);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(17, 25);
            this.lblTableName.TabIndex = 44;
            this.lblTableName.Text = ".";
            this.lblTableName.UseCustomBackColor = true;
            this.lblTableName.UseCustomForeColor = true;
            this.lblTableName.Visible = false;
            // 
            // tleCancelTbl
            // 
            this.tleCancelTbl.ActiveControl = null;
            this.tleCancelTbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleCancelTbl.Location = new System.Drawing.Point(791, 14);
            this.tleCancelTbl.Name = "tleCancelTbl";
            this.tleCancelTbl.Size = new System.Drawing.Size(132, 51);
            this.tleCancelTbl.TabIndex = 45;
            this.tleCancelTbl.Text = "Cancel Table";
            this.tleCancelTbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleCancelTbl.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Cancel_35px;
            this.tleCancelTbl.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleCancelTbl, "Click to Cancel operation and clear the options entered");
            this.tleCancelTbl.UseCustomBackColor = true;
            this.tleCancelTbl.UseSelectable = true;
            this.tleCancelTbl.UseTileImage = true;
            this.tleCancelTbl.Click += new System.EventHandler(this.tleCancelTbl_Click);
            // 
            // lblIndexes
            // 
            this.lblIndexes.AutoSize = true;
            this.lblIndexes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblIndexes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIndexes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIndexes.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblIndexes.Location = new System.Drawing.Point(559, 355);
            this.lblIndexes.Name = "lblIndexes";
            this.lblIndexes.Size = new System.Drawing.Size(183, 25);
            this.lblIndexes.TabIndex = 48;
            this.lblIndexes.Text = "Indexes in this table";
            this.lblIndexes.UseCustomBackColor = true;
            this.lblIndexes.UseCustomForeColor = true;
            this.lblIndexes.Visible = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::prjCSwinMiniAccess.Properties.Resources.Insert_Table_100px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1015, 536);
            this.ControlBox = false;
            this.Controls.Add(this.lblIndexes);
            this.Controls.Add(this.lvwIndex);
            this.Controls.Add(this.tleCancelTbl);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.gbxIndex);
            this.Controls.Add(this.gbxField);
            this.Controls.Add(this.tleExit);
            this.Controls.Add(this.lvwTable);
            this.Controls.Add(this.lblCurrDB);
            this.Controls.Add(this.tleSaveTbl);
            this.Controls.Add(this.tleCreate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.gbxField.ResumeLayout(false);
            this.gbxField.PerformLayout();
            this.gbxIndex.ResumeLayout(false);
            this.gbxIndex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tleCreate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTableName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tleAddField;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtField;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile tleSaveTbl;
        private MetroFramework.Controls.MetroTile tleAddIndex;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblCurrDB;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cboDataType;
        private MetroFramework.Controls.MetroLabel lblSize;
        private MetroFramework.Controls.MetroTextBox txtSize;
        private MetroFramework.Controls.MetroTextBox txtSelIndex;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroListView lvwTable;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader FieldName;
        private System.Windows.Forms.ColumnHeader DataType;
        private System.Windows.Forms.ColumnHeader Size;
        private MetroFramework.Controls.MetroTile tleExit;
        private MetroFramework.Controls.MetroToggle tglPrim;
        private MetroFramework.Controls.MetroTextBox txtIndex;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox gbxField;
        private System.Windows.Forms.GroupBox gbxIndex;
        private MetroFramework.Controls.MetroLabel lblTableName;
        private MetroFramework.Controls.MetroTile tleCancelF;
        private MetroFramework.Controls.MetroTile tleRemField;
        private MetroFramework.Controls.MetroTile tleCancelI;
        private MetroFramework.Controls.MetroTile tleRemIndex;
        private MetroFramework.Controls.MetroTile tleCancelTbl;
        private MetroFramework.Controls.MetroListView lvwIndex;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroLabel lblIndexes;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}