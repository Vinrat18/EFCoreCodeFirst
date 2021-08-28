using Datalayer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.EFConfigurations
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Id).UseIdentityColumn();

			builder.Property(c => c.Description).HasMaxLength(250);

			builder.Property(c => c.InstructorId).IsRequired(true);
			builder.HasOne(c => c.Instructor).WithMany(I => I.Courses).HasForeignKey(c => c.InstructorId);
		}
	}
}
