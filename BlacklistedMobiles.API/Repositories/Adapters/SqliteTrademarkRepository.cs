using BlacklistedMobiles.API.Data;
using BlacklistedMobiles.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlacklistedMobiles.API.Repositories.Adapters;

public class SqliteTrademarkRepository : ITrademarkRepository
{
    private readonly ApplicationDbContext _dbContext;

    public SqliteTrademarkRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Trademark>> GetAllAsync()
    {
        return await _dbContext.Trademarks
            .Where(x => x.DeletedAt == null)
            .ToListAsync();
    }

    public async Task<Trademark?> GetByNameAsync(string name)
    {
        return await _dbContext.Trademarks
            .FirstOrDefaultAsync(x => x.Name == name);
    }

    public async Task<Trademark> CreateAsync(Trademark entity)
    {
        await _dbContext.Trademarks.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task<Trademark?> UpdateAsync(string name, Trademark updated)
    {
        var entity = await _dbContext.Trademarks
            .FirstOrDefaultAsync(x => x.Name == name);

        if (entity == null) return null;

        entity.Name = updated.Name;

        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task<Trademark?> DeleteAsync(string name)
    {
        var entity = await _dbContext.Trademarks
            .FirstOrDefaultAsync(x => x.Name == name);

        if (entity == null) return null;

        entity.DeletedAt = DateTime.Now;

        await _dbContext.SaveChangesAsync();

        return entity;
    }
}