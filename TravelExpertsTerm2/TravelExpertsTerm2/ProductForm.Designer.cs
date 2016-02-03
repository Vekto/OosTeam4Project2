namespace TravelExpertsTerm2
{
    partial class ProductForm
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
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblSelectProd = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lsvProduct = new System.Windows.Forms.ListView();
            this.cProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(163, 27);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(201, 24);
            this.cboProducts.TabIndex = 1;
            this.cboProducts.SelectedValueChanged += new System.EventHandler(this.cboProducts_SelectedValueChanged);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(163, 71);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(192, 33);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Create New Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.btnCancel);
            this.pnlProduct.Controls.Add(this.btnSave);
            this.pnlProduct.Controls.Add(this.txtProductName);
            this.pnlProduct.Controls.Add(this.lblProductName);
            this.pnlProduct.Controls.Add(this.txtProductId);
            this.pnlProduct.Controls.Add(this.lblProductId);
            this.pnlProduct.Location = new System.Drawing.Point(25, 189);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(339, 186);
            this.pnlProduct.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(126, 63);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(161, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(14, 69);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(106, 17);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name :";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(126, 17);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(161, 22);
            this.txtProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(14, 22);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(80, 17);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product Id :";
            // 
            // lblSelectProd
            // 
            this.lblSelectProd.AutoSize = true;
            this.lblSelectProd.Location = new System.Drawing.Point(22, 27);
            this.lblSelectProd.Name = "lblSelectProd";
            this.lblSelectProd.Size = new System.Drawing.Size(108, 17);
            this.lblSelectProd.TabIndex = 4;
            this.lblSelectProd.Text = "Select Product :";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(163, 110);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(192, 32);
            this.btnUpdateProduct.TabIndex = 5;
            this.btnUpdateProduct.Text = "Update Product ";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(163, 148);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(192, 29);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lsvProduct
            // 
            this.lsvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cProductId,
            this.cProductName});
            this.lsvProduct.Location = new System.Drawing.Point(406, 27);
            this.lsvProduct.Name = "lsvProduct";
            this.lsvProduct.Size = new System.Drawing.Size(341, 150);
            this.lsvProduct.TabIndex = 7;
            this.lsvProduct.UseCompatibleStateImageBehavior = false;
            this.lsvProduct.View = System.Windows.Forms.View.Details;
            // 
            // cProductId
            // 
            this.cProductId.Text = "Product ID";
            this.cProductId.Width = 161;
            // 
            // cProductName
            // 
            this.cProductName.Text = "Product Name";
            this.cProductName.Width = 176;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 562);
            this.Controls.Add(this.lsvProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.lblSelectProd);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.cboProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblSelectProd;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.ListView lsvProduct;
        private System.Windows.Forms.ColumnHeader cProductId;
        private System.Windows.Forms.ColumnHeader cProductName;
    }
}