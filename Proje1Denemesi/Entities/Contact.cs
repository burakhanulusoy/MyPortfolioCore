using System.ComponentModel.DataAnnotations;

namespace Proje1Denemesi.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }


        [Required(ErrorMessage ="Telefon Numarası boş bırakılama!")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "E-Mail Adresi boş bırakılama!")]

        public string Email { get; set; }
        public string MapUrl { get; set; }


        [Required(ErrorMessage ="Adres boş bırakılama!")]
        public string Adress { get; set; }

    }
}
