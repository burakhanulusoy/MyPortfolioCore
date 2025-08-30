using System.ComponentModel.DataAnnotations;

namespace Proje1Denemesi.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }

        [Required(ErrorMessage ="Boş bırakılamaz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş bırakılamaz!")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Boş bırakılamaz!")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Boş bırakılamaz!")]
        public string Title { get; set; } 
        [Required(ErrorMessage ="Boş bırakılamaz!")]
        public int Review { get; set; }

    }
}
