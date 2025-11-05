using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Contracts.Repositories
{
    public interface IYogaClassTypeRepository
    {
        Task<IEnumerable<YogaClassType>> GetAllYogaClassTypesAsync();
        Task<YogaClassType> GetYogaClassTypeByIdAsync(int id);
    }
}
