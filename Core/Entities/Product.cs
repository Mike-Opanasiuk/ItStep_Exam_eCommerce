using Core.Entities.Abstract;

namespace Core.Entities;

public class Product : BaseEntity
{
    public string Name;
    public double Price;
    public string Description;
}