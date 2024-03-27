using BlacklistedMobiles.API.Data;
using BlacklistedMobiles.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlacklistedMobiles.API.Repositories.Adapters;

public class SqliteProvinceRepository : IProvinceRepository
{
    private readonly ApplicationDbContext _dbContext;

    public SqliteProvinceRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Province>> GetAllAsync()
    {
        return await _dbContext.Provinces
            .Where(x => x.DeletedAt == null)
            .ToListAsync();
    }

    public async Task<Province?> GetByCodeAsync(string code)
    {
        return await _dbContext.Provinces
            .FirstOrDefaultAsync(x => x.Code == code);
    }
}