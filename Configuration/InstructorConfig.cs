using EFCore_Metigator_ep10.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Metigator_ep10.Configuration
{
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(e => e.Office)
                .WithOne(e => e.Instructor)
                .HasForeignKey<Instructor>(e => e.Location)
                .IsRequired(false);
                
        }
    }
}
