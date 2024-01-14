using EFCore_Metigator_ep10.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Metigator_ep10.Configuration
{
    public class SectionScheduleConfig : IEntityTypeConfiguration<SectionSchedule>
    {
        public void Configure(EntityTypeBuilder<SectionSchedule> builder) 
        {
            builder.HasKey(e => new { e.SectionId, e.ScheduleId, e.StartTime, e.EndTime });
        }
    }
}
