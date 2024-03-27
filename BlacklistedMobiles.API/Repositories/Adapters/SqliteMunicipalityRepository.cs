using BlacklistedMobiles.API.Data;
using BlacklistedMobiles.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlacklistedMobiles.API.Repositories.Adapters;

public class SqliteMunicipalityRepository : IMunicipalityRepository
{
    private readonly ApplicationDbContext _dbContext;

    public SqliteMunicipalityRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Municipality>> GetAllAsync()
    {
        return await _dbContext.Municipalities
            .Include(x => x.Province)
            .Where(x => x.DeletedAt == null)
            .ToListAsync();
    }

    public async Task<Municipality?> GetByCodeAsync(string code)
    {
        return await _dbContext.Municipalities
            .Include(x => x.Province)
            .FirstOrDefaultAsync(x => x.Code == code);
    }
}