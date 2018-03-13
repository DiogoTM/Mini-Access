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
    public partial class frmView : Form
    {
        Database myDB;
        TableDef myTB;
        Field myFL;
        Index myInd;
        Relation myRel;
        public frmView(Database extDB)
        {
            InitializeComponent();
            myDB = extDB;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            lblDatabase.Text = "Database: " + Path.GetFileNameWithoutExtension(myDB.Name);
       
            foreach (TableDef myTb in myDB.TableDefs)
            {
                if (myTb.Attributes == 0)
                {
                    lbxTables.Items.Add(myTb.Name);
                }
            }
            foreach (Relation myRel in myDB.Relations)
            {
                if (myRel.Attributes == 0)
                {
                    lbxRel.Items.Add(myRel.Name);
                }                                                       
            }
        }       


        private void tleExit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to close this screen?", "Closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                myDB.Close();
                this.Close();
            }
        }

        private void lbxTables_MouseClick(object sender, MouseEventArgs e)
        {
            lbxFieldTbl.Items.Clear();
            lbxIndTbl.Items.Clear();
            myTB = myDB.TableDefs[lbxTables.SelectedItem];
            foreach (Field myFL in myTB.Fields)
            {
                lbxFieldTbl.Items.Add(myFL.Name);
            }
            foreach (Index myInd in myTB.Indexes)
            {
                lbxIndTbl.Items.Add(myInd.Name);
            }
        }

        private void lbxIndTbl_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbxIndTbl.SelectedItem != null)
            {
                lbxFieldInd.Items.Clear();
                myInd = myTB.Indexes[lbxIndTbl.SelectedItem];
                foreach (Field myFL in (IndexFields)myInd.Fields)
                {
                    lbxFieldInd.Items.Add(myFL.Name);
                }
            }
         
        }

        private void lbxRel_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbxRel.SelectedItem != null)
            {
                myRel = myDB.Relations[lbxRel.SelectedItem];
                lvwRel.Items.Clear();
                ListViewItem relItem = new ListViewItem(myRel.Table);

                relItem.SubItems.Add(myRel.Fields[0].Name);
                relItem.SubItems.Add(myRel.ForeignTable);
                relItem.SubItems.Add(myRel.Fields[0].ForeignName);

                lvwRel.Items.Add(relItem);
            }                     
        }
    }
}

