using Datalayer.Contracts;
using Datalayer.Domain;
using Datalayer.Repositories;
using Repository_UnitOfWork;
using Repository_UnitOfWork.Contracts;
using Repository_UnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer
{
	public class UnitOfWork: IDisposable
	{
		private readonly SchoolContext _context;

		public UnitOfWork(SchoolContext context)
		{
			_context = context;
			Courses = new CourseRepository(_context);
			Students = new StudentRepository(_context);
			Instructors = new Repository<Instructor>(_context);
		}

		public ICourseRepository Courses { get; private set; }

		public IStudentRepository Students { get; private set; }

		public IRepository<Instructor> Instructors { get; private set; }

		public int Complete()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
