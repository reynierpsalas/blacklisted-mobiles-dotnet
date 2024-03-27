using BlacklistedMobiles.API.Models.Domain;

namespace BlacklistedMobiles.API.Repositories;

public interface ITrademarkRepository
{
    Task<List<Trademark>> GetAllAsync();

    Task<Trademark?> GetByNameAsync(string name);

    Task<Trademark> CreateAsync(Trademark entity);

    Task<Trademark?> UpdateAsync(string name, Trademark updated);

    Task<Trademark?> DeleteAsync(string name);
}