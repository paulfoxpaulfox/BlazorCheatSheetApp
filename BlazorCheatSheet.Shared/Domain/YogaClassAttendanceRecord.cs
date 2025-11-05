using System.ComponentModel.DataAnnotations;

namespace BlazorCheatSheet.Shared.Domain
{
    public class YogaClassAttendanceRecord
    {
        public int Id { get; set; }
        public int YogaClassId { get; set; }

        public YogaClass YogaClass { get; set; }
        public DateTime AttendanceDate { get; set; }

        [Required]
        public int AttendeeCount { get; set; }
    }
}
