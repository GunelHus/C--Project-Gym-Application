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
    public partial class CustomerForm : Form
    {
        private readonly GymDbContext _context;
        Customer selectedCustomer;

        public CustomerForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            selectedCustomer = new Customer();
        }

        private void BtnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomersFirstname.Text.Trim()) ||
                string.IsNullOrEmpty(txtCustomerLastname.Text.Trim()) ||
                string.IsNullOrEmpty((txtCustomerPhone.Text.Trim()))
                )
            {
                MessageBox.Show("Fill All Fields");
            }

            Customer custom = new Customer();
            custom.Firstname = txtCustomersFirstname.Text.Trim();
            custom.Lastname = txtCustomerLastname.Text.Trim();
            custom.Birthday = dtpBirthday.Value;
            custom.Phone =Convert.ToInt32(txtCustomerPhone.Text.Trim());
            custom.Status = true;
            _context.Customers.Add(custom);
            _context.SaveChanges();

            MessageBox.Show($"{custom.Firstname} {custom.Lastname} added to Customer List");

            txtCustomersFirstname.Text = "";
            txtCustomerLastname.Text = "";
            txtCustomerPhone.Text = "";

            FillCustomers();
        }
        
        public void FillCustomers()
        {
            dgvCustomer.Rows.Clear();
            foreach (Customer item in _context.Customers.ToList())
            {
                if (item.Status == true)
                {
                    dgvCustomer.Rows.Add(item.Id, item.Firstname, item.Lastname, item.Birthday, item.Phone);
                }
            }
            Reset();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillCustomers();
        }

        private void Reset()
        {
            txtCustomersFirstname.Text = "";
            txtCustomerLastname.Text = "";
            txtCustomerPhone.Text = "";

            selectedCustomer = null;
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                return;
            }
            selectedCustomer.Firstname = txtCustomersFirstname.Text;
            selectedCustomer.Lastname = txtCustomerLastname.Text;
            selectedCustomer.Birthday = dtpBirthday.Value;
            selectedCustomer.Phone = Convert.ToInt32(txtCustomerPhone.Text);

            _context.SaveChanges();
            FillCustomers();
        }

        private void DgvCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedItemID = (int)dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
            selectedCustomer = _context.Customers.FirstOrDefault(c => c.Id == selectedItemID);

            txtCustomersFirstname.Text = selectedCustomer.Firstname;
            txtCustomerLastname.Text = selectedCustomer.Lastname;
            dtpBirthday.Value = selectedCustomer.Birthday;
            txtCustomerPhone.Text = selectedCustomer.Phone.ToString();
            

        }

        private void BtnDeleetCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                return;
            }

            selectedCustomer.Status = false;
            _context.SaveChanges();
            FillCustomers();
        }
    }
}
