using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ApplicationDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public virtual DbSet<ProductEntity> Products { get; set; }
}