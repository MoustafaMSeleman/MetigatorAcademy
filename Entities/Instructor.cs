namespace EFCore_Metigator_ep10.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Section> Sections { get; } = new List<Section>();
    }
}
