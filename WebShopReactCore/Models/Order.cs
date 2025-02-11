﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PayDate { get; set; }
        public decimal OrderTotal { get; set; }

        public string userEmail { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
