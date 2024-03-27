using BlacklistedMobiles.API.Models.Domain;

namespace BlacklistedMobiles.API.Repositories;

public interface IProvinceRepository
{
    Task<List<Province>> GetAllAsync();

    Task<Province?> GetByCodeAsync(string code);
}