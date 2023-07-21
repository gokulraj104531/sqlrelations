namespace SQLRelations.Models
{
    public class Category
    {
        public int id { get; set; }

        public string name { get; set; }=string.Empty;

        public List<Product> Products { get; set; }
    }
}
