using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class Payment
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Price { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Package Package { get; set; }
        public int PackageId { get; set; }
        public int PackageEntryQuantity { get; set; }
        public bool Status { get; set; }

    }
}
