using Datalayer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.EFConfigurations
{
	public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
	{
		public void Configure(EntityTypeBuilder<StudentCourse> builder)
		{
			builder.HasKey(sc => sc.Id);
			builder.Property(sc => sc.Id).UseIdentityColumn();

			builder.HasOne(sc => sc.Student).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.StudentId);

			builder.HasOne(sc => sc.Course).WithMany(c => c.StudentCourses).HasForeignKey(sc => sc.CourseId);
		}
	}
}
