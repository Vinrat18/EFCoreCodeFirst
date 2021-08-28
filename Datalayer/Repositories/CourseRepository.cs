using Datalayer.Contracts;
using Datalayer.Domain;
using Microsoft.EntityFrameworkCore;
using Repository_UnitOfWork;
using Repository_UnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Repositories
{
	public class CourseRepository : Repository<Course>, ICourseRepository
	{
		public CourseRepository(SchoolContext context) : base(context)
		{
		}

		private SchoolContext Context
		{
			get { return context as SchoolContext; }
		}

		public IEnumerable<Course> GetCoursesWithStudents()
		{
			return Context.Courses.Include(c => c.StudentCourses);
		}
	}
}
