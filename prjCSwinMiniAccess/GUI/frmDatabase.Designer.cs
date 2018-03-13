namespace prjCSwinMiniAccess.GUI
{
    partial class frmDatabase
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblPath = new MetroFramework.Controls.MetroLabel();
            this.tleFolder = new MetroFramework.Controls.MetroTile();
            this.tleCreate = new MetroFramework.Controls.MetroTile();
            this.tleExit = new MetroFramework.Controls.MetroTile();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(134, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Create Database";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.HotTrack;
            // 
            // 
            // 
            this.txtPath.CustomButton.Image = null;
            this.txtPath.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPath.CustomButton.Name = "";
            this.txtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.CustomButton.TabIndex = 1;
            this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPath.CustomButton.UseSelectable = true;
            this.txtPath.CustomButton.Visible = false;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(134, 75);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PromptText = "File Name";
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.ShortcutsEnabled = true;
            this.txtPath.Size = new System.Drawing.Size(200, 23);
            this.txtPath.TabIndex = 1;
            this.txtPath.UseSelectable = true;
            this.txtPath.WaterMark = "File Name";
            this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(134, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "File Name: ";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lblPath
            // 
            this.lblPath.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPath.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblPath.ForeColor = System.Drawing.Color.White;
            this.lblPath.Location = new System.Drawing.Point(134, 101);
            this.lblPath.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(240, 32);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = ".";
            this.lblPath.UseCustomBackColor = true;
            this.lblPath.UseCustomForeColor = true;
            // 
            // tleFolder
            // 
            this.tleFolder.ActiveControl = null;
            this.tleFolder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tleFolder.Location = new System.Drawing.Point(340, 75);
            this.tleFolder.Name = "tleFolder";
            this.tleFolder.Size = new System.Drawing.Size(34, 23);
            this.tleFolder.TabIndex = 2;
            this.tleFolder.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Open_25px;
            this.tleFolder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.tleFolder, "Click here to select the folder and file name for your database");
            this.tleFolder.UseCustomBackColor = true;
            this.tleFolder.UseCustomForeColor = true;
            this.tleFolder.UseSelectable = true;
            this.tleFolder.UseTileImage = true;
            this.tleFolder.Click += new System.EventHandler(this.tleFolder_Click);
            // 
            // tleCreate
            // 
            this.tleCreate.ActiveControl = null;
            this.tleCreate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleCreate.ForeColor = System.Drawing.Color.White;
            this.tleCreate.Location = new System.Drawing.Point(290, 136);
            this.tleCreate.Name = "tleCreate";
            this.tleCreate.Size = new System.Drawing.Size(108, 54);
            this.tleCreate.TabIndex = 5;
            this.tleCreate.Text = "Create";
            this.tleCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleCreate.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Add_File_48px;
            this.metroToolTip1.SetToolTip(this.tleCreate, "Click here to create the database");
            this.tleCreate.UseCustomBackColor = true;
            this.tleCreate.UseCustomForeColor = true;
            this.tleCreate.UseSelectable = true;
            this.tleCreate.UseTileImage = true;
            this.tleCreate.Click += new System.EventHandler(this.tleCreate_Click);
            // 
            // tleExit
            // 
            this.tleExit.ActiveControl = null;
            this.tleExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tleExit.ForeColor = System.Drawing.Color.White;
            this.tleExit.Location = new System.Drawing.Point(352, 12);
            this.tleExit.Name = "tleExit";
            this.tleExit.Size = new System.Drawing.Size(69, 37);
            this.tleExit.TabIndex = 66;
            this.tleExit.Text = "Exit";
            this.tleExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tleExit.TileImage = global::prjCSwinMiniAccess.Properties.Resources.Door_Opened_25px;
            this.tleExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.tleExit, "Click to close this screen");
            this.tleExit.UseCustomBackColor = true;
            this.tleExit.UseCustomForeColor = true;
            this.tleExit.UseSelectable = true;
            this.tleExit.UseTileImage = true;
            this.tleExit.Click += new System.EventHandler(this.tleExit_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::prjCSwinMiniAccess.Properties.Resources.Add_Database_96px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(433, 217);
            this.ControlBox = false;
            this.Controls.Add(this.tleExit);
            this.Controls.Add(this.tleCreate);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tleFolder);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private MetroFramework.Controls.MetroTile tleFolder;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblPath;
        private MetroFramework.Controls.MetroTile tleCreate;
        private MetroFramework.Controls.MetroTile tleExit;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}