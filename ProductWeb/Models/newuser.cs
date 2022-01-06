using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProductWeb.Models;

namespace ProductWeb.Models
{
    public class newuser
    {
        [Key]
        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ใช้")]
        public string username { get; set; }
        
        [Required(ErrorMessage = "กรุณาป้อนอีเมล")]
        [EmailAddress(ErrorMessage = "อีเมลของคุณไม่ถูกต้อง กรุณากรอกใหม่อีกคร้ง")]
        public string useremail{ get; set; }
        
        [Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์ให้ครบ 10 ตัว")]
        public string userphone { get; set; }
        
        [Required(ErrorMessage = "กรุณากรอกรหัสผ่าน")]
        [StringLength(12, MinimumLength = 8 ,ErrorMessage = "กรุณารหัสผ่านอย่างน้อย 8 ตัว เเละ ไม่เกิน 12 ตัว")]
        public string password { get; set; }
        
        [Compare("password",ErrorMessage = "รหัสผ่านไม่ตรงกัน กรุณากรอกใหม่อีกครั้ง")]
        [Required(ErrorMessage = "กรุณากรอกรหัสผ่านเพื่อยืนยันอีกครั้ง")]
        public string passwordagain { get; set; }

    }
}
