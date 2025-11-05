using BlazorCheatSheet.Contracts.Repositories;
using BlazorCheatSheet.Contracts.Services;
using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Services
{
    public class YogaClassAttendanceRecordDataService : IYogaClassAttendanceRecordDataService
    {
        private readonly IYogaClassAttendanceRecordRepository _yogaClassAttendanceRecordRepository;

        public YogaClassAttendanceRecordDataService(IYogaClassAttendanceRecordRepository yogaClassAttendanceRecordRepository)
        {
            _yogaClassAttendanceRecordRepository = yogaClassAttendanceRecordRepository;
        }

        public Task<IEnumerable<YogaClassAttendanceRecord>> GetAllYogaClassAttendanceRecordsAsync()
        {
            return _yogaClassAttendanceRecordRepository.GetAllYogaClassAttendanceRecordsAsync();
        }

        public Task<IEnumerable<YogaClassAttendanceRecord>> GetYogaClassAttendanceRecordsByYogaClassIdAsync(int yogaClassId)
        {
            return _yogaClassAttendanceRecordRepository.GetYogaClassAttendanceRecordsByYogaClassIdAsync(yogaClassId);
        }

        public Task<YogaClassAttendanceRecord> GetYogaClassAttendanceRecordByIdAsync(int id)
        {
            return _yogaClassAttendanceRecordRepository.GetYogaClassAttendanceRecordByIdAsync(id);
        }

        public Task<IEnumerable<YogaClassAttendanceRecord>> GetPagedYogaClassAttendanceRecordsAsync(int pageSize, int pageStart)
        {
            return _yogaClassAttendanceRecordRepository.GetPagedYogaClassAttendanceRecordsAsync(pageSize, pageStart);
        }

        public Task<int> GetTotalYogaClassAttendanceRecordsCountAsync()
        {
            return _yogaClassAttendanceRecordRepository.GetTotalYogaClassAttendanceRecordsCountAsync();
        }

        
        // Crud
        public async Task<YogaClassAttendanceRecord> AddYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord)
        {
            return await _yogaClassAttendanceRecordRepository.AddYogaClassAttendanceRecordAsync(yogaClassAttendanceRecord);
        }

        public async Task<YogaClassAttendanceRecord> UpdateYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord)
        {
            return await _yogaClassAttendanceRecordRepository.UpdateYogaClassAttendanceRecordAsync(yogaClassAttendanceRecord);
        }

        public async Task DeleteYogaClassAttendanceRecordAsync(int id)
        {
            await _yogaClassAttendanceRecordRepository.DeleteYogaClassAttendanceRecordAsync(id);
        }
    }
}