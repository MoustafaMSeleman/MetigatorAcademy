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

            builder.HasMany(e => e.Instructors)
                .WithMany(e => e.Sections);
        }
    }
}
