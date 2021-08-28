using System.Collections.Generic;

namespace Datalayer.Domain
{
	public class Student
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string FullName { get { return $"{FirstName} {LastName}"; } }

		public ICollection<StudentCourse> StudentCourses { get; set; }
	}
}
