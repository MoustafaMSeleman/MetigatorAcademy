namespace EFCore_Metigator_ep10.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = null!;
        public decimal Price { get; set; }
        public ICollection<Section> Sections { get;} = new List<Section>();

        public override string ToString()
        {
            return $"[{Id}]  |  {CourseName}  |  {Price}";
        }
    }
}
    

