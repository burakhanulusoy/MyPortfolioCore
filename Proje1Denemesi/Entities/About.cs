using System.ComponentModel.DataAnnotations;

namespace Proje1Denemesi.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        [Required(ErrorMessage ="Bu kısım boş bırakılamaz !")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]
        public string ImgUrl { get; set; }
        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]
        public DateTime BitrhDate { get; set; }
        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]

        public string City { get; set; }
        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]

        public string Phone { get; set; }
        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]

        public string WebSite { get; set; }
        public string Graduation { get; set; }

        [Required(ErrorMessage = "Bu kısım boş bırakılamaz !")]
        public bool IsAvailable { get; set; }


    }
}
