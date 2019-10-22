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
    public partial class MenuItemForm : Form
    {
        private readonly GymDbContext _context;
        Models.MenuItem selectedMenuItem;
        public MenuItemForm()
        {
            InitializeComponent();
            _context = new GymDbContext();
            selectedMenuItem = new Models.MenuItem();
        }

        private void BtnSaveMenuitem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameMenuItem.Text.Trim()) || 
                string.IsNullOrEmpty(txtPriceMenuItem.Text.Trim()))
            {
                MessageBox.Show("Fill All Fields, Please");
                return;
            }

            Models.MenuItem menuItem = new Models.MenuItem();
            menuItem.Price = decimal.Parse(txtPriceMenuItem.Text.Trim());
            menuItem.Name = txtNameMenuItem.Text.Trim();
            menuItem.Status = true;
            _context.MenuItems.Add(menuItem);
            _context.SaveChanges();

            MessageBox.Show($"{menuItem.Name} {menuItem.Price}azn added");

            txtNameMenuItem.Text = "";
            txtPriceMenuItem.Text = "";

            FillMenuItems();
        }

        public void FillMenuItems()
        {
            
            dgvMenuItem.Rows.Clear();
            foreach (Models.MenuItem item in _context.MenuItems.ToList())
            {
                if (item.Status == true)
                {
                    dgvMenuItem.Rows.Add(item.Id, item.Name, item.Price);
                }
            }

            Reset();
        }

        private void MenuItemForm_Load(object sender, EventArgs e)
        {
            FillMenuItems();
        }
        
        private void BtnUpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedMenuItem == null)
            {
                return;
            }

            selectedMenuItem.Name = txtNameMenuItem.Text;
            selectedMenuItem.Price =Convert.ToDecimal(txtPriceMenuItem.Text);

            _context.SaveChanges();
            FillMenuItems();
            
        }

        private void DgvMenuItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           int selectedItemId =(int) dgvMenuItem.Rows[e.RowIndex].Cells[0].Value;
           selectedMenuItem = _context.MenuItems.FirstOrDefault(m => m.Id == selectedItemId);

            txtNameMenuItem.Text = selectedMenuItem.Name;
            txtPriceMenuItem.Text = selectedMenuItem.Price.ToString();
        }

        private void Reset()
        {
            txtNameMenuItem.Text = "";
            txtPriceMenuItem.Text = "";

            selectedMenuItem = null;
        }

        private void BtnDeleteMenuitem_Click(object sender, EventArgs e)
        {
            if (selectedMenuItem == null)
            {
                return;
            }

            selectedMenuItem.Status = false;
            _context.SaveChanges();
            FillMenuItems();
        }
    }
}
