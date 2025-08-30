using System.ComponentModel.DataAnnotations;

namespace Proje1Denemesi.Entities
{
    public class Expreince
    {
        public int ExpreinceId { get; set; }
        [Required(ErrorMessage = "Başlık adı boş geçilemez")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Başlangıç yılı boş geçilemez")]
        public int   StartYear { get; set; }
        public string? EndYear { get; set; }
        //eger yazılmazsa devam ediyor anlamına gelir 

        [Required(ErrorMessage ="Şirket adı boş geçilemez")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Şehir adı boş geçilemez")]
        public string City   { get; set; }
        [Required(ErrorMessage = "Açıklama kısmı boş geçilemez")]
        public string Description { get; set; }



    }
}
