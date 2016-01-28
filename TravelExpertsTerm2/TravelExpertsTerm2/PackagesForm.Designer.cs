namespace TravelExpertsTerm2
{
    partial class PackagesForm
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
            this.PackageSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.AgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.EditCancelButton = new System.Windows.Forms.Button();
            this.NewSaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LinkedProductSuppliersListBox = new System.Windows.Forms.ListBox();
            this.OtherProductSuppliersListBox = new System.Windows.Forms.ListBox();
            this.OtherProductSuppliersLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PackageSelectorComboBox
            // 
            this.PackageSelectorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PackageSelectorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PackageSelectorComboBox.FormattingEnabled = true;
            this.PackageSelectorComboBox.Location = new System.Drawing.Point(263, 119);
            this.PackageSelectorComboBox.MaxDropDownItems = 16;
            this.PackageSelectorComboBox.Name = "PackageSelectorComboBox";
            this.PackageSelectorComboBox.Size = new System.Drawing.Size(200, 24);
            this.PackageSelectorComboBox.TabIndex = 0;
            this.PackageSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.PackageSelectorComboBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(263, 173);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(263, 257);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(200, 88);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(263, 351);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.BasePriceTextBox.TabIndex = 5;
            // 
            // AgencyCommissionTextBox
            // 
            this.AgencyCommissionTextBox.Location = new System.Drawing.Point(263, 379);
            this.AgencyCommissionTextBox.Name = "AgencyCommissionTextBox";
            this.AgencyCommissionTextBox.Size = new System.Drawing.Size(200, 22);
            this.AgencyCommissionTextBox.TabIndex = 6;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(263, 201);
            this.StartDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.StartDateTimePicker.TabIndex = 7;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(263, 229);
            this.EndDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.EndDateTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Agency Commission";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(260, 410);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 16;
            this.TotalLabel.Text = "Total";
            // 
            // EditCancelButton
            // 
            this.EditCancelButton.Location = new System.Drawing.Point(307, 454);
            this.EditCancelButton.Name = "EditCancelButton";
            this.EditCancelButton.Size = new System.Drawing.Size(75, 23);
            this.EditCancelButton.TabIndex = 17;
            this.EditCancelButton.Text = "Edit/Cancel";
            this.EditCancelButton.UseVisualStyleBackColor = true;
            this.EditCancelButton.Click += new System.EventHandler(this.EditCancelButton_Click);
            // 
            // NewSaveButton
            // 
            this.NewSaveButton.Location = new System.Drawing.Point(388, 454);
            this.NewSaveButton.Name = "NewSaveButton";
            this.NewSaveButton.Size = new System.Drawing.Size(75, 23);
            this.NewSaveButton.TabIndex = 18;
            this.NewSaveButton.Text = "New/Save";
            this.NewSaveButton.UseVisualStyleBackColor = true;
            this.NewSaveButton.Click += new System.EventHandler(this.NewSaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(126, 454);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LinkedProductSuppliersListBox
            // 
            this.LinkedProductSuppliersListBox.FormattingEnabled = true;
            this.LinkedProductSuppliersListBox.ItemHeight = 16;
            this.LinkedProductSuppliersListBox.Location = new System.Drawing.Point(478, 173);
            this.LinkedProductSuppliersListBox.Name = "LinkedProductSuppliersListBox";
            this.LinkedProductSuppliersListBox.Size = new System.Drawing.Size(266, 228);
            this.LinkedProductSuppliersListBox.Sorted = true;
            this.LinkedProductSuppliersListBox.TabIndex = 20;
            this.LinkedProductSuppliersListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LinkedProductSuppliersListBox_MouseDoubleClick);
            // 
            // OtherProductSuppliersListBox
            // 
            this.OtherProductSuppliersListBox.FormattingEnabled = true;
            this.OtherProductSuppliersListBox.ItemHeight = 16;
            this.OtherProductSuppliersListBox.Location = new System.Drawing.Point(808, 173);
            this.OtherProductSuppliersListBox.Name = "OtherProductSuppliersListBox";
            this.OtherProductSuppliersListBox.Size = new System.Drawing.Size(266, 228);
            this.OtherProductSuppliersListBox.Sorted = true;
            this.OtherProductSuppliersListBox.TabIndex = 21;
            this.OtherProductSuppliersListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OtherProductSuppliersListBox_MouseDoubleClick);
            // 
            // OtherProductSuppliersLabel
            // 
            this.OtherProductSuppliersLabel.AutoSize = true;
            this.OtherProductSuppliersLabel.Location = new System.Drawing.Point(750, 271);
            this.OtherProductSuppliersLabel.Name = "OtherProductSuppliersLabel";
            this.OtherProductSuppliersLabel.Size = new System.Drawing.Size(52, 17);
            this.OtherProductSuppliersLabel.TabIndex = 22;
            this.OtherProductSuppliersLabel.Text = "<<   >>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Product Suppliers";
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 690);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OtherProductSuppliersLabel);
            this.Controls.Add(this.OtherProductSuppliersListBox);
            this.Controls.Add(this.LinkedProductSuppliersListBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewSaveButton);
            this.Controls.Add(this.EditCancelButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.AgencyCommissionTextBox);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PackageSelectorComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PackagesForm";
            this.Text = "PackagesPrototype";
            this.Load += new System.EventHandler(this.PackagesPrototypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PackageSelectorComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.TextBox AgencyCommissionTextBox;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button EditCancelButton;
        private System.Windows.Forms.Button NewSaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox LinkedProductSuppliersListBox;
        private System.Windows.Forms.ListBox OtherProductSuppliersListBox;
        private System.Windows.Forms.Label OtherProductSuppliersLabel;
        private System.Windows.Forms.Label label9;
    }
}