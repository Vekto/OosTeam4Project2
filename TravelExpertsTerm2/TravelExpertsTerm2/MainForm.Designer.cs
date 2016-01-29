using System.Drawing.Drawing2D;

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
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnProdSup = new MetroFramework.Controls.MetroButton();
            this.btnPackages = new MetroFramework.Controls.MetroButton();
            this.btnProducts = new MetroFramework.Controls.MetroButton();
            this.BtnSuppliers = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.btnProdSup);
            this.metroPanel1.Controls.Add(this.btnPackages);
            this.metroPanel1.Controls.Add(this.btnProducts);
            this.metroPanel1.Controls.Add(this.BtnSuppliers);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 14;
            this.metroPanel1.Location = new System.Drawing.Point(30, 83);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(187, 690);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 15;
            // 
            // btnProdSup
            // 
            this.btnProdSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnProdSup.BackgroundImage = global::TravelExpertsTerm2.Properties.Resources.ProdSup;
            this.btnProdSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProdSup.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProdSup.ForeColor = System.Drawing.Color.Black;
            this.btnProdSup.Highlight = true;
            this.btnProdSup.Location = new System.Drawing.Point(18, 184);
            this.btnProdSup.Name = "btnProdSup";
            this.btnProdSup.Size = new System.Drawing.Size(146, 146);
            this.btnProdSup.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnProdSup.TabIndex = 8;
            this.btnProdSup.Text = "Product Suppliers";
            this.btnProdSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdSup.UseCustomForeColor = true;
            this.btnProdSup.UseSelectable = true;
            this.btnProdSup.UseStyleColors = true;
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnPackages.BackgroundImage = global::TravelExpertsTerm2.Properties.Resources.Package3;
            this.btnPackages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPackages.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPackages.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPackages.Highlight = true;
            this.btnPackages.Location = new System.Drawing.Point(18, 13);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(146, 146);
            this.btnPackages.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnPackages.TabIndex = 7;
            this.btnPackages.Text = "Packages";
            this.btnPackages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPackages.UseCustomForeColor = true;
            this.btnPackages.UseSelectable = true;
            this.btnPackages.UseStyleColors = true;
            this.btnPackages.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnProducts.BackgroundImage = global::TravelExpertsTerm2.Properties.Resources.Products;
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProducts.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProducts.ForeColor = System.Drawing.Color.Black;
            this.btnProducts.Highlight = true;
            this.btnProducts.Location = new System.Drawing.Point(18, 353);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(146, 146);
            this.btnProducts.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseCustomForeColor = true;
            this.btnProducts.UseSelectable = true;
            this.btnProducts.UseStyleColors = true;
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSuppliers.BackgroundImage = global::TravelExpertsTerm2.Properties.Resources.Supplier;
            this.BtnSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSuppliers.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSuppliers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSuppliers.Highlight = true;
            this.BtnSuppliers.Location = new System.Drawing.Point(18, 533);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(146, 146);
            this.BtnSuppliers.Style = MetroFramework.MetroColorStyle.Brown;
            this.BtnSuppliers.TabIndex = 5;
            this.BtnSuppliers.Text = "Suppliers";
            this.BtnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSuppliers.UseCustomForeColor = true;
            this.BtnSuppliers.UseSelectable = true;
            this.BtnSuppliers.UseStyleColors = true;
            this.BtnSuppliers.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(217, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 690);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 808);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::TravelExpertsTerm2.Properties.Resources.TravelExpertLogo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(25, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 75);
            this.panel3.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Travel Experts";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton BtnSuppliers;
        private MetroFramework.Controls.MetroButton btnProducts;
        private MetroFramework.Controls.MetroButton btnPackages;
        private MetroFramework.Controls.MetroButton btnProdSup;
        private System.Windows.Forms.Panel panel3;
    }
}

