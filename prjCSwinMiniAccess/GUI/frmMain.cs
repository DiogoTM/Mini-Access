using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace prjCSwinMiniAccess.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                MetroMessageBox.Show(this, "Please close open forms before opening a new one.", "Open Form!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmDatabase fd = new frmDatabase();
            fd.MdiParent = this;
            fd.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this,"Are you sure you want to quit the program?", "Closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                MetroMessageBox.Show(this, "Please close open forms before opening a new one.", "Open Form!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSelDb fs = new frmSelDb(1);
            fs.MdiParent = this;
            fs.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void relationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                MetroMessageBox.Show(this, "Please close open forms before opening a new one.", "Open Form!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSelDb fs = new frmSelDb(2);
            fs.MdiParent = this;
            fs.Show();
        }

        private void viewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                MetroMessageBox.Show(this, "Please close open forms before opening a new one.", "Open Form!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSelDb fs = new frmSelDb(3);
            fs.MdiParent = this;
            fs.Show();
        }

        private void aboutMiniAccess2018ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.MdiParent = this;
            fa.Show();
        }
    }
}
