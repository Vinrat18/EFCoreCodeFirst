﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Domain
{
	public class Course
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int InstructorId { get; set; }

		public Instructor Instructor { get; set; }

		public ICollection<StudentCourse> StudentCourses { get; set; }
	}
}
