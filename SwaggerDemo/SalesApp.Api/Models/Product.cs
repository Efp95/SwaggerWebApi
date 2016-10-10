namespace SalesApp.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Price Price { get; set; }
    }

    public class Price
    {
        public decimal Amount { get; set; }
    }
}