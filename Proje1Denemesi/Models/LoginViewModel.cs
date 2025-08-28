using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class LoginViewModel
    {


        [Required(ErrorMessage ="Kullanıcı adı boş bırakılamaz")]
        public string UserName { get; set; }



        [Required(ErrorMessage = "Şifre  boş bırakılamaz")]
        public string Password { get; set; }

    }
}
