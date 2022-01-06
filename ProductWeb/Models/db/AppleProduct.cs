using System;
using System.Collections.Generic;
namespace ProductWeb.Models.db
{
    public partial class AppleProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductPrice { get; set; }
        public byte[] ProductImage { get; set; }
    }
}
