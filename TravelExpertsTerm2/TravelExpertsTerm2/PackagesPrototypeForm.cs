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

            SetReadonlyFields(true);
            PackageSelectorComboBox.Enabled = true;
        }

        private void PackageSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPackage((Package)PackageSelectorComboBox.SelectedItem);
        }

        #endregion

        #region Private Methods

        private void ShowPackage([CanBeNull] Package package)
        {
            NameTextBox.Text = package?.Name;
            StartDateTimePicker.Value = package?.StartDate ?? DateTime.Today;
            EndDateTimePicker.Value = package?.EndDate ?? DateTime.Today + TimeSpan.FromDays(1);
            DescriptionTextBox.Text = package?.Description;

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

            if (@readonly)
            {
                StartDateTimePicker.MinDate = StartDateTimePicker.Value;
                StartDateTimePicker.MaxDate = StartDateTimePicker.Value;
                EndDateTimePicker.MinDate = EndDateTimePicker.Value;
                EndDateTimePicker.MaxDate = EndDateTimePicker.Value;
            }
            else
            {
                StartDateTimePicker.MinDate = new DateTime(2000, 1, 1);
                StartDateTimePicker.MaxDate = DateTime.MaxValue;
                EndDateTimePicker.MinDate = new DateTime(2000, 1, 1);
                EndDateTimePicker.MaxDate = DateTime.MaxValue;
            }
        }

        #endregion

    }
}
