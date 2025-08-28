namespace Proje1Denemesi.Entities
{
    public class Expreince
    {
        public int ExpreinceId { get; set; }
        public string Title { get; set; }
        public int   StartYear { get; set; }
        public string? EndYear { get; set; }
        //eger yazılmazsa devam ediyor anlamına gelir 
        public string Company { get; set; }
        public string City   { get; set; }
        public string Description { get; set; }



    }
}
