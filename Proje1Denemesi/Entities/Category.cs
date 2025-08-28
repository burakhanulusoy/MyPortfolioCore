namespace Proje1Denemesi.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IList<Project> Projects { get; set; }

    }
}
