namespace TravelExpertsTerm2
{
    partial class ProductSupplierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbProd = new MetroFramework.Controls.MetroComboBox();
            this.cmbSupplier = new MetroFramework.Controls.MetroComboBox();
            this.dgvProdSup = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnFindSupplier = new MetroFramework.Controls.MetroButton();
            this.btnFindProduct = new MetroFramework.Controls.MetroButton();
            this.btnViewAll = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSup)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProd
            // 
            this.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.ItemHeight = 24;
            this.cmbProd.Location = new System.Drawing.Point(308, 413);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(229, 30);
            this.cmbProd.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmbProd.TabIndex = 0;
            this.cmbProd.UseSelectable = true;
            this.cmbProd.UseStyleColors = true;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.ItemHeight = 24;
            this.cmbSupplier.Location = new System.Drawing.Point(30, 413);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(223, 30);
            this.cmbSupplier.TabIndex = 1;
            this.cmbSupplier.UseSelectable = true;
            // 
            // dgvProdSup
            // 
            this.dgvProdSup.AllowUserToAddRows = false;
            this.dgvProdSup.AllowUserToDeleteRows = false;
            this.dgvProdSup.AllowUserToResizeRows = false;
            this.dgvProdSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdSup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdSup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdSup.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdSup.Location = new System.Drawing.Point(1, 3);
            this.dgvProdSup.MaximumSize = new System.Drawing.Size(1050, 645);
            this.dgvProdSup.MultiSelect = false;
            this.dgvProdSup.Name = "dgvProdSup";
            this.dgvProdSup.ReadOnly = true;
            this.dgvProdSup.RowTemplate.Height = 24;
            this.dgvProdSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdSup.Size = new System.Drawing.Size(836, 404);
            this.dgvProdSup.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdd.Location = new System.Drawing.Point(599, 413);
            this.btnAdd.MaximumSize = new System.Drawing.Size(111, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 29);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Location = new System.Drawing.Point(726, 413);
            this.btnDelete.MaximumSize = new System.Drawing.Size(111, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 29);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFindSupplier
            // 
            this.btnFindSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFindSupplier.Location = new System.Drawing.Point(78, 449);
            this.btnFindSupplier.Name = "btnFindSupplier";
            this.btnFindSupplier.Size = new System.Drawing.Size(132, 23);
            this.btnFindSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnFindSupplier.TabIndex = 5;
            this.btnFindSupplier.Text = "Find Supplier";
            this.btnFindSupplier.UseCustomBackColor = true;
            this.btnFindSupplier.UseSelectable = true;
            this.btnFindSupplier.UseStyleColors = true;
            this.btnFindSupplier.Click += new System.EventHandler(this.btnFindSupplier_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFindProduct.Location = new System.Drawing.Point(362, 449);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(132, 23);
            this.btnFindProduct.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnFindProduct.TabIndex = 6;
            this.btnFindProduct.Text = "Find Product";
            this.btnFindProduct.UseCustomBackColor = true;
            this.btnFindProduct.UseSelectable = true;
            this.btnFindProduct.UseStyleColors = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnViewAll.Location = new System.Drawing.Point(247, 449);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnViewAll.TabIndex = 7;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseCustomBackColor = true;
            this.btnViewAll.UseSelectable = true;
            this.btnViewAll.UseStyleColors = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // ProductSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 504);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnFindProduct);
            this.Controls.Add(this.btnFindSupplier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProdSup);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductSupplierForm";
            this.Load += new System.EventHandler(this.ProductSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbProd;
        private MetroFramework.Controls.MetroComboBox cmbSupplier;
        private System.Windows.Forms.DataGridView dgvProdSup;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnFindSupplier;
        private MetroFramework.Controls.MetroButton btnFindProduct;
        private MetroFramework.Controls.MetroButton btnViewAll;
    }
}