using EFCore_Metigator_ep10.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Metigator_ep10.Configuration
{
    public class SectionConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder) 
        {
            builder.HasOne(e => e.Course)
                .WithMany(e => e.Sections)
                .HasForeignKey(e => e.CourseId);

            builder.HasOne(e => e.Instructor)
                .WithMany(e => e.Sections);


            builder.HasMany(e => e.Students)
                .WithMany(e => e.Sections)
                .UsingEntity<Enrollment>(
                  
                  l => l.HasKey("SectionId","StudentId")
                );
            //convention will automatically create fks

            builder.HasMany(e => e.Schedules)
                .WithMany(e => e.Sections)
                .UsingEntity<SectionSchedule>();
        }
    }
}
