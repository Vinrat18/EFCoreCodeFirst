using Datalayer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.EFConfigurations
{
	class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
	{
		public void Configure(EntityTypeBuilder<Instructor> builder)
		{
			builder.HasKey(i => i.Id);
			builder.Property(i => i.Id).UseIdentityColumn();

			builder.HasIndex(i => i.Experience).IsUnique();
			builder.Property(i => i.Experience).IsRequired(true);
		}
	}
}
