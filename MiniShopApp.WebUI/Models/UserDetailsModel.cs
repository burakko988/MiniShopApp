using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class UserDetailsModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage ="First Name zorunludur!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name zorunludur!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "User Name zorunludur!")]
        //Buraya bizim kullanıcı adı koşullarımıza uygun bir validationu yapın
        //İPUCU--> REGEX
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email zorunludur!")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Lütfen geçerli bir email adresi giriniz!")]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }
    }
}
