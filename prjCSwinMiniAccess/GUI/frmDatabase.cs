using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.IO;
using MetroFramework;



namespace prjCSwinMiniAccess.GUI
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void tleFolder_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFolder = new SaveFileDialog();
            saveFolder.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            saveFolder.FileName = txtPath.Text;
            saveFolder.DefaultExt = "accdb";
            saveFolder.Filter = "Access Database (* .accdb)|*.accdb";
            saveFolder.Title = "Saving Database";
            saveFolder.CheckFileExists = false;
            saveFolder.CheckPathExists = true;
            if (saveFolder.ShowDialog() == DialogResult.OK)          
            {                                         
                lblPath.Text = saveFolder.FileName;
                txtPath.Text = Path.GetFileName(saveFolder.FileName);
            }

        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            //lblPath.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        }


        private void tleCreate_Click(object sender, EventArgs e)
        {
            if (lblPath.Text == ".")
            {
                MetroMessageBox.Show(this,"Please select a valid folder and file name!", "Create Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(lblPath.Text))
            {
                File.Delete(lblPath.Text);
            }
            DBEngine dbe = new DBEngine();
            Database myDB = dbe.CreateDatabase(lblPath.Text, DAO.LanguageConstants.dbLangGeneral);
            MetroMessageBox.Show(this, Path.GetFileNameWithoutExtension(myDB.Name) + " was created with success!","Create Database",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmTable ft = new frmTable(myDB);
            ft.MdiParent = this.ParentForm;
            ft.Show();
            this.Close();        
        }

        private void tleExit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to close this screen?", "Closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               this.Close();
            }
        }
    }
}
                                          