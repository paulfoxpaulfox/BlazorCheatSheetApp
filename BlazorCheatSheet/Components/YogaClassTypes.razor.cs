using BlazorCheatSheet.Contracts.Services;
using BlazorCheatSheet.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorCheatSheet.Components
{
    public partial class YogaClassTypes
    {
        private bool _isLoading = true;
        private List<YogaClassType> YogaClassTypesList { get; set; } = new List<YogaClassType>();
        private List<YogaClass> YogaClassesList { get; set; } = new List<YogaClass>();

        [Inject]
        public IYogaClassTypeDataService YogaClassTypeDataService { get; set; }

        [Inject]
        public IYogaClassDataService YogaClassDataService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            var yogaClassTypes = await YogaClassTypeDataService.GetAllYogaClassTypesAsync();
            YogaClassTypesList = [.. yogaClassTypes];
            _isLoading = false;
        }

        private async Task OnYogaClassTypeSelected(YogaClassType selectedYogaClassType)
        {
            var yogaClasses = await YogaClassDataService.GetYogaClassesByTypeIdAsync(selectedYogaClassType.Id);
            YogaClassesList = [.. yogaClasses];
        }
    }
}
