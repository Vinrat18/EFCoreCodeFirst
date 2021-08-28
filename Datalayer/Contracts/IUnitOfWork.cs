using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Contracts
{
	interface IUnitOfWork : IDisposable
	{
		ICourseRepository Courses { get; }

		IStudentRepository Students { get; }

		int Complete();
	}
}
