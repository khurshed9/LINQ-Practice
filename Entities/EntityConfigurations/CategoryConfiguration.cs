using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice.DataContext;

namespace Practice.Entities.EntityConfigurations;

public class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories");
        builder.HasData(InitialData.Categories());
    }
}