using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApplication.DAL;
using GymApplication.Models;

namespace GymApplication.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly GymDbContext _context;
        Payment selectedPayment;

        public PaymentForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            selectedPayment = new Payment();
        }
        public void FillPayment()
        {
            dgvPaymentForm.Rows.Clear();

            List<Payment> payments = _context.Payments.ToList();
            foreach (Payment item in payments)
            {
                if (item.Status == true)
                {
                    dgvPaymentForm.Rows.Add(item.Id, 
                        item.Price, 
                        item.CreatedAt, 
                        item.Customer.Firstname + " " + item.Customer.Lastname, 
                        item.Package.Name + item.Package.Price, 
                        item.PackageEntryQuantity);
                }
            }
            Reset();
        }
        public void Reset()
        {
            txtPricePayment.Text = "";
            txtCreatedAtPayment.Text = "";
            cmbxCustPayment.Text = "";
            cmbxPackPayment.Text = " ";

            selectedPayment = null;
        }
        private void BtnSavePayment_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                MessageBox.Show("Fill All Fields, Please");
                return;
            }

            Payment payment = new Payment();
            payment.Price = decimal.Parse(txtPricePayment.Text);
            payment.CreatedAt = Convert.ToDateTime(txtCreatedAtPayment.Text);

            string customFullname = cmbxCustPayment.SelectedItem.ToString();
            Customer customer = _context.Customers.FirstOrDefault(c => c.Firstname + " " + c.Lastname == customFullname);
            payment.Customer = customer;

            string packageName = cmbxPackPayment.SelectedItem.ToString();
            Package package = _context.Packages.FirstOrDefault(p => p.Name + " " + p.Price == packageName);
            payment.Package = package;

            payment.PackageEntryQuantity = (int)quantity.Value;
            payment.Status = true;

            _context.Payments.Add(payment);
            _context.SaveChanges();
            FillPayment();
            
        }

        public bool Validation()
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(txtPricePayment.Text.Trim()) &&
               !string.IsNullOrEmpty(txtCreatedAtPayment.Text.Trim()) &&
               (cmbxCustPayment.SelectedIndex >= 0) &&
               (cmbxPackPayment.SelectedIndex >= 0))
            {
                isValid = true;
            }

            if (!string.IsNullOrEmpty(txtCreatedAtPayment.Text.Trim()))
            {
                DateTime date;
                bool isDate = DateTime.TryParse(txtCreatedAtPayment.Text, out date);
                if (isDate != true)
                {
                    MessageBox.Show("Please, fullfill correct format of the date {yyy.MM.dd}");
                    return false;
                }
            }
            return isValid;
        }

        public void FillCmbxCustomer()
        {
            cmbxCustPayment.Items.Clear();
            foreach (var item in _context.Customers.ToList())
            {
                string cumbcust = item.Firstname + " " + item.Lastname;
                cmbxCustPayment.Items.Add(cumbcust);
            }
        }

        public void FillCmbxPackage()
        {
            cmbxPackPayment.Items.Clear();
            foreach (var item in _context.Packages.ToList())
            {
                string cumbpack = item.Name + " " + item.Price + " azn";
                cmbxPackPayment.Items.Add(cumbpack);
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            FillCmbxPackage();
            FillCmbxCustomer();
            FillPayment();
        }

        private void DgvPaymentForm_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvPaymentForm.Rows[e.RowIndex].Cells[0].Value;
            selectedPayment = _context.Payments.FirstOrDefault(p => p.Id == id);
            txtPricePayment.Text = selectedPayment.Price.ToString();
            txtCreatedAtPayment.Text = selectedPayment.CreatedAt.ToString();

            Customer customer = _context.Customers.FirstOrDefault(b => b.Id == selectedPayment.CustomerId);
            cmbxCustPayment.SelectedItem = customer.Firstname + " " + customer.Lastname;

            Package package = _context.Packages.FirstOrDefault(p => p.Id == selectedPayment.PackageId);
            cmbxPackPayment.SelectedItem = package.Name + " " + package.Price;

            quantity.Value = selectedPayment.PackageEntryQuantity;
        }

        private void BtnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                MessageBox.Show("Fill all fields, please");
                return;
            }
            selectedPayment.Price = Convert.ToDecimal(txtPricePayment.Text);
            selectedPayment.CreatedAt = Convert.ToDateTime(txtCreatedAtPayment.Text);

            string custpayment = cmbxCustPayment.SelectedItem.ToString();
            Customer customer = _context.Customers.FirstOrDefault(c => c.Firstname + " " + c.Lastname == custpayment);

            string packpayment = cmbxPackPayment.SelectedItem.ToString();
            Package package = _context.Packages.FirstOrDefault(p => p.Name + " " + p.Price == packpayment);

            selectedPayment.Customer = customer;
            selectedPayment.Package = package;
            selectedPayment.PackageEntryQuantity = (int)quantity.Value;

            _context.SaveChanges();

            FillPayment();

        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to close the form?", "Payment Form", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnDeletePayment_Click(object sender, EventArgs e)
        {
            if (selectedPayment == null)
            {
                return;
            }

            selectedPayment.Status = false;
            _context.SaveChanges();
            FillPayment();
        }
    }
}
