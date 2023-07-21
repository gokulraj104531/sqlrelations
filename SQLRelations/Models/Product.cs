namespace SQLRelations.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }= string.Empty;

        public double Price { get; set; } 
        public Category Category { get; set; }
        public int CategoryID { get;set; }

        public Size Size { get; set; }
    }
}
