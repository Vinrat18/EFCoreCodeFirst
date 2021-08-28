using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Domain
{
	public class Instructor
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int Experience { get; set; }

		public virtual ICollection<Course> Courses { get; set; }

	}
}
