using BlazorCheatSheet.Contracts.Repositories;
using BlazorCheatSheet.Contracts.Services;
using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Services
{
    public class YogaClassDataService : IYogaClassDataService
    {
        private readonly IYogaClassRepository _yogaClassRepository;

        public YogaClassDataService(IYogaClassRepository yogaClassRepository)
        {
            _yogaClassRepository = yogaClassRepository;
        }
        public Task<IEnumerable<YogaClass>> GetAllYogaClassesAsync()
        {
            return _yogaClassRepository.GetAllYogaClassesAsync();
        }

        public Task<YogaClass> GetYogaClassByIdAsync(int id)
        {
            return _yogaClassRepository.GetYogaClassByIdAsync(id);
        }

        public Task<IEnumerable<YogaClass>> GetYogaClassesByTypeIdAsync(int yogaClassTypeId)
        {
           return _yogaClassRepository.GetYogaClassesByTypeIdAsync(yogaClassTypeId);
        }
    }
}
