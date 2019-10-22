using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int EntryQuantity { get; set; }
        public bool Status { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
