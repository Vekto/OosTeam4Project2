// Author: Team 4 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using JetBrains.Annotations;
using TravelDatabase;

namespace TravelExpertsTerm2
{
    public partial class PackagesForm : Form
    {
        private readonly BindingList<Package> _Packages = new BindingList<Package>();
        private bool _EditMode;
        private bool _CreateNew; // used to track whether the user clicked "New" or "Edit"

        private Package SelectedPackage
        {
            get { return (Package) PackageSelectorComboBox.SelectedItem; }
            set { PackageSelectorComboBox.SelectedItem = value; }
        }

        #region Constructor

        public PackagesForm()
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
            SetEditMode(false);
            PackageSelectorComboBox.Enabled = true;

            // get packagees, reporting errors
            IEnumerable<Package> packages;
            if (!TryReport(Database.Packages.GetEntitiesWithChildren, out packages)) return;

            // add and display them
            foreach (var package in packages)
                _Packages.Add(package);
            ShowPackage(SelectedPackage);
        }

        private void PackageSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPackage(SelectedPackage);
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
                var package = ParsePackage();
                // TODO: Validate business object here, show error & return if invalid

                if (_CreateNew)
                {
                    int id;
                    if (!TryReport(() => Database.Packages.AddEntity(package), out id)) return;

                    if (id < 0) // negative means item wasn't added
                    {
                        Error("Could not add item.");
                        return;
                    }

                    package.PackageId = id; // save actual id before adding/displaying
                    _Packages.Add(package);
                    SelectedPackage = package;
                }
                else // updating package
                {
                    package.PackageId = SelectedPackage.PackageId;
                    // TODO: Call update
                }

                SetEditMode(false); // turn off edit mode on success, else return
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

        private static void Error(string message)
        {
            MessageBox.Show(message, @"Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        private static bool TryReport<TReturn>(Func<TReturn> func, out TReturn result)
        {
            try
            {
                result = func();
                return true;
            }
            catch (Exception e)
            {
                Error($"An exception of type {e.GetType().Name} has occurred. {e.Message}");
                result = default(TReturn);
                return false;
            }
        }

        #endregion

    }
}
