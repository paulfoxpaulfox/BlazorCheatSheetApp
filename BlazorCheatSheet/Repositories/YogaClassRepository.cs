using BlazorCheatSheet.Contracts.Repositories;
using BlazorCheatSheet.Data;
using BlazorCheatSheet.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorCheatSheet.Repositories
{
    public class YogaClassRepository : IYogaClassRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        public YogaClassRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _appDbContext?.Dispose();
        }

        public async Task<IEnumerable<YogaClass>> GetAllYogaClassesAsync()
        {
            return await _appDbContext.YogaClasses.ToListAsync();
        }

        public async Task<YogaClass> GetYogaClassByIdAsync(int id)
        {
            return await _appDbContext.YogaClasses.FirstOrDefaultAsync(yc => yc.Id == id);
        }

        public async Task<IEnumerable<YogaClass>> GetYogaClassesByTypeIdAsync(int yogaClassTypeId)
        {
           return await _appDbContext.YogaClasses.Where(x => x.YogaClassTypeId == yogaClassTypeId).ToListAsync();
        }
    }
}
