using Datalayer;
using Datalayer.Domain;
using System;

namespace Repository_UnitOfWork
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var uom = new UnitOfWork(new SchoolContext()))
			{
				var students = uom.Students.GetAll();

				var instructor = new Instructor
				{
					Name = "Awesome Guy",
					Experience = 18,
				};
				uom.Instructors.Add(instructor);
				uom.Complete();
			}

			Console.ReadLine();
		}
	}
}
