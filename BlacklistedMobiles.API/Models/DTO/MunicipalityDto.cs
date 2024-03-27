namespace BlacklistedMobiles.API.Models.DTO;

public class MunicipalityDto
{
    public string Code { get; set; }

    public string Name { get; set; }

    public ProvinceDto Province { get; set; }
}