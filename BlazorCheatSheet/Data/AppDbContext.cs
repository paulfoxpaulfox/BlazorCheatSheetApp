using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BlazorCheatSheet.Shared.Domain;

namespace BlazorCheatSheet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
        }

        public DbSet<YogaClass> YogaClasses { get; set; }
        public DbSet<YogaClassType> YogaClassTypes { get; set; }
        public DbSet<YogaClassAttendanceRecord> YogaClassAttendanceRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YogaClassType>().HasData(new YogaClassType() { Id = 1, Name = "Hatha", Description="Its Hatha"});
            modelBuilder.Entity<YogaClassType>().HasData(new YogaClassType() { Id = 2, Name = "Vinyasa", Description = "Its Vinyasa" });
            modelBuilder.Entity<YogaClassType>().HasData(new YogaClassType() { Id = 3, Name = "Ashtanga", Description = "Its Ashtanga" });

            modelBuilder.Entity<YogaClass>().HasData(new YogaClass()
            {
                Id = 1,
                Name = "Morning Hatha Flow",
                Description = "A gentle Hatha yoga class to start your day.",
                YogaClassTypeId = 1
            });
            modelBuilder.Entity<YogaClass>().HasData(new YogaClass()
            {
                Id = 2,
                Name = "Power Vinyasa",
                Description = "An energetic Vinyasa class to build strength and flexibility.",
                YogaClassTypeId = 2
            });
            modelBuilder.Entity<YogaClass>().HasData(new YogaClass()
            {
                Id = 3,
                Name = "Ashtanga Primary Series",
                Description = "A traditional Ashtanga yoga class following the primary series.",
                YogaClassTypeId = 3
            });

            // Deterministic seed for 1000 attendance records so migrations are repeatable.
            var attendanceRecords = new List<YogaClassAttendanceRecord>(1000);
            for (int i = 1; i <= 1000; i++)
            {
                attendanceRecords.Add(new YogaClassAttendanceRecord
                {
                    Id = i,
                    // distributes 1..3
                    YogaClassId = (i % 3) + 1,
                    // deterministic varying date/time within ~1 year from 2024-01-01
                    AttendanceDate = new DateTime(2024, 1, 1)
                        .AddDays(i % 365)
                        .AddHours((i * 7) % 24)
                        .AddMinutes((i * 13) % 60)
                        .AddSeconds((i * 17) % 60),
                    // 5..51
                    AttendeeCount = 5 + (i % 47)
                });
            }

            modelBuilder.Entity<YogaClassAttendanceRecord>().HasData(attendanceRecords.ToArray());

            base.OnModelCreating(modelBuilder);
        }
    }
}
