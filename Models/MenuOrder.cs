﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class MenuOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int MenuItemId { get; set; }
        public bool Status { get; set; }

    }
}
