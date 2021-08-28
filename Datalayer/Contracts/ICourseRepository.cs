using Datalayer.Domain;
using Repository_UnitOfWork.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Contracts
{
	public interface ICourseRepository:IRepository<Course>
	{
		IEnumerable<Course> GetCoursesWithStudents();
	}
}
