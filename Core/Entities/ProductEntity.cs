using Core.Entities.Abstract;

namespace Core.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; };
    public double Price { get; set; };
    public string Description { get; set; };
}