namespace BlazorCheatSheet.Shared.Domain
{
    public class YogaClass
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public int YogaClassTypeId { get; set; }
        public YogaClassType YogaClassType { get; set; }
    }
}
