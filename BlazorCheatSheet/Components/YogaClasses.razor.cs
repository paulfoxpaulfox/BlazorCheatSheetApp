using BlazorCheatSheet.Client.Contracts.Services;
using BlazorCheatSheet.Contracts.Services;
using BlazorCheatSheet.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace BlazorCheatSheet.Components
{
    public partial class YogaClasses
    {
        private bool _isLoading = true;

        private bool _virtualize = false;
        private List<YogaClass> YogaClassesList { get; set; } = new List<YogaClass>();

        private float _itemHieght = 50;
        private int _queryableCount = 0;
        private List<YogaClassAttendanceRecord> YogaClassAttendanceRecordList { get; set; } = new List<YogaClassAttendanceRecord>();

        private IQueryable<YogaClassAttendanceRecord> YogaClassAttendanceRecordQueryable { get; set; }

        [Inject]
        public IYogaClassDataService YogaClassDataService { get; set; }

        [Inject]
        public IYogaClassAttendanceRecordDataService YogaClassAttendanceRecordDataService { get; set; }

        public async ValueTask<ItemsProviderResult<YogaClassAttendanceRecord>> LoadYogaClassAttendanceRecordsAsync(ItemsProviderRequest request)
        {
            int totalCount = await YogaClassAttendanceRecordDataService.GetTotalYogaClassAttendanceRecordsCountAsync();

            var numberOfItemsToFetch = Math.Min(request.Count, totalCount - request.StartIndex);

            var yogaClassAttendanceRecords = await YogaClassAttendanceRecordDataService.GetPagedYogaClassAttendanceRecordsAsync(numberOfItemsToFetch, request.StartIndex);

            return new ItemsProviderResult<YogaClassAttendanceRecord>(yogaClassAttendanceRecords, totalCount);
        }

        protected override async Task OnInitializedAsync()
        {
            var yogaClasses = await YogaClassDataService.GetAllYogaClassesAsync();
            YogaClassesList = [.. yogaClasses];
            _isLoading = false;
        }

        private async Task OnYogaClassSelected(YogaClass? selectedYogaClass, bool visualize)
        {
            if (selectedYogaClass != null)
            {
                var yogaClassAttendanceRecords = await YogaClassAttendanceRecordDataService.GetYogaClassAttendanceRecordsByYogaClassIdAsync(selectedYogaClass.Id);
                YogaClassAttendanceRecordList = [.. yogaClassAttendanceRecords];
            }
            else
            {
                var yogaClassAttendanceRecords = await YogaClassAttendanceRecordDataService.GetAllYogaClassAttendanceRecordsAsync();
                YogaClassAttendanceRecordList = [.. yogaClassAttendanceRecords];
            }

            _virtualize = visualize;
        }
    }
}
