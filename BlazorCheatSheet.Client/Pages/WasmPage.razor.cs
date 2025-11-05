using BlazorCheatSheet.Client.Contracts.Services;
using BlazorCheatSheet.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorCheatSheet.Client.Pages
{
    public partial class WasmPage
    {
        private List<YogaClassAttendanceRecord> YogaClassAttendanceRecordList { get; set; } = [];

        [Inject]
        public IYogaClassAttendanceRecordDataService YogaClassAttendanceRecordDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var yogaClasseAttendanceRecords = await YogaClassAttendanceRecordDataService.GetAllYogaClassAttendanceRecordsAsync();
            YogaClassAttendanceRecordList = [.. yogaClasseAttendanceRecords];
        }
    }
}
