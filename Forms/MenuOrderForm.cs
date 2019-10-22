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
    public partial class MenuOrderForm : Form
    {
        private readonly GymDbContext _context;
        MenuOrder selectedItemOrder;
        decimal Total = 0;
        List<MenuOrder> orderitems;
        Customer selectedcustomer;
        MenuOrder selectedMenu;
        public MenuOrderForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            selectedItemOrder = new MenuOrder();
            orderitems = new List<MenuOrder>();
            selectedMenu = new MenuOrder();
        }

        private void BtnSaveMenuorder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numUpQuantity.Text.Trim()) ||
                string.IsNullOrEmpty(cmbxCustomerIdMenuorder.Text.Trim()) ||
                string.IsNullOrEmpty(cmbMenuitemMenuorder.Text.Trim())
                )
            {
                MessageBox.Show("Fill All Fields, Please");
                return;
            }

            MenuOrder menuOrder = new MenuOrder();
            string customFullname = cmbxCustomerIdMenuorder.SelectedItem.ToString();
            Customer customer = _context.Customers.FirstOrDefault(c => c.Firstname + " " + c.Lastname == customFullname);

            string selectedMenuItem = cmbMenuitemMenuorder.SelectedItem.ToString();
            Models.MenuItem menuItem = _context.MenuItems.FirstOrDefault(m => m.Name + " " + m.Price + " azn" == selectedMenuItem);

            menuOrder.CustomerId = customer.Id;
            menuOrder.Customer = customer;
            menuOrder.MenuItemId = menuItem.Id;
            menuOrder.MenuItem = menuItem;
            menuOrder.Quantity = Convert.ToInt32(numUpQuantity.Text.Trim());
            menuOrder.Status = true;

            orderitems.Add(menuOrder);

            FillGridView();
            //_context.MenuOrders.Add(menuOrder);
            //_context.SaveChanges();

        }

        private void MenuOrderForm_Load(object sender, EventArgs e)
        {
            FillCmbxMenuItems();
            FillCmbxCustomers();
        }

        public void FillCmbxMenuItems()
        {
            cmbMenuitemMenuorder.Items.Clear();
            foreach (var item in _context.MenuItems.ToList())
            {
                string cmbitem = item.Name + " " + item.Price + " azn";
                cmbMenuitemMenuorder.Items.Add(cmbitem);
            }
        }

        public void FillCmbxCustomers()
        {
            cmbxCustomerIdMenuorder.Items.Clear();
            foreach (var item in _context.Customers.ToList())
            {
                string cmbcustomer = item.Firstname + " " + item.Lastname;
                cmbxCustomerIdMenuorder.Items.Add(cmbcustomer);
            }
        }

        public void FillGridView()
        {
            dgvMenuOrder.Rows.Clear();
            foreach (var item in orderitems)
            {
                if (item.Status == true)
                {
                    dgvMenuOrder.Rows.Add(item.Id,
                        item.Quantity,
                        item.Customer.Firstname + " " + item.Customer.Lastname,
                        item.MenuItem.Name + " " + item.MenuItem.Price + " azn",
                        item.MenuItem.Price * item.Quantity);
                }
                Total += item.MenuItem.Price * item.Quantity;
            }
            MenuTotal.Text = Total.ToString("#.00") + " Azn";
            Reset();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _context.MenuOrders.AddRange(orderitems);
            _context.SaveChanges();
            Reset();
            dgvMenuOrder.Rows.Clear();
        }

        private void BtnUpdateMenuorder_Click(object sender, EventArgs e)
        {
            if (selectedItemOrder == null)
            {
                return;
            }
            string cumbcost = cmbxCustomerIdMenuorder.SelectedItem.ToString();
            selectedcustomer = _context.Customers.FirstOrDefault(c => c.Firstname + " " + c.Lastname == cumbcost);

            string menu = cmbMenuitemMenuorder.SelectedItem.ToString();
            Models.MenuItem menuItem = _context.MenuItems.FirstOrDefault(m => m.Name + " " + m.Price + " azn" == menu);

            selectedItemOrder.Customer = selectedcustomer;
            selectedItemOrder.MenuItem = menuItem;

            _context.SaveChanges();

            FillGridView();
        }

        private void DgvMenuOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvMenuOrder.Rows[e.RowIndex].Cells[0].Value;
            selectedItemOrder = orderitems.FirstOrDefault(a => a.Id == id);
            Customer customer = _context.Customers.FirstOrDefault(b => b.Id == selectedItemOrder.CustomerId);
            cmbxCustomerIdMenuorder.SelectedItem = customer.Firstname + " " + customer.Lastname;

            Models.MenuItem menuItem = _context.MenuItems.FirstOrDefault(m => m.Id == selectedItemOrder.MenuItemId);
            cmbMenuitemMenuorder.SelectedItem = menuItem.Name + " " + menuItem.Price + " azn";
        }

        private void Reset()
        {
            cmbMenuitemMenuorder.SelectedIndex = -1;
            cmbxCustomerIdMenuorder.SelectedIndex = -1;
            numUpQuantity.Value = 0;
            MenuTotal.Text = "";
        }

        private void BtnDeleteMenuorder_Click(object sender, EventArgs e)
        {
            if (selectedItemOrder != null)
            {
                selectedItemOrder.Status = false;

                FillGridView();
            }
        }
    }
}