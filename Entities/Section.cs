namespace EFCore_Metigator_ep10.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public override string ToString()
        { 
            return $"[{Id}]   |   SectionName: {SectionName}   |   CourseId: {CourseId}   |   InstructorId: {InstructorId}  |  {Instructor}";
        }

    }
}
