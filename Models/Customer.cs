using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
        public bool Status { get; set; }
        public List<Payment> Payments { get; set; }
        public List<MenuOrder> MenuOrders { get; set; }
    }
}
