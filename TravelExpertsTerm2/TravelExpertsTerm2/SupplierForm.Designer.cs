namespace TravelExpertsTerm2
{
    partial class MainForm
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
            this.lstSuppliers = new System.Windows.Forms.ListView();
            this.SupplierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlAddUpdate = new System.Windows.Forms.Panel();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnAddNewSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.pnlAddUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SupplierID,
            this.SupName});
            this.lstSuppliers.Location = new System.Drawing.Point(576, 12);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(382, 510);
            this.lstSuppliers.TabIndex = 0;
            this.lstSuppliers.UseCompatibleStateImageBehavior = false;
            this.lstSuppliers.View = System.Windows.Forms.View.Details;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // SupplierID
            // 
            this.SupplierID.Text = "Supplier ID";
            this.SupplierID.Width = 81;
            // 
            // SupName
            // 
            this.SupName.Text = "Supplier Name";
            this.SupName.Width = 300;
            // 
            // pnlAddUpdate
            // 
            this.pnlAddUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAddUpdate.Controls.Add(this.txtSupName);
            this.pnlAddUpdate.Controls.Add(this.txtSupplierID);
            this.pnlAddUpdate.Controls.Add(this.lblSupName);
            this.pnlAddUpdate.Controls.Add(this.lblSupplierID);
            this.pnlAddUpdate.Controls.Add(this.btnCancel);
            this.pnlAddUpdate.Controls.Add(this.btnAdd);
            this.pnlAddUpdate.Location = new System.Drawing.Point(60, 283);
            this.pnlAddUpdate.Name = "pnlAddUpdate";
            this.pnlAddUpdate.Size = new System.Drawing.Size(328, 129);
            this.pnlAddUpdate.TabIndex = 1;
            this.pnlAddUpdate.Visible = false;
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(125, 39);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(180, 22);
            this.txtSupName.TabIndex = 6;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(125, 11);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(180, 22);
            this.txtSupplierID.TabIndex = 5;
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(13, 46);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(101, 17);
            this.lblSupName.TabIndex = 3;
            this.lblSupName.Text = "Supplier Name";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(13, 11);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(73, 17);
            this.lblSupplierID.TabIndex = 2;
            this.lblSupplierID.Text = "SupplierID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search for Selected Supplier";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(58, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Location = new System.Drawing.Point(86, 159);
            this.btnUpdateSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(188, 28);
            this.btnUpdateSelected.TabIndex = 9;
            this.btnUpdateSelected.Text = "&Update Selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.Location = new System.Drawing.Point(86, 123);
            this.btnAddNewSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.Size = new System.Drawing.Size(188, 28);
            this.btnAddNewSupplier.TabIndex = 8;
            this.btnAddNewSupplier.Text = "&Add New Supplier";
            this.btnAddNewSupplier.UseVisualStyleBackColor = true;
            this.btnAddNewSupplier.Click += new System.EventHandler(this.btnAddNewSupplier_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(88, 195);
            this.btnDeleteSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(188, 28);
            this.btnDeleteSelected.TabIndex = 10;
            this.btnDeleteSelected.Text = "&Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 564);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.btnAddNewSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlAddUpdate);
            this.Controls.Add(this.lstSuppliers);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlAddUpdate.ResumeLayout(false);
            this.pnlAddUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSuppliers;
        private System.Windows.Forms.Panel pnlAddUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader SupplierID;
        private System.Windows.Forms.ColumnHeader SupName;
        public System.Windows.Forms.TextBox txtSupName;
        public System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnAddNewSupplier;
        private System.Windows.Forms.Button btnDeleteSelected;
    }
}

