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
using MetroFramework.Controls;


namespace prjCSwinMiniAccess.GUI
{
    public partial class frmRelations : Form
    {
        Database myDB;
        TableDef myTB;
        Field myFL;
        Index myInd;
        public frmRelations(Database extDB)
        {
            InitializeComponent();
            myDB = extDB;
        }

       
        private string datatypeOf(int index)
        {
            SortedList<int, string> datatypes = new SortedList<int, string>();
            int i = 0;
            foreach (DataTypeEnum item in Enum.GetValues(typeof(DataTypeEnum)))
            {
                datatypes.Add(++i, item.ToString().Substring(2));
            }
            return datatypes[index].ToString();
        }


        private void frmRelations_Load(object sender, EventArgs e)
        {
            //Create a list with all datatypes available to be displayed in the list afterwards
       
            //Fill combobox with available tables
            foreach (TableDef t in myDB.TableDefs)
            {
                if (t.Attributes == 0)
                {
                    cboTable1.Items.Add(t.Name);
                    cboTable2.Items.Add(t.Name);
                }                     
            }
        }

        private void cboTable1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwTbl1.Visible = true;
            lvwTbl1.Items.Clear();
            myTB = myDB.TableDefs[cboTable1.SelectedItem];
            lblTbl1.Visible = true;
            lblTbl1.Text = myTB.Name;
            bool isPK = false;
            foreach (Field myFL in myTB.Fields)
            {
                foreach (Index myInd in myTB.Indexes)
                {
                    foreach (Field myFlInd in (IndexFields)myInd.Fields)
                    {
                        if (myInd.Primary && myFlInd.Name == myFL.Name)
                        {
                            isPK = true;
                            break;
                        }
                    }
                }
                if (isPK)
                {                                                                                   
                    ListViewItem tbl1Item = new ListViewItem("*" + myFL.Name);
                    tbl1Item.SubItems.Add(datatypeOf(myFL.Type));                 
                    lvwTbl1.Items.Add(tbl1Item);                                                    
                }
                else
                {
                    ListViewItem tbl1Item = new ListViewItem(myFL.Name);
                    tbl1Item.SubItems.Add(datatypeOf(myFL.Type));           
                    lvwTbl1.Items.Add(tbl1Item);
                }
                isPK = false;

            }
        }                                           

        private void cboTable2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwTbl2.Visible = true;
            lvwTbl2.Items.Clear();
            myTB = myDB.TableDefs[cboTable2.SelectedItem];
            lblTbl2.Visible = true;
            lblTbl2.Text = myTB.Name;
            bool isPK = false;
            foreach (Field myFL in myTB.Fields)
            {
                foreach (Index myInd in myTB.Indexes)
                {
                    foreach (Field myFlInd in (IndexFields)myInd.Fields)
                    {
                        if (myInd.Primary && myFlInd.Name == myFL.Name)
                        {
                            isPK = true;
                            break;
                        }
                    }
                }
                if (isPK)
                {
                    ListViewItem tbl2Item = new ListViewItem("*" + myFL.Name);
                    tbl2Item.SubItems.Add(datatypeOf(myFL.Type));
                    lvwTbl2.Items.Add(tbl2Item);
                }
                else
                {
                    ListViewItem tbl2Item = new ListViewItem(myFL.Name);
                    tbl2Item.SubItems.Add(datatypeOf(myFL.Type));
                    lvwTbl2.Items.Add(tbl2Item);
                }
                isPK = false;

            }
        }


        private void tleRel_Click(object sender, EventArgs e)
        {
           
            if (cboTable1.Text == cboTable2.Text)
            {
                MetroMessageBox.Show(this, "Invalid selection, can't relate members of the same table!", "Create Relation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (myDB.TableDefs[cboTable1.Text].Fields[txtTbl1.Text].Type != myDB.TableDefs[cboTable2.Text].Fields[txtTbl2.Text].Type)
            {
                MetroMessageBox.Show(this, "Invalid selection, both elements must be of the same data type!", "Create Relation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Relation myRel = myDB.CreateRelation(txtRelation.Text, lblTbl1.Text, lblTbl2.Text);
            myFL = myRel.CreateField(txtTbl1.Text);
            myFL.ForeignName = txtTbl2.Text;
            myRel.Fields.Append(myFL);
            myDB.Relations.Append(myRel);

            MetroMessageBox.Show(this, "Relation Created with success", "Create Relation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtRelation.Clear();
            txtTbl1.Clear();
            txtTbl2.Clear();                                                              
        }

        private void txtRelation_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRelation.Text))
            {
                tleRel.Enabled = true;
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

        private void lvwTbl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvwTbl1.SelectedItems[0].Text.ToString().StartsWith("*"))
            {
                txtTbl1.Text = lvwTbl1.SelectedItems[0].Text.Substring(1);
                return;
            }
            txtTbl1.Text = lvwTbl1.SelectedItems[0].Text.ToString();
        }

        private void lvwTbl2_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvwTbl2.SelectedItems[0].Text.ToString().StartsWith("*"))
            {
                txtTbl2.Text = lvwTbl2.SelectedItems[0].Text.Substring(1);
                return;
            }
            txtTbl2.Text = lvwTbl2.SelectedItems[0].Text.ToString();
        }
    }
}
