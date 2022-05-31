namespace Infrastructure.UnitOfWork;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}