using System.Collections.Generic;

namespace WebApplication6.Entities
{
    public class ProductGroup
    {
        public int ProductGroupId { get; set; }
        public string GroupName { get; set; }

        public List<Product> Products { get; set; }
    }
}
