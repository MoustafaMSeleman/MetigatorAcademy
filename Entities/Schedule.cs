﻿namespace EFCore_Metigator_ep10.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public bool SUN { get; set; }
        public bool MON { get; set; }
        public bool TUE { get; set; }
        public bool WED { get; set; }
        public bool THU { get; set; }
        public bool FRI { get; set; }
        public bool SAT { get; set; }

        public override string ToString()
        {
            return $"[{Id}]   |   ScheduleTitle: {Title}   |   SUN: {SUN}   |   MON: {MON}|   TUS: {TUE}|   WED: {WED}|   THU: {THU}|   FRI: {FRI}|   SAT: {SAT}                ";
        }

    }
}
