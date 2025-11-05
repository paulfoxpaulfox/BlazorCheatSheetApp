using BlazorCheatSheet.Contracts.Repositories;
using BlazorCheatSheet.Data;
using BlazorCheatSheet.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorCheatSheet.Repositories
{
    public class YogaClassAttendanceRecordRepository : IYogaClassAttendanceRecordRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        public YogaClassAttendanceRecordRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _appDbContext?.Dispose();
        }

        public async Task<IEnumerable<YogaClassAttendanceRecord>> GetAllYogaClassAttendanceRecordsAsync()
        {
            return await _appDbContext.YogaClassAttendanceRecords.ToListAsync();
        }

        public async Task<IEnumerable<YogaClassAttendanceRecord>> GetPagedYogaClassAttendanceRecordsAsync(int pageSize, int pageStart)
        {
            return await _appDbContext.YogaClassAttendanceRecords
                .OrderBy(yc => yc.Id)
                .Skip(pageStart)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalYogaClassAttendanceRecordsCountAsync()
        {
            return await _appDbContext.YogaClassAttendanceRecords.CountAsync();
        }

        public async Task<YogaClassAttendanceRecord> GetYogaClassAttendanceRecordByIdAsync(int id)
        {
            return await _appDbContext.YogaClassAttendanceRecords.FirstOrDefaultAsync(yc => yc.Id == id);
        }

        public async Task<IEnumerable<YogaClassAttendanceRecord>> GetYogaClassAttendanceRecordsByYogaClassIdAsync(int yogaClassId)
        {
           return await _appDbContext.YogaClassAttendanceRecords.Where(x => x.YogaClassId == yogaClassId).ToListAsync();
        }


        // Crud
        public async Task<YogaClassAttendanceRecord> AddYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord)
        {
            var addedEntity = await _appDbContext.YogaClassAttendanceRecords.AddAsync(yogaClassAttendanceRecord);
            await _appDbContext.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<YogaClassAttendanceRecord> UpdateYogaClassAttendanceRecordAsync(YogaClassAttendanceRecord yogaClassAttendanceRecord)
        {
            var existingEntity = _appDbContext.YogaClassAttendanceRecords.FirstOrDefault(yc => yc.Id == yogaClassAttendanceRecord.Id);

            if (existingEntity != null)
            {
                existingEntity.YogaClassId = yogaClassAttendanceRecord.YogaClassId;
                existingEntity.AttendanceDate = yogaClassAttendanceRecord.AttendanceDate;
                existingEntity.AttendeeCount = yogaClassAttendanceRecord.AttendeeCount;
                _appDbContext.YogaClassAttendanceRecords.Update(existingEntity);
                _appDbContext.SaveChanges();
                return await Task.FromResult(existingEntity);
            }
            else
            {
                throw new KeyNotFoundException($"YogaClassAttendanceRecord with Id {yogaClassAttendanceRecord.Id} not found.");
            }
        }

        public async Task DeleteYogaClassAttendanceRecordAsync(int id)
        {
            var existingEntity = _appDbContext.YogaClassAttendanceRecords.FirstOrDefault(yc => yc.Id == id);
            if (existingEntity != null)
            {
                _appDbContext.YogaClassAttendanceRecords.Remove(existingEntity);
                _appDbContext.SaveChanges();
                return;
            }
            else
            {
                throw new KeyNotFoundException($"YogaClassAttendanceRecord with Id {id} not found.");
            }
        }
    }
}
