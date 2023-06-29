using ChloeRestaurant.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ChloeRestaurant.Models;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChloeRestaurant.Areas.Identity.Data;

public class ChloeRestaurantContext : IdentityDbContext<ChloeRestaurantUser>
{
    public ChloeRestaurantContext(DbContextOptions<ChloeRestaurantContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ChloeRestaurantUserEntityConfiguration());
    }

    public class ChloeRestaurantUserEntityConfiguration : IEntityTypeConfiguration<ChloeRestaurantUser>
    {
        public void Configure(EntityTypeBuilder<ChloeRestaurantUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }

    public DbSet<ChloeRestaurant.Models.Customer> Customer { get; set; } = default!;

    public DbSet<ChloeRestaurant.Models.Food> Food { get; set; } = default!;

    public DbSet<ChloeRestaurant.Models.Order> Order { get; set; } = default!;
}
