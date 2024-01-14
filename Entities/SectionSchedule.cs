namespace EFCore_Metigator_ep10.Entities
{
    public class SectionSchedule
    {
        public int SectionId { get; set; }
        public int ScheduleId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
