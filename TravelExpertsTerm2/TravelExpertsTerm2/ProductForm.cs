using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelDatabase;
using TravelDatabase.EntityData;
using System.Data.SqlClient;

namespace TravelExpertsTerm2
{
    public partial class ProductForm : Form
    {
        // a global attribute
        public Product prod;
        public ProductForm()
        {
            InitializeComponent();
            //hiding the Product Panel as the form intializes
            pnlProduct1.Visible = false;
            lsvProduct.Visible = true;

        }
        // a private method to load information to the combobox
        private void LoadComboxProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = ProductDB.GetProducts();
                cboProducts1.DataSource = products;
                cboProducts1.DisplayMember = "Name";
                cboProducts1.ValueMember = "ProductId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        // method to accept form inputs
        private void acceptRecord(Product product)
        {
            product.ProductId = Convert.ToInt32(txtProductId1.Text);
            product.Name = txtProductName1.Text;
        }

        // method load invent
        private void ProductForm_Load(object sender, EventArgs e)
        {
           this.LoadComboxProducts();
        }
        // Combobox selected Value change method. to trigger event of the comboBox selection 
        private void cboProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            lsvProduct.Items.Clear();
            lsvProduct.FullRowSelect = true;
            lsvProduct.GridLines = true;
            //adding product Item to the listview
            ListViewItem prodItem = new ListViewItem(cboProducts1.SelectedValue.ToString());
            prodItem.SubItems.Add(cboProducts1.GetItemText(cboProducts1.SelectedItem));
            lsvProduct.Items.Add(prodItem);
        }
        // method to make the panel product visible to allow for entry data
        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlProduct1.Visible = true;
            lsvProduct.Visible = false;
            btnSave1.Text = "Add";
            txtProductId1.Text = "";
            txtProductName1.Text = "";
            txtProductId1.Enabled = true;
        }
        // method to insert and update records to the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            int num;
            if (btnSave1.Text == "Add")
            {
                try
                {
                    if (txtProductId1.Text == "")
                    {
                        MessageBox.Show("Please Enter Product Id", "Product Id");
                        txtProductId1.Focus();
                    }
                    else if (!Int32.TryParse(txtProductId1.Text, out num) && num <= 0)
                    {
                        MessageBox.Show("Please Enter a valid Number", "Entry_Error");
                        txtProductId1.Focus();
                    }
                    else if (txtProductName1.Text == "")
                    {
                        MessageBox.Show("Please Enter Product Name", "Product Name");
                        txtProductName1.Focus();
                    }
                    else
                    {
                        prod = new Product();
                        prod.ProductId = Convert.ToInt32(txtProductId1.Text);
                        prod.Name = txtProductName1.Text;
                        ProductDB.AddEntity(prod);
                        LoadComboxProducts();
                        MessageBox.Show("New Product Added Successfully");
                    }
                }
                catch (SqlException ex)
                {
                    string errorMsg = "A record exist with the same Product Id";
                    MessageBox.Show(errorMsg, ex.Message); 
                }
            }
            // update record
            else if (btnSave1.Text == "Update")
            {

                Product newProduct = new Product();
                newProduct.ProductId = prod.ProductId;
                acceptRecord(newProduct);
                try
                {
                    if (!ProductDB.UpdateProduct(prod, newProduct))
                    {
                        MessageBox.Show("Another Product Exist with similar records", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        prod = newProduct;
                        LoadComboxProducts();
                        MessageBox.Show("Product record Updated successfully", "Update Record");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
        // method to hide the product panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlProduct1.Visible = false;
            lsvProduct.Visible = true;
            lblSelectProd.Visible = true;
            cboProducts1.Visible = true;
            btnDeleteProduct1.Enabled = true;
            b1tnProduct.Enabled = true;
            txtProductId1.Enabled = true;
        }
        // method to make the product panel visible 
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            btnSave1.Text = "Update";
            lsvProduct.Visible = false;
            pnlProduct1.Visible = true;
            lblSelectProd.Visible = false;
            cboProducts1.Visible = false;
            btnDeleteProduct1.Enabled = false;
            b1tnProduct.Enabled = false;
            txtProductId1.Text = cboProducts1.SelectedValue.ToString();
            txtProductName1.Text = cboProducts1.GetItemText(cboProducts1.SelectedItem);
            txtProductId1.Enabled = false;
            prod = new Product();
            prod.ProductId = Convert.ToInt32(txtProductId1.Text);
            prod.Name = txtProductName1.Text;
            acceptRecord(prod);
        }
        // method to delete record
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialogResult = MessageBox.Show("Are you sure you want to Delete this Record",
                "Delete Record", MessageBoxButtons.YesNo);
            if (deleteDialogResult == DialogResult.Yes)
            {
                Product prod = new Product();
                prod.ProductId = Convert.ToInt32(cboProducts1.SelectedValue.ToString());
                if (ProductDB.checkIfItExist(prod))
                {
                    MessageBox.Show("You cannot delete this record please select another record to delete","Delete Record");
                }
                else
                {
                    ProductDB.DeleteEntity(prod);
                    LoadComboxProducts();
                    MessageBox.Show("record deleted successfully");
                }
            }
            else if (deleteDialogResult == DialogResult.No)
            {
                
            }
            

        }
    }
}
