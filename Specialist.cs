using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy2
{
	public class Specialist : Student2
	{
		public string Specialization { get; set; }
		public string Company { get; set; }

		public Specialist(string firstName, string lastName, DateTime dateOfBirth, string major, int year, string specialization, string company) : base(firstName, lastName, dateOfBirth, major, year)
		{
			Specialization = specialization;
			Company = company;
		}

		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Specialization: {Specialization}");
			Console.WriteLine($"Company: {Company}");
		}
	}
}