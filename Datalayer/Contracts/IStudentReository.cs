using Datalayer.Domain;
using Repository_UnitOfWork.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Contracts
{
	public interface IStudentRepository: IRepository<Student>
	{
		IEnumerable<Student> GetStundetsWithCourses();
	}
}
