using System.ComponentModel.DataAnnotations;

namespace Proje1Denemesi.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        [Required(ErrorMessage ="Boş bırakılamaz!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş bırakılamaz!")]
        public int Value { get; set; } // 1 to 10 scale

    }
}
