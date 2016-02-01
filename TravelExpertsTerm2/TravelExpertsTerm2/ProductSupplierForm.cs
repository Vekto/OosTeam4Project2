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

namespace TravelExpertsTerm2
{
    public partial class ProductSupplierForm : Form
    {
        public ProductSupplierForm()
        {
            InitializeComponent();
        }

        private void ProductSupplierForm_Load(object sender, EventArgs e)
        {
            List<Supplier> suppliers = SupplierDB.GetSuppliers();
            List<ProductSupplier> ProdSups = ProductSupplierDB.GetProductSuppliers();
            BindingSource source = new BindingSource();
            var data = from ps in ProdSups
                select new {ID = ps.ProductSupplierId,Product = ps.Product.Name,Supplier = ps.Supplier.Name, ps.FullName};
            source.DataSource = data;
             cmbSupplier.DataSource = suppliers;
            cmbProd.DataSource = suppliers;
            dgvProdSup.DataSource = source;
            dgvProdSup.Columns[0].Width = 80;
        }
    }
}
