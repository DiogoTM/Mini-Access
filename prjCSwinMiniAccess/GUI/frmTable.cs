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
    public partial class frmTable : Form       
    {
        
        Database myDB;
        TableDef myTB;
        Field myFL;
        Index myInd;



        public frmTable(Database extDB)
        {
            InitializeComponent();
            myDB = extDB;
        }

        //Function to clear all the information in the available fields
        private void clearAll()
        {
            txtField.Clear();
            txtSelIndex.Clear();
            txtSize.Clear();
            txtTableName.Clear();
            txtIndex.Clear();
            cboDataType.ResetText();
            lblTableName.Text = ".";
            lvwTable.Items.Clear();
            lvwTable.Visible = false;
            lvwIndex.Items.Clear();
            lvwIndex.Visible = false;
            lblIndexes.Visible = false;
            tglPrim.Checked = false;       
            tleRemField.Enabled = false;
            tleRemIndex.Enabled = false;
            lvwTable.SelectedItems.Clear();
            lvwIndex.SelectedItems.Clear();
            txtField.Enabled = false;
            cboDataType.Enabled = false;
            txtSize.Enabled = false;
        }
        //Function to clear the data after creating a Field or a Index
        private void clearAftCreate()
        {
            txtField.Clear();
            txtSelIndex.Clear();
            txtSize.Clear();
            txtIndex.Clear();
            cboDataType.ResetText();
            tglPrim.Checked = false;  
            tleAddIndex.Enabled = false;
            lvwTable.SelectedItems.Clear();
            lvwIndex.SelectedItems.Clear();          

        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            //Fill combobox with data types available

            cboDataType.Items.Add("AutoNumber");
            foreach (DataTypeEnum item in Enum.GetValues(typeof(DataTypeEnum)))
            {
                cboDataType.Items.Add(item.ToString().Substring(2));                       
            }
            cboDataType.Items.Remove("Decimal");//This datatype is giving a runtime error, need to be analysed.  
            cboDataType.Items.Remove("Char");//This datatype is giving a runtime error, need to be analysed.  
            cboDataType.Items.Remove("Numeric");//This datatype is giving a runtime error, need to be analysed.       
            cboDataType.Items.Remove("Float");//This datatype is giving a runtime error, need to be analysed.      
            cboDataType.Items.Remove("Time");//This datatype is giving a runtime error, need to be analysed.       
            cboDataType.Items.Remove("TimeStamp");//This datatype is giving a runtime error, need to be analysed.           

            //Fill title with database name
            lblCurrDB.Text = "Database: " + Path.GetFileNameWithoutExtension(myDB.Name);        
        }
        
        
        private void cboIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSelIndex.Text != null)
            {
                tleAddIndex.Enabled = true;
            }
        }               
        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e)
        {                   
            if (cboDataType.SelectedIndex == -1)
            {
                txtSize.Visible = lblSize.Visible = false;
                return;
            }
            else if (cboDataType.SelectedItem.ToString() == "Text")
            {
                txtSize.Visible = lblSize.Visible = true;
            }
            else
            {
                txtSize.Visible = lblSize.Visible = false;
            }
            if (string.IsNullOrEmpty(txtField.Text) || string.IsNullOrEmpty(cboDataType.Text))
            {
                tleAddField.Enabled = false;
                return;
            }

            tleAddField.Enabled = true;       
        }                    

        private void tleCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTableName.Text))
            {
                MetroMessageBox.Show(this, "Table not created, please insert a valid name!", "Create table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTableName.Clear();
                txtTableName.Focus();
                return;
            }
            foreach (TableDef t in myDB.TableDefs)
            {
                if (t.Name == txtTableName.Text)
                {
                    MetroMessageBox.Show(this, "Table not created, name already in use!", "Create table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTableName.Clear();
                    txtTableName.Focus();
                    return;
                }
            }
       
            myTB = myDB.CreateTableDef(txtTableName.Text);
            lvwTable.Items.Clear();
            lvwTable.Visible = true;
            lvwIndex.Visible = true;                       
            tleRemField.Enabled = true;
            tleRemIndex.Enabled = true;
            lblIndexes.Visible = true;
            lblTableName.Visible = true;
            lblTableName.Text = txtTableName.Text;
            txtField.Enabled = true;
            cboDataType.Enabled = true;
            txtSize.Enabled = true;

        }          
        private void tleSave_Click(object sender, EventArgs e)
        {
            myDB.TableDefs.Append(myTB);
            MetroMessageBox.Show(this, "Table saved with success!", "Saved table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearAll();
            tleSaveTbl.Enabled = false;
        }

        private void tleAddField_Click(object sender, EventArgs e)
        {

            //Check if name is already in use
            foreach (Field afield in myTB.Fields)
            {
                if (afield.Name == txtField.Text)
                {
                    MetroMessageBox.Show(this, "Field not created, name already in use!", "Create Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtField.Clear();
                    txtField.Focus();
                    return;
                }                  
            }                     

            //Defining dataype selected
            DataTypeEnum dtype = DataTypeEnum.dbInteger;//Integer by default
            if (cboDataType.SelectedItem.ToString() == "AutoNumber")
            {
                dtype = DataTypeEnum.dbLong;      
            }
            else
            {
                foreach (DataTypeEnum item in Enum.GetValues(typeof(DataTypeEnum)))
                {
                    if (cboDataType.SelectedItem.ToString() == item.ToString().Substring(2))
                    {
                        dtype = item;
                    }
                }
            }                                               
   
            //Create an item to be shown in the listview
            ListViewItem field = new ListViewItem();
            field.SubItems.Add(txtField.Text);
            field.SubItems.Add(cboDataType.Text);

            //If selected datatype is Text, takes the size
            if (!string.IsNullOrEmpty(txtSize.Text))
            {
                field.SubItems.Add(txtSize.Text);
                myFL = myTB.CreateField(txtField.Text, dtype, Convert.ToInt32(txtSize.Text));
            }
            //if not, does not consider size
            else
            {
                myFL = myTB.CreateField(txtField.Text, dtype);
                if (cboDataType.Text == "AutoNumber")
                {
                    myFL.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;          
                }
            }
            //Add item created to the listview
            lvwTable.Items.Add(field);
            
            //Append field to the table
            myTB.Fields.Append(myFL);       
            clearAftCreate();
            tleSaveTbl.Enabled = true;
        }                                      
        private void tleIndex_Click(object sender, EventArgs e)
        {
            //Loop to check if name is alrady in use

            for (int i = 0; i < myTB.Indexes.Count; i++)
            {
                if (txtIndex.Text == myTB.Indexes[i].Name.ToString())
                {
                   MetroMessageBox.Show(this, " Index name already in use, please enter a new one!", "Create Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIndex.Clear();
                    txtIndex.Focus();
                    return;
                }                                  
            }

            //Creating index
            myInd = myTB.CreateIndex(txtIndex.Text);
            myFL = myInd.CreateField(txtSelIndex.Text);
            ((IndexFields)myInd.Fields).Append(myFL);                  
            myInd.Primary = tglPrim.Checked;      

            //Create icon to be displayed in case index is primary key
            ImageList ilist = new ImageList();                         
            Image pkIcon = Image.FromFile("data/Key_10px.png");           
            ilist.Images.Add(pkIcon);
            lvwTable.SmallImageList = ilist;

            ListViewItem indListItem = new ListViewItem(txtIndex.Text);
            indListItem.SubItems.Add(txtSelIndex.Text);

            //If is primary, changes the other index to keep only one primary key

            if (myInd.Primary == true)
            {
               for(int i = 0; i < myTB.Indexes.Count; i++)
                {                        
                    if (myTB.Indexes[i].Name != myInd.Name)
                    {                                 
                        myTB.Indexes[i].Primary = false;
                    }                                                                 
                }
                foreach (ListViewItem fieldItem in lvwTable.Items)
                {
                    fieldItem.ImageIndex = -1;
                }
                foreach (ListViewItem indexItem in lvwIndex.Items)
                {
                    indexItem.SubItems[2].Text = "No";
                }                      
                lvwTable.SelectedItems[0].ImageIndex = 0;
                indListItem.SubItems.Add("Yes");
            }
            else
            {
                indListItem.SubItems.Add("No");
            }
            lvwIndex.Items.Add(indListItem);
            myTB.Indexes.Append(myInd);       
            clearAftCreate();                 
        }

        //Clicking in the table sends the field name selected to the index creation section
        private void lvwTable_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (lvwTable.SelectedItems != null)
            {
                ListViewItem item = lvwTable.SelectedItems[0];
                txtSelIndex.Text = item.SubItems[1].Text;                        
            }
            if (!string.IsNullOrEmpty(txtIndex.Text) && !string.IsNullOrEmpty(txtSelIndex.Text))
            {
                tleAddIndex.Enabled = true;
            }
        }

        //Confirmation to close the form
        private void tleExit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to close this screen?", "Closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                myDB.Close();
                this.Close();
            }
        }                     

        //Check if Index name changed, if valid name and Field selected from table, enable to Add index
        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIndex.Text) && !string.IsNullOrEmpty(txtSelIndex.Text))
            {
                tleAddIndex.Enabled = true;
            }
        }
        //Check if Field name changed, if valid name and Field selected from table, enable to Add Field
        private void txtField_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtField.Text) || string.IsNullOrEmpty(cboDataType.Text))
            {
                tleAddField.Enabled = false;
                return;
            }
            tleAddField.Enabled = true;
        }                             

        private void txtIndex_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIndex.Text) && !string.IsNullOrEmpty(txtSelIndex.Text))
            {
                tleAddIndex.Enabled = true;
            }
        }                
    
        //Remove selected field
        private void tleRemField_Click(object sender, EventArgs e)
        {
            if (lvwTable.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Please select the field to remove.", "Remove Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            myFL = myTB.Fields[lvwTable.SelectedItems[0].SubItems[1].Text];

            if ((MetroMessageBox.Show(this, "Are you sure you want to remove the field " + myFL.Name + " ?", "Remove Field", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
)
            {
                bool found = false;
                
                //If field is indexed, remove index
                foreach (Index myInd in myTB.Indexes)
                {
                    foreach (Field myFLInd in (IndexFields)myInd.Fields)
                    {
                        if (myFLInd.Name == myFL.Name)
                        {
                            found = true;
                        }
                    }
                    if (found)
                    {
                        myTB.Indexes.Delete(myInd.Name);
                        foreach (ListViewItem listInd in lvwIndex.Items)
                        {
                            if (listInd.SubItems[1].Text == myFL.Name)
                            {
                                lvwIndex.Items.Remove(listInd);
                            }
                        }
                    }
                    myTB.Fields.Delete(lvwTable.SelectedItems[0].SubItems[1].Text);
                    lvwTable.Items.Remove(lvwTable.SelectedItems[0]);
                }
            }
         }

        //Cancel Field tile
        private void tleCancelF_Click(object sender, EventArgs e)
        {
            clearAftCreate();
        }
        //Cancel Index tile   
        private void tleCancelI_Click(object sender, EventArgs e)
        {
            clearAftCreate(); 
        }
        //Cancel Table tile        
        private void tleCancelTbl_Click(object sender, EventArgs e)
        {
            clearAll();
        }
           
        //Remove selected index
        private void tleRemIndex_Click(object sender, EventArgs e)
        {

            if (lvwIndex.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Please select the index to remove.", "Remove Index", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((MetroMessageBox.Show(this, "Are you sure you want to remove the index " + lvwIndex.SelectedItems[0].SubItems[1].Text + " ?", "Remove Index", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                foreach (ListViewItem listInd in lvwIndex.SelectedItems)
                {                           
                    foreach (ListViewItem fieldItem in lvwTable.Items)
                    {
                        if (myTB.Indexes[listInd.SubItems[0].Text].Primary && (listInd.SubItems[1].Text == fieldItem.SubItems[1].Text) )
                        {
                            fieldItem.ImageIndex = -1;
                        }                                                          
                    }
                    myTB.Indexes.Delete(listInd.SubItems[0].Text);
                    lvwIndex.Items.Remove(listInd);
                }      
            }
        }         

        private void txtField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
