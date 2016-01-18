using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelDatabase;
using TravelDatabase.EntityData;

namespace TravelExpertsTerm2
{
    public partial class MainForm : Form
    {
        public string selectedProduct = "";

        public MainForm()
        {
            InitializeComponent();
        }
        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Supplier> suppliersList = SupplierDB.GetSuppliers(); //creates supplier list to pass to updateListView()
            updateListView(suppliersList);
        }
        
        //SEARCH FUNCTIONALITY
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Supplier> suppliersList = SupplierDB.GetSuppliers();  //create list of Supplier objects from DB
            List<Supplier> searchResults = new List<Supplier>();  //create new list of Supplier for search results

            foreach (Supplier supplier in suppliersList)
            {
                if (supplier.SupplierID.ToString().Contains(txtSearch.Text.ToUpper())) //if there is a match
                {
                    searchResults.Add(supplier); //add to search results
                }
            }
            updateListView(searchResults);  //display search results
        }

       
       //selecting items in list view
        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedProduct = lstSuppliers.Items[lstSuppliers.SelectedIndices[0]].Text.Trim(); //store selected supplier id
            }
            catch
            {
                MessageBox.Show("Failed to select item.");
            }
        }

       
        //Call add function
        private void btnSave_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            Supplier supplier = new Supplier();
            supplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
            supplier.SupName = txtSupName.Text;

            try
            {
                if (SupplierDB.AddSupplier(supplier))
                {
                    MessageBox.Show("Supplier added successfully.");
                    updateListView(SupplierDB.GetSuppliers());
                    clearForm();
                }
                else
                {
                    MessageBox.Show("Supplier not added successfully.");
                }
            }
            catch(SqlException ex)
            {
                if(ex.Message.StartsWith("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Supplier with this ID already exists. Enter unique ID.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            pnlAddUpdate.Visible = true;
            btnAdd.Text = "Add";
            selectedProduct = "";
        }

        #endregion

        #region Methods
        public void clearForm()
        {
            txtSupplierID.Text = "";
            txtSupName.Text = "";            
        }

        public void updateListView(List<Supplier> suppliersList) //populate list view with list of products
        {
            lstSuppliers.Items.Clear();
            int i = 0;
            foreach (Supplier supplier in suppliersList)
            {
                lstSuppliers.Items.Add(supplier.SupplierID.ToString());
                lstSuppliers.Items[i].SubItems.Add(supplier.SupName);
                i++;
            }
        }


        #endregion

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            
                //try
                //{
                    
                    if (lstSuppliers.SelectedItems.Count == 1)
                    {

                selectedProduct = lstSuppliers.Items[lstSuppliers.SelectedIndices[0]].Text.Trim(); //store selected supplier id



                //confirm that user wants to delete
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                     

                        if (SupplierDB.DeleteSupplier(Convert.ToInt32(selectedProduct)))
                        {
                            //if delete is successful, display message and update list view
                            MessageBox.Show("Delete successful!");
                            updateListView(SupplierDB.GetSuppliers());
                            clearForm();
                        }
                        else
                        {
                            //delete failed, display message
                            MessageBox.Show("Delete was not successful.");
                        }
                    }                    
                    else if (result == DialogResult.No) //if user confirms they do not want to delete, display cancel message
                    {
                        MessageBox.Show("Delete cancelled");
                    }
            }
            else
            {
                MessageBox.Show("Please select item to delete");
            }                               
        }


    }           
}



