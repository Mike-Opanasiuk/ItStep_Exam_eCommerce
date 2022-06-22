using Core.Entities.Abstract;

namespace Core.Entities;

public class ProductEntity : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; }
}