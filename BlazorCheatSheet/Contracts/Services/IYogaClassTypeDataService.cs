using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Contracts.Services
{
    public interface IYogaClassTypeDataService
    {
        Task<IEnumerable<YogaClassType>> GetAllYogaClassTypesAsync();
        Task<YogaClassType> GetYogaClassTypeByIdAsync(int id);  
    }
}
