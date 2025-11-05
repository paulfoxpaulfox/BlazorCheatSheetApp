using BlazorCheatSheet.Contracts.Repositories;
using BlazorCheatSheet.Data;
using BlazorCheatSheet.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorCheatSheet.Repositories
{
    public class YogaClassTypeRepository : IYogaClassTypeRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        public YogaClassTypeRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _appDbContext?.Dispose();
        } 
        public async Task<IEnumerable<YogaClassType>> GetAllYogaClassTypesAsync()
        {
            return await _appDbContext.YogaClassTypes.ToListAsync();
        }

        public async Task<YogaClassType> GetYogaClassTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
