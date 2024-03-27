using System.ComponentModel.DataAnnotations;

namespace BlacklistedMobiles.API.Models.DTO;

public class AddTrademarkRequestDto
{
    [Required] public string Name { get; set; }
}