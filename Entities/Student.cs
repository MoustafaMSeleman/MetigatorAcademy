namespace EFCore_Metigator_ep10.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Section> Sections { get; } = new List<Section>();

        public override string ToString()
        {
            return $"{Id}  |  {Name}  |  {Sections}";
        }
    }
}
