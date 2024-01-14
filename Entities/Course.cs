namespace EFCore_Metigator_ep10.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = null!;
        public decimal Price { get; set; }
        public List<Section> Sections { get;} = [];
    }
    
}
