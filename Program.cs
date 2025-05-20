using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Human2> academyMembers = new List<Human2>();

			Human2 person1 = new Human2("John", "Doe", new DateTime(1980, 1, 1));
			Student2 student1 = new Student2("Alice", "Smith", new DateTime(2000, 5, 10), "Computer Science", 3);
			Graduate graduate1 = new Graduate("Bob", "Johnson", new DateTime(1998, 8, 15), "Engineering", 5, "Advanced Materials", "Dr. Lee");
			Specialist specialist1 = new Specialist("Eve", "Williams", new DateTime(1999, 3, 20), "Business", 4, "Marketing", "Bosch");

			academyMembers.Add(person1);
			academyMembers.Add(student1);
			academyMembers.Add(graduate1);
			academyMembers.Add(specialist1);

			foreach (var member in academyMembers)
			{
				member.PrintInfo();
				Console.WriteLine("---");
			}

			Console.ReadKey();
		}
	}
}
