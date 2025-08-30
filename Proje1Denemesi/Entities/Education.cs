using System.ComponentModel.DataAnnotations;


namespace Proje1Denemesi.Entities
{
    public class Education
    {
        public int EducationId { get; set; }
        [Required(ErrorMessage ="Okul adı boş bırakılamaz!")]
        public string SchoolName { get; set; }
        public int StartYear { get; set; }
        
        public string? EndYear { get; set; }
        [Required(ErrorMessage = "Statü boş bırakılamaz!")]
        public string Department { get; set; }
        public string? Description { get; set; }



    }
}
