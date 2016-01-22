using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JetBrains.Annotations;
using TravelDatabase;

namespace TravelExpertsTerm2
{
    public partial class PackagesPrototypeForm : Form
    {
        private readonly BindingList<Package> _Packages = new BindingList<Package>();
        private bool _EditMode;
        private bool _CreateNew; // used to track whether the user clicked "New" or "Edit"

        private Package SelectedPackage => (Package)PackageSelectorComboBox.SelectedItem;

        #region Constructor

        public PackagesPrototypeForm()
        {
            InitializeComponent();

            // Additional Initialization
            PackageSelectorComboBox.DataSource = _Packages;
            PackageSelectorComboBox.DisplayMember = nameof(Package.Name);
            PackageSelectorComboBox.ValueMember = nameof(Package.PackageId);
        }

        #endregion

        #region Event Handlers

        private void PackagesPrototypeForm_Load(object sender, EventArgs e)
        {
            _Packages.Clear();
            foreach (var package in Database.Packages.GetEntitiesWithChildren())
                _Packages.Add(package);
            ShowPackage((Package)PackageSelectorComboBox.SelectedItem);

            SetEditMode(false);
            PackageSelectorComboBox.Enabled = true;
        }

        private void PackageSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPackage((Package)PackageSelectorComboBox.SelectedItem);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(@"This will permanently delete this package. Continue?",
                @"Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2))
            {
                throw new NotImplementedException();
            }
        }

        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            if (_EditMode) // clicked Cancel
            {
                SetEditMode(false);
                ShowPackage((Package)PackageSelectorComboBox.SelectedItem);
            }
            else // clicked Edit
            {
                _CreateNew = false; // existing item should be updated, not created
                SetEditMode(true);
            }
        }

        private void NewSaveButton_Click(object sender, EventArgs e)
        {
            if (_EditMode) // clicked Save
            {
                SetEditMode(false);

                var package = ParsePackage();
                // TODO: Validate business object here, show error & return if invalid

                if (_CreateNew)
                {
                    // TODO: Call save. If successful, add item to _Packages & select
                }
                else
                {
                    package.PackageId = SelectedPackage.PackageId;
                    // TODO: Call update
                }

                // TODO: Show any errors that occurred during update/insert
                throw new NotImplementedException();
            }
            else // clicked New
            {
                _CreateNew = true; // new item should be added to the database
                SetEditMode(true);
                ShowPackage(null); // make fields blank
            }
        }

        #endregion

        #region Private Methods

        private void ShowPackage([CanBeNull] Package package)
        {
            NameTextBox.Text = package?.Name;
            DescriptionTextBox.Text = package?.Description;
            StartDateTimePicker.Value = package?.StartDate ?? DateTime.Today;
            EndDateTimePicker.Value = package?.EndDate ?? DateTime.Today + TimeSpan.FromDays(1);

            var basePrice = (package?.BasePrice ?? 0);
            var agencyCommission = (package?.AgencyCommission ?? 0);
            BasePriceTextBox.Text = basePrice.ToString("C2");
            AgencyCommissionTextBox.Text = agencyCommission.ToString("C2");
            TotalLabel.Text = (basePrice + agencyCommission).ToString("C2");
        }

        private Package ParsePackage()
        {
            decimal basePrice, agencyCommission;
            return new Package
            {
                Name = NameTextBox.Text,
                StartDate = StartDateTimePicker.Value,
                EndDate = EndDateTimePicker.Value,
                Description = DescriptionTextBox.Text,
                BasePrice = decimal.TryParse(
                    BasePriceTextBox.Text.Replace("$", string.Empty), out basePrice)
                    ? basePrice : decimal.MinValue,
                AgencyCommission = decimal.TryParse(
                    AgencyCommissionTextBox.Text.Replace("$", string.Empty), out agencyCommission)
                    ? agencyCommission : decimal.MinValue,
            };
        }

        private void SetReadonlyFields(bool @readonly)
        {
            NameTextBox.ReadOnly = @readonly;
            DescriptionTextBox.ReadOnly = @readonly;
            BasePriceTextBox.ReadOnly = @readonly;
            AgencyCommissionTextBox.ReadOnly = @readonly;
            StartDateTimePicker.Enabled = !@readonly;
            EndDateTimePicker.Enabled = !@readonly;
        }

        private void SetEditMode(bool enabled)
        {
            _EditMode = enabled;

            if (_EditMode)
            {
                NewSaveButton.Text = @"Save";
                EditCancelButton.Text = @"Cancel";
                DeleteButton.Enabled = false;
                PackageSelectorComboBox.Enabled = false;
                SetReadonlyFields(false);
            }
            else
            {
                NewSaveButton.Text = @"New";
                EditCancelButton.Text = @"Edit";
                DeleteButton.Enabled = true;
                PackageSelectorComboBox.Enabled = true;
                SetReadonlyFields(true);
            }
        }

        #endregion

    }
}
