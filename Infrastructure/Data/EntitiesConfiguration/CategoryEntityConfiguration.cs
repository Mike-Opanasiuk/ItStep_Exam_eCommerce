using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntitiesConfiguration.Abstract;

public class CategoryEntityConfiguration : BaseEntityConfiguration<CategoryEntity>
{
    public override void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        base.Configure(builder);

        builder.HasIndex(pe => pe.Title).IsUnique();
        builder.Property(pe => pe.Title).IsRequired();

        builder.Property(pe => pe.Image).IsRequired();

        builder.HasMany(ce => ce.Products)
            .WithOne(pe => pe.Category)
            .HasForeignKey(pe => pe.CategoryId);
    }
}