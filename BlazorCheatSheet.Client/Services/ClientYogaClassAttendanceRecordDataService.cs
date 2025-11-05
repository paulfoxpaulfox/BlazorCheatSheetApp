using BlazorCheatSheet.Client.Contracts.Services;
using BlazorCheatSheet.Shared.Domain;
using System.Text.Json;

namespace BlazorCheatSheet.Client.Services
{
    internal class ClientYogaClassAttendanceRecordDataService : IYogaClassAttendanceRecordDataService
    {
        private readonly HttpClient _httpClient;
        public ClientYogaClassAttendanceRecordDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<YogaClassAttendanceRecord> AddYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord)
        {
            throw new NotImplementedException();
        }

        public Task DeleteYogaClassAttendanceRecordAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<YogaClassAttendanceRecord>> GetAllYogaClassAttendanceRecordsAsync()
        {
            var list = await
                JsonSerializer.DeserializeAsync<IEnumerable<YogaClassAttendanceRecord>>(
                    await _httpClient.GetStreamAsync("/api/attendance"),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            return list ?? [];
        }

        public Task<IEnumerable<YogaClassAttendanceRecord>> GetPagedYogaClassAttendanceRecordsAsync(int pageSize, int pageStart)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalYogaClassAttendanceRecordsCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<YogaClassAttendanceRecord> GetYogaClassAttendanceRecordByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<YogaClassAttendanceRecord>> GetYogaClassAttendanceRecordsByYogaClassIdAsync(int yogaClassId)
        {
            throw new NotImplementedException();
        }

        public Task<YogaClassAttendanceRecord> UpdateYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord)
        {
            throw new NotImplementedException();
        }
    }
}
