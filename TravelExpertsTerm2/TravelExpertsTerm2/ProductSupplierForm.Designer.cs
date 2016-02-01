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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbProd = new MetroFramework.Controls.MetroComboBox();
            this.cmbSupplier = new MetroFramework.Controls.MetroComboBox();
            this.dgvProdSup = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSup)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProd
            // 
            this.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.ItemHeight = 24;
            this.cmbProd.Location = new System.Drawing.Point(241, 420);
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
            this.cmbSupplier.Location = new System.Drawing.Point(12, 420);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(223, 30);
            this.cmbSupplier.TabIndex = 1;
            this.cmbSupplier.UseSelectable = true;
            // 
            // dgvProdSup
            // 
            this.dgvProdSup.AllowUserToAddRows = false;
            this.dgvProdSup.AllowUserToDeleteRows = false;
            this.dgvProdSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdSup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdSup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProdSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdSup.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.btnAdd.Location = new System.Drawing.Point(505, 413);
            this.btnAdd.MaximumSize = new System.Drawing.Size(111, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 29);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Location = new System.Drawing.Point(647, 414);
            this.btnDelete.MaximumSize = new System.Drawing.Size(111, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 29);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            // 
            // ProductSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 750);
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
    }
}