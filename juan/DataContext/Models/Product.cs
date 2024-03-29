using juan.DataContext.Models.BaseModels;

namespace juan.DataContext.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public int DiscountPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
