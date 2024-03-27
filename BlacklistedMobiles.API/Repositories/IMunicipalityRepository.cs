using BlacklistedMobiles.API.Models.Domain;

namespace BlacklistedMobiles.API.Repositories;

public interface IMunicipalityRepository
{
    Task<List<Municipality>> GetAllAsync();

    Task<Municipality?> GetByCodeAsync(string code);
}