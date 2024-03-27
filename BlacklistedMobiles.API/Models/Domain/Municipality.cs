namespace BlacklistedMobiles.API.Models.Domain;

public class Municipality
{
    public Guid Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public Guid ProvinceId { get; set; }

    public Province Province { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? DeletedAt { get; set; }
}