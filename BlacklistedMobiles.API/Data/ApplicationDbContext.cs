using BlacklistedMobiles.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlacklistedMobiles.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Province> Provinces { get; set; }

    public DbSet<Municipality> Municipalities { get; set; }

    public DbSet<Trademark> Trademarks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var trademarks = new List<Trademark>
        {
            new() { Id = Guid.Parse("42d0384a-cc80-4b54-9ecc-dc2a6244f9da"), Name = "Samsung" },
            new() { Id = Guid.Parse("649cfe5e-2c2c-4976-ae8b-7f938acc2207"), Name = "Huawei" },
            new() { Id = Guid.Parse("9a8db676-d198-43ad-b963-6e50dea2dfdd"), Name = "LG" },
            new() { Id = Guid.Parse("45eac17f-f06d-4235-a1fa-74164a015a67"), Name = "Xiaomi" }
        };

        modelBuilder.Entity<Trademark>().HasData(trademarks);

        var provinces = new List<Province>
        {
            new() { Id = Guid.Parse("5f39e8e2-6ee0-468d-b0a2-48c57b36b4c3"), Code = "01", Name = "Pinar del Río" },
            new() { Id = Guid.Parse("70d2370c-e3af-4158-b3d7-2e47fd621565"), Code = "02", Name = "La Habana" },
            new() { Id = Guid.Parse("b0950c26-c31f-4d91-84d7-36ad77701d4e"), Code = "03", Name = "Artemisa" },
            new() { Id = Guid.Parse("d65aedf0-454f-477e-922c-60531a2035d3"), Code = "04", Name = "Mayabeque" },
            new() { Id = Guid.Parse("4d3ec422-6b51-4b6f-9adc-7153f768c080"), Code = "05", Name = "Matanzas" },
            new() { Id = Guid.Parse("290ce103-1278-4fc4-b724-7d6c0ff12254"), Code = "06", Name = "Cienfuegos" },
            new() { Id = Guid.Parse("1064bae6-4902-4bf6-9431-1a7e1726e19d"), Code = "07", Name = "Villa Clara" },
            new() { Id = Guid.Parse("7fa460f3-1aae-40ad-9fb5-b53251a83040"), Code = "08", Name = "Sancti Spíritus" },
            new() { Id = Guid.Parse("f5c7be86-963a-4a02-a79f-49b925be6c00"), Code = "09", Name = "Ciego de Ávila" },
            new() { Id = Guid.Parse("75362065-425e-40f9-b5ba-c180ffa989c9"), Code = "10", Name = "Camagüey" },
            new() { Id = Guid.Parse("9e9779e6-680e-4588-ae57-b21778f4ca09"), Code = "11", Name = "Las Tunas" },
            new() { Id = Guid.Parse("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c"), Code = "12", Name = "Holguín" },
            new() { Id = Guid.Parse("fc7926b0-fc85-4e52-96b8-87590d1efba9"), Code = "13", Name = "Granma" },
            new() { Id = Guid.Parse("e183277f-03e4-4248-be3f-318e89eb77fa"), Code = "14", Name = "Santiago de Cuba" },
            new() { Id = Guid.Parse("3455b71f-6e0b-4416-841d-56c1745529dc"), Code = "15", Name = "Guantánamo" }
        };

        modelBuilder.Entity<Province>().HasData(provinces);

        var municipalities = new List<Municipality>
        {
            new()
            {
                Id = Guid.Parse("15747a09-bfed-4449-8f90-44dc56d63fa6"),
                Code = "1201",
                Name = "Calixto García",
                ProvinceId = Guid.Parse("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c")
            },
            new()
            {
                Id = Guid.Parse("5b174629-51d9-4ce0-9627-810bf332ba7a"),
                Code = "1202",
                Name = "Gibara",
                ProvinceId = Guid.Parse("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c")
            },
            new()
            {
                Id = Guid.Parse("b7f763f8-d085-4f2f-a785-b212e5fd8896"),
                Code = "1203",
                Name = "Banes",
                ProvinceId = Guid.Parse("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c")
            },
            new()
            {
                Id = Guid.Parse("98c4aa76-66a0-4a47-882c-3f08ba50ecb2"),
                Code = "1204",
                Name = "Rafael Freyre",
                ProvinceId = Guid.Parse("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c")
            },
            new()
            {
                Id = Guid.Parse("22f3dd42-0337-46fe-b40e-39481ed6b9e9"),
                Code = "1205",
                Name = "Moa",
                ProvinceId = Guid.Parse("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c")
            },
            new()
            {
                Id = Guid.Parse("a62128fb-bbe1-477f-b3d7-c2dd91579ca4"),
                Code = "1206",
                Name = "Holguín",
                ProvinceId = Guid.Parse("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c")
            }
        };

        modelBuilder.Entity<Municipality>().HasData(municipalities);
    }
}