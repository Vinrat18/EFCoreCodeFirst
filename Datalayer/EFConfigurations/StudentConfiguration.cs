using Datalayer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.EFConfigurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.HasKey(s => s.Id);
			builder.Property(s => s.Id).UseIdentityColumn();

			builder.Property(s => s.FirstName).IsRequired(true);
		}
	}
}
