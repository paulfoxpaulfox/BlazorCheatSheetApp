using BlazorCheatSheet.Contracts.Repositories;
using BlazorCheatSheet.Contracts.Services;
using BlazorCheatSheet.Data;
using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Services
{
    public class YogaClassTypeDataService : IYogaClassTypeDataService
    {
        private readonly IYogaClassTypeRepository _yogaClassTypeRepository;

        public YogaClassTypeDataService(IYogaClassTypeRepository yogaClassTypeRepository)
        {
            _yogaClassTypeRepository = yogaClassTypeRepository;
        }

        public async Task<IEnumerable<YogaClassType>> GetAllYogaClassTypesAsync()
        {
            return await _yogaClassTypeRepository.GetAllYogaClassTypesAsync();
        }

        public async Task<YogaClassType> GetYogaClassTypeByIdAsync(int id)
        {
            return await _yogaClassTypeRepository.GetYogaClassTypeByIdAsync(id);
        }
    }
}
