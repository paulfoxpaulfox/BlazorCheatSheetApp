using BlazorCheatSheet.Shared.Domain;
using Blazored.LocalStorage;
using System.Text.Json;

namespace BlazorCheatSheet.Client.Services
{
    public class ClientYogaClassAttendanceRecordDataService : IYogaClassAttendanceRecordDataService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public ClientYogaClassAttendanceRecordDataService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
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
            bool yogaClassExirationExists = await _localStorageService.ContainKeyAsync("yogaClassAttendanceRecordsExpiration");

            if (yogaClassExirationExists)
            {
                DateTime expiration = await _localStorageService.GetItemAsync<DateTime>("yogaClassAttendanceRecordsExpiration");
                if (DateTime.Now < expiration)
                {
                    bool yogaClassRecordsExists = await _localStorageService.ContainKeyAsync("yogaClassAttendanceRecords");
                    if (yogaClassRecordsExists)
                    {
                        var cachedRecords = await _localStorageService.GetItemAsync<IEnumerable<YogaClassAttendanceRecord>>("yogaClassAttendanceRecords");
                        if (cachedRecords != null)
                        {
                            return cachedRecords;
                        }
                    }
                }
            }

            var list = await
                JsonSerializer.DeserializeAsync<IEnumerable<YogaClassAttendanceRecord>>(
                    await _httpClient.GetStreamAsync("/api/attendance"),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

            await _localStorageService.SetItemAsync("yogaClassAttendanceRecords", list);

            await _localStorageService.SetItemAsync("yogaClassAttendanceRecordsExpiration", DateTime.Now.AddMinutes(5));

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
