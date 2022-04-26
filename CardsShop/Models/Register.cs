using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardsShop.Models
{
    public class Register
    {
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreleriniz uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
