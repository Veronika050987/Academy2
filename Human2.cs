using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy2
{
	public class Human2
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }

		public Human2(string firstName, string lastName, DateTime dateOfBirth)
		{
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
		}

		public virtual void PrintInfo()
		{
			Console.WriteLine($"Name: {FirstName} {LastName}");
			Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
		}
	}
}
