namespace WebApplication6.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public int ProductGroupId { get; set; }
        public ProductGroup Group { get; set; }
    }
}
