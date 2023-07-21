using System.Text.Json.Serialization;

namespace SQLRelations.Models
{
    public class Size
    {
        public int Id { get; set; }

        public string sizeName { get; set; }
        //[JsonIgnore]
        public Product Product { get; set; }

        public int ProductId { get; set; }



    }
}
