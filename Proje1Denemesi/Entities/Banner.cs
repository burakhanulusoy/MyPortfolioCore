using System.ComponentModel.DataAnnotations;

namespace Proje1Denemesi.Entities
{
    public class Banner
    {
        public int BannerId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz!")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CoverImgUrl { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz!")]
        public string Title { get; set; }


    }
}
