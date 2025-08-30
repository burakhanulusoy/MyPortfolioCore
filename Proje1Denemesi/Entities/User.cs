using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class User
    {

        public int UserId { get; set; }


        [Required(ErrorMessage ="Bu alan boş bırakılamz")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamz")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamz")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamz")]
        public string Password { get; set; }




    }
}
