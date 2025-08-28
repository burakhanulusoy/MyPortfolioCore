using System.ComponentModel.DataAnnotations;

namespace Proje1Denemesi.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }

        [MinLength(3,ErrorMessage ="Proje Adı En Az 3 Karakterli Olmalıdır!")]
        [MaxLength(50,ErrorMessage ="Proje Adı En Fazla 50 Karakterli Olmalıdır!")]
        [Required(ErrorMessage ="Proje Adı Boş Geçilemez!")]
        public string ProjectName { get; set; }


        [Required(ErrorMessage ="Proje Açıklaması Boş Geçilemez!")]
        [MinLength(10,ErrorMessage ="Proje Açıklaması En Az 10 Karakterli Olmalıdır!")]
        public string Desciption { get; set; }

        [Required(ErrorMessage ="Proje Resim Linki Boş Geçilemez!")]
        public string ImgUrl { get; set; }
        [Required(ErrorMessage ="Proje GitHub Linki Boş Geçilemez!")]
        public string GitHubUrl { get; set; }




        public Category? Category { get; set; }
        public int CategoryId  { get; set; }






    }
}
