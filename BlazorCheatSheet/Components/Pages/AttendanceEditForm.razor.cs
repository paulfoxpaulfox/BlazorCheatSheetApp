using BlazorCheatSheet.Contracts.Services;
using BlazorCheatSheet.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorCheatSheet.Components.Pages
{
    public partial class AttendanceEditForm
    {
        [SupplyParameterFromForm]
        public YogaClassAttendanceRecord YogaClassAttendanceRecord { get; set; }

        [Parameter]
        public int YogaClassAttendanceRecordId { get; set; }

        [Inject]
        private IYogaClassAttendanceRecordDataService YogaClassAttendanceRecordDataService { get; set; }

        [Inject]
        private IYogaClassDataService YogaClassDataService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        public IEnumerable<YogaClass> YogaClassesList { get; set; }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool IsSuccess = false;
        protected override async Task OnInitializedAsync()
        {
            IsSuccess = false;

            YogaClassesList = await YogaClassDataService.GetAllYogaClassesAsync();

            if (YogaClassAttendanceRecordId != 0)
            {
                YogaClassAttendanceRecord = await YogaClassAttendanceRecordDataService.GetYogaClassAttendanceRecordByIdAsync(YogaClassAttendanceRecordId);
            }

            YogaClassAttendanceRecord ??= new ();
           
        }

        public void HandleValidSubmit()
        {
            YogaClassAttendanceRecordDataService.AddYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord);
            Message = "Yoga Class Attendance Record updated successfully!";
            IsSuccess = true;
            StatusClass = "alert-success";
        }

        public void HandleInvalidSubmit()
        {
            Message = "Validation Errors!";
            StatusClass = "alert-danger";
        }

        protected async Task DeleteAttendanceRecord()
        {
             await YogaClassAttendanceRecordDataService.DeleteYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord.Id);
            Message = "Yoga Class Attendance Record deleted successfully!";
            IsSuccess = true;
            StatusClass = "alert-success";
        }

        protected void NavigateToVirtualizePage()
        {
            NavigationManager.NavigateTo("/virtualize");
        }
    }
}
