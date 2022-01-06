using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductWeb.Models.db
{
    public partial class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public DateTime PaymentDay { get; set; }
    }

  
}
