using System.ComponentModel.DataAnnotations;

namespace BlacklistedMobiles.API.Models.DTO;

public class UpdateTrademarkRequestDto
{
    [Required] public string Name { get; set; }
}