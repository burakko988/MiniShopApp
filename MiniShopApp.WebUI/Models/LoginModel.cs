using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş bırakılamaz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
