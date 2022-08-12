using System.Text.Json.Serialization;

namespace ShoppingStore.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
        public ICollection<Promotion> Promotion { get; set; }
    }
}
