namespace EFCore_Metigator_ep10.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string OfficeName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public Instructor? Instructor { get; set; }

        public override string ToString()
        {
            return $"[{Id}]  |  {OfficeName}  |  {Location}  |  {Instructor}";
        }
    }
}
