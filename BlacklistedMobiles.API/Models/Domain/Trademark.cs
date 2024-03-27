namespace BlacklistedMobiles.API.Models.Domain;

public class Trademark
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? DeletedAt { get; set; }
}