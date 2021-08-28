using Datalayer.Domain;
using Datalayer.EFConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository_UnitOfWork
{
	public class SchoolContext : DbContext
	{
		public SchoolContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=INBEN10196L\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=False;User Id=sa;Password=Kongsberg@123").EnableDetailedErrors();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new StudentConfiguration());
			modelBuilder.ApplyConfiguration(new CourseConfiguration());
			modelBuilder.ApplyConfiguration(new InstructorConfiguration());
			modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());
		}

		//entities
		public virtual DbSet<Student> Students { get; set; }

		public virtual DbSet<Course> Courses { get; set; }

		public virtual DbSet<Instructor> Instructors { get; set; }
	}
}
