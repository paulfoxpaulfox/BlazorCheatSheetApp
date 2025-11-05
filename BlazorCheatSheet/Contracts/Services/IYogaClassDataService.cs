using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Contracts.Services
{
    public interface IYogaClassDataService
    {
        Task<IEnumerable<YogaClass>> GetAllYogaClassesAsync();
        Task<IEnumerable<YogaClass>> GetYogaClassesByTypeIdAsync(int yogaClassTypeId);
        Task<YogaClass> GetYogaClassByIdAsync(int id);  
    }
}
