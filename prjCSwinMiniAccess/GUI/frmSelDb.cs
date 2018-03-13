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
    public partial class frmSelDb : Form
    {
        public frmSelDb(int origin)
        {
            InitializeComponent();
            bound = origin;          
        }
        int bound;
        Database myDB;
        
        private void tleFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDB = new OpenFileDialog();
            openDB.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            openDB.Filter = "Access Database (* .accdb)|*.accdb";
            openDB.Title = "Opening Database";
            openDB.RestoreDirectory = true;
            if (openDB.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openDB.FileName;
                lblPath.Text = openDB.FileName;
            }
        }

        private void tleOpen_Click(object sender, EventArgs e)
        {
            if (lblPath.Text == ".")
            {
                MetroMessageBox.Show(this, "Please select a valid folder and file name!", "Create Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBEngine dbe = new DBEngine();
            myDB = dbe.OpenDatabase(lblPath.Text);
            switch (bound)
            {
                case 1:
                    frmTable ft = new frmTable(myDB);
                    ft.MdiParent = this.ParentForm;
                    ft.Show();
                    break;
                case 2:
                    frmRelations fr = new frmRelations(myDB);
                    fr.MdiParent = this.ParentForm;
                    fr.Show();
                    break;
                case 3:
                    frmView fv = new frmView(myDB);
                    fv.MdiParent = this.ParentForm;
                    fv.Show();
                    break;
            }                         
            this.Close();
        }

        private void frmSelDb_Load(object sender, EventArgs e)
        {

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
