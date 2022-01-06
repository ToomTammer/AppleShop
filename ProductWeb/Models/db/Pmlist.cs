using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProductWeb.Models.db
{
    public partial class Pmlist
    {
        [Key]
        public int PaymentId { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ใช้")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนอีเมล")]
        [EmailAddress(ErrorMessage = "อีเมลของคุณไม่ถูกต้อง กรุณากรอกใหม่อีกคร้ง")]
        public string Email { get; set; }
        [Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์อย่างน้อย 4 ตัว")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ใช้")]
        public string Address { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนจำนวนสินค้าทั้งหมด")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนราคารวม")]
        public int Price { get; set; }
        [Required(ErrorMessage = "กรุณาเลือกวันกดชำระ")]
        public DateTime Paymentdate { get; set; }
    }
}
