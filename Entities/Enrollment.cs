namespace EFCore_Metigator_ep10.Entities
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public int SectionId { get; set; }

        public override string ToString()
        {
            return $"StudentId: [{StudentId}]  |  SectionId: [{SectionId}]";
        }
    }
}
