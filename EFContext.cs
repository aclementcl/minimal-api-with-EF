using entityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace entityFramework;

public class EFContext : DbContext
{
    public DbSet<House> Houses { get; set; }
    public DbSet<Person> People { get; set; }
    public EFContext(DbContextOptions<EFContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<House>(house =>
        {
            house.ToTable("House");
            house.HasKey(x => x.HouseId);

            house.Property(x => x.Title).IsRequired().HasMaxLength(100);
            house.Property(x => x.Description);
            house.Property(x => x.ShieldUrl);
            house.Property(x => x.HouseInfluence);
            house.Property(x => x.StartDate);
        });

        modelBuilder.Entity<Person>(person =>
        {
            person.ToTable("Person");
            person.HasKey(x => x.PersonId);
            person.HasOne(x => x.House).WithMany(x => x.People).HasForeignKey(x => x.HouseId);

            person.Property(x => x.Name).IsRequired().HasMaxLength(100);
            person.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            person.Property(x => x.NickName);
            person.Property(x => x.BirthDate);
            person.Property(x => x.Resume);
        });
    }
}