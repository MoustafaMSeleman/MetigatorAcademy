namespace EFCore_Metigator_ep10.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;

        public ICollection<Section> Sections { get; } = new List<Section>();
        public Office Office { get; set; } = null!;
        public int Location { get; set; }

        public override string ToString()
        {
            return $"Id: [{Id}]  |  Name: {FName} {LName}  |  {Office} ";
        }
    }
}
