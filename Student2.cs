using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy2
{
	public class Student2 : Human2
	{
		public string Major { get; set; }
		public int Year { get; set; }

		public Student2(string firstName, string lastName, DateTime dateOfBirth, string major, int year) : base(firstName, lastName, dateOfBirth)
		{
			Major = major;
			Year = year;
		}

		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Major: {Major}");
			Console.WriteLine($"Year: {Year}");
		}
	}
}
