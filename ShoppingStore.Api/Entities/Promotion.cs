using System.Text.Json.Serialization;

namespace ShoppingStore.Api.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
       [JsonIgnore]
       public ICollection<Customer> Customer { get; set; }
       [JsonIgnore]
       public ICollection<Product> Product { get; set; }
    }


}
