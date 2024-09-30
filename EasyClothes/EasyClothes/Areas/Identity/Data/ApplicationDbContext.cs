using EasyClothes.Areas.Identity.Data;
using EasyClothes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyClothes.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Product { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Subcategory> Subcategory { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<Payment> Payment { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.HasDefaultSchema("dbo");

        builder.Entity<ApplicationUser>(e =>
        {
            e.ToTable(name: "Users");
        });

        builder.Entity<ApplicationRole>(e =>
        {
            e.ToTable(name: "UserRoles");
        });

        builder.Entity<IdentityUserClaim<string>>(e =>
        {
            e.ToTable(name: "UserClaims");
        });

        builder.Entity<IdentityUserLogin<string>>().HasNoKey();
        builder.Entity<IdentityUserLogin<string>>(e =>
        {
            e.ToTable(name: "UserLogins");
        });

        builder.Entity<IdentityRoleClaim<string>>(e =>
        {
            e.ToTable(name: "RoleClaims");
        });

        builder.Entity<IdentityUserToken<string>>().HasNoKey();
        builder.Entity<IdentityUserToken<string>>(e =>
        {
            e.ToTable(name: "UserTokens");
        });

        builder.Entity<Category>()
            .HasMany(c => c.Subcategories)
            .WithOne(sc => sc.Category)
            .HasForeignKey(sc => sc.CategoryId);

        builder.Entity<Subcategory>()
            .HasMany(sc => sc.Products)
            .WithOne(p => p.Subcategory)
            .HasForeignKey(p => p.SubcategoryId);

        builder.Entity<Order>()
            .HasOne(o => o.ApplicationUser)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserId);

        builder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

        builder.Entity<OrderItem>()
            .HasOne(oi => oi.Product)
            .WithMany()
            .HasForeignKey(oi => oi.ProductId);

        builder.Entity<Payment>()
            .HasOne(p => p.Order)
            .WithOne(o => o.Payment)
            .HasForeignKey<Payment>(p => p.OrderId);

        builder.Entity<ProductImage>()
            .HasOne(pi => pi.Product)
            .WithMany(p => p.ProductImages)
            .HasForeignKey(pi => pi.ProductId);

    }
}
