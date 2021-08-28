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
	public class StudentRepository : Repository<Student>, IStudentRepository
	{
		public StudentRepository(SchoolContext context) : base(context)
		{
		}

		private SchoolContext Context
		{
			get { return context as SchoolContext; }
		}

		public IEnumerable<Student> GetStundetsWithCourses()
		{
			return Context.Students.Include(s => s.StudentCourses);
		}
	}
}
