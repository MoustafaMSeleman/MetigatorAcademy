using EFCore_Metigator_ep10.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Metigator_ep10.Configuration
{
    public class EnrollmentConfig : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder) 
        {
            builder.HasKey(e => new { e.StudentId, e.SectionId });
        }
    }
}
