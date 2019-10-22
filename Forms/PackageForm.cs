using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApplication.Models;
using GymApplication.DAL;

namespace GymApplication.Forms
{
    public partial class PackageForm : Form
    {
        private readonly GymDbContext _context;
        Package selectedPackageItem;
        public PackageForm()

        {
            InitializeComponent();
            _context = new GymDbContext();
            selectedPackageItem = new Package();
        }

        private void BtnSavePackage_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNamePackage.Text.Trim()) ||
               string.IsNullOrEmpty(txtEntryPackage.Text.Trim()) ||
               string.IsNullOrEmpty(txtPricePackage.Text.Trim())
               )
            {
                MessageBox.Show("Fill All Fields, Please");
                return;
            }

            Package package = new Package();
            package.Name = txtNamePackage.Text.Trim();
            package.Price = Convert.ToDecimal(txtPricePackage.Text.Trim());
            package.EntryQuantity = Convert.ToInt32(txtEntryPackage.Text.Trim());

            package.Status = chbxPackage.Checked;

            _context.Packages.Add(package);
            _context.SaveChanges();

            MessageBox.Show($"{package.Name} {package.Price}azn package added");

            txtNamePackage.Text = "";
            txtPricePackage.Text = "";
            txtEntryPackage.Text = "";

            FillPackages();
        }

        public void FillPackages()
        {

            dgvPackage.Rows.Clear();
            foreach (Package item in _context.Packages.ToList())
            {
                if (item.Status == true)
                {
                    dgvPackage.Rows.Add(item.Id, item.Name, item.Price, item.EntryQuantity);
                }
            }

            Reset();
        }

        private void PackageForm_Load(object sender, EventArgs e)
        {
            FillPackages();
        }

        private void BtnUpdatePackage_Click(object sender, EventArgs e)
        {
            if (selectedPackageItem == null)
            {
                return;
            }

            selectedPackageItem.Name = txtNamePackage.Text;
            selectedPackageItem.Price = Convert.ToDecimal(txtPricePackage.Text);
            selectedPackageItem.EntryQuantity = Convert.ToInt32(txtEntryPackage.Text);


            _context.SaveChanges();
            FillPackages();
        }

        private void Reset()
        {
            txtNamePackage.Text = "";
            txtPricePackage.Text = "";
            txtEntryPackage.Text = "";

            selectedPackageItem = null;
        }

        private void DgvPackage_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedItemId = (int)dgvPackage.Rows[e.RowIndex].Cells[0].Value;
            selectedPackageItem = _context.Packages.FirstOrDefault(m => m.Id == selectedItemId);

            txtNamePackage.Text = selectedPackageItem.Name;
            txtPricePackage.Text = selectedPackageItem.Price.ToString();
            txtEntryPackage.Text = selectedPackageItem.EntryQuantity.ToString();
        }

        private void BtnDeletePackage_Click(object sender, EventArgs e)
        {
            if (selectedPackageItem == null)
            {
                return;
            }

            selectedPackageItem.Status = false;
            _context.SaveChanges();
            FillPackages();
        }
    }
}
