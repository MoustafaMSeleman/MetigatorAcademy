namespace EFCore_Metigator_ep10.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int InstructorId { get; set; }
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    }
}
