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
    public partial class ReportingForm : Form
    {
        GymDbContext _context;
        public ReportingForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            FillCmbxCustomer();
            FillDgvReport();
        }

      public void  FillCmbxCustomer()
        {
           List<Customer> customs = _context.Customers.ToList();
            foreach (var item in customs)
            {
                if (item.Status == true)
                {
                    cmbReporting.Items.Add(item.Firstname + " " + item.Lastname);
                }
            }
        }

        public void FillDgvReport()
        {
            dgvReporting.Rows.Clear();

            List<Payment> payments = _context.Payments.Include("Customer").ToList();
            foreach (var item in payments)
            {
                if (item.Status == true)
                {
                    dgvReporting.Rows.Add(
                        item.Customer.Firstname + " " + item.Customer.Lastname,
                        item.PackageEntryQuantity,
                        item.CreatedAt.AddMonths(1));
                    if (item.PackageEntryQuantity == 0 || item.CreatedAt.AddMonths(1)<DateTime.Now)
                    {
                        dgvReporting.Rows[dgvReporting.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void TnSaveReporting_Click(object sender, EventArgs e)
        {
            string customFullname = cmbReporting.SelectedItem.ToString();
            Customer customer = _context.Customers.FirstOrDefault(c => c.Firstname + " " + c.Lastname == customFullname);
         
            Payment payment = _context.Payments.FirstOrDefault(p=>p.CustomerId == customer.Id);
            if (payment == null)
            {
                return;
            }
            if (payment.PackageEntryQuantity - 1<0)
            {
                MessageBox.Show("Entry limits expired");
                return;
            }
            payment.PackageEntryQuantity -= 1;
            _context.SaveChanges();
            FillDgvReport();
            cmbReporting.SelectedIndex = -1;
        }
    }
}
