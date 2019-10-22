using GymApplication.DAL;
using GymApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApplication.Forms
{
    public partial class Dashboard : Form
    {
        private readonly GymDbContext _context;

        public Dashboard()
        {
            InitializeComponent();
            _context = new GymDbContext();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FillPayment();
        }

        

        private void BtnCustomerDashbrd_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.FormClosed += new FormClosedEventHandler(FillPayment);
            customerForm.ShowDialog();
        }

        private void BtnPackageDashbrd_Click(object sender, EventArgs e)
        {
            PackageForm packageForm = new PackageForm();
            packageForm.FormClosed += new FormClosedEventHandler(FillPayment);
            packageForm.ShowDialog();
        }

        private void BtnPaymentDashbrd_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.FormClosed += new FormClosedEventHandler(FillPayment);
            paymentForm.ShowDialog();
        }

        private void BtnMenuItemDashbrd_Click(object sender, EventArgs e)
        {
            MenuItemForm menuItemForm = new MenuItemForm();
            menuItemForm.FormClosed += new FormClosedEventHandler(FillPayment);
            menuItemForm.ShowDialog();
        }

        private void BtnMenuOrderDashboard_Click(object sender, EventArgs e)
        {
            MenuOrderForm menuOrderForm = new MenuOrderForm();
            menuOrderForm.FormClosed += new FormClosedEventHandler(FillPayment);
            menuOrderForm.ShowDialog();
        }

        private void BtnReportingDashboard_Click(object sender, EventArgs e)
        {
            ReportingForm reportingForm = new ReportingForm();
            reportingForm.FormClosed += new FormClosedEventHandler(FillPayment);
            reportingForm.ShowDialog();
        }

        public void FillPayment()
        {
            dgvDashboard.Rows.Clear();

            List<Payment> payments = _context.Payments.Include("Customer").Include("Package").ToList();
            foreach (Payment item in payments)
            {
                if (item.Status == true)
                {
                    dgvDashboard.Rows.Add(item.Id, 
                        item.Customer.Firstname, 
                        item.Customer.Lastname, item.Package.Name, 
                        item.Package.Price, 
                        item.PackageEntryQuantity,
                        item.CreatedAt
                        );

                    if (item.PackageEntryQuantity == 0)
                    {
                        dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if(item.PackageEntryQuantity > 0)
                    {
                        dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        public void FillPayment(object sender, EventArgs e)
        {
            dgvDashboard.Rows.Clear();

            List<Payment> payments = _context.Payments.Include("Customer").Include("Package").ToList();
            foreach (Payment item in payments)
            {
                if (item.Status == true)
                {
                    dgvDashboard.Rows.Add(item.Id,
                        item.Customer.Firstname,
                        item.Customer.Lastname, item.Package.Name,
                        item.Package.Price,
                        item.PackageEntryQuantity,
                        item.CreatedAt
                        );

                    if (item.PackageEntryQuantity == 0)
                    {
                        dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (item.PackageEntryQuantity > 0)
                    {
                        dgvDashboard.Rows[dgvDashboard.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure  to close the form?", "Dashboard Form", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
