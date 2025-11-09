using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Client
{
    public interface IYogaClassAttendanceRecordDataService
    {
        Task<IEnumerable<YogaClassAttendanceRecord>> GetAllYogaClassAttendanceRecordsAsync();
        Task<IEnumerable<YogaClassAttendanceRecord>> GetYogaClassAttendanceRecordsByYogaClassIdAsync(int yogaClassId);
        Task<YogaClassAttendanceRecord> GetYogaClassAttendanceRecordByIdAsync(int id);

        Task<IEnumerable<YogaClassAttendanceRecord>> GetPagedYogaClassAttendanceRecordsAsync(int pageSize, int pageStart);

        Task<int> GetTotalYogaClassAttendanceRecordsCountAsync();

        // Crud
        Task<YogaClassAttendanceRecord> AddYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord);
        Task<YogaClassAttendanceRecord> UpdateYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord);
        Task DeleteYogaClassAttendanceRecordAsync(int id);
    }
}