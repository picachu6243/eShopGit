using eShop.Databases.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShop.Databases.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasColumnType("nText");
            builder.Property(x => x.CoverImg).HasMaxLength(500);
            //Khoa ngoai
            builder.HasOne(x=>x.ProductCategory)
                .WithMany()
                .IsRequired(false)
                .HasForeignKey(x=>x.CategoryId);
        }
    }
}
