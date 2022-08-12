namespace ShoppingStore.Api.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<Promotion> Promotion { get; set; }
    }
}
