using Core.Entities.Abstract;

namespace Core.Entities;

public class CategoryEntity : BaseEntity
{
    public CategoryEntity()
    {
        Children = new HashSet<CategoryEntity>();
        Products = new HashSet<ProductEntity>();
    }
    public string Title { get; set; }
    public string Image { get; set; }
    public Guid? ParentId { get; set; }

    public virtual CategoryEntity Parent { get; set; }
    public virtual ICollection<CategoryEntity> Children { get; set; }
    public virtual ICollection<ProductEntity> Products { get; set; }
}