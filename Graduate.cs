using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy2
{
	public class Graduate : Student2
	{
		public string ThesisTopic { get; set; }
		public string Supervisor { get; set; }

		public Graduate(string firstName, string lastName, DateTime dateOfBirth, string major, int year, string thesisTopic, string supervisor) : base(firstName, lastName, dateOfBirth, major, year)
		{
			ThesisTopic = thesisTopic;
			Supervisor = supervisor;
		}

		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Thesis Topic: {ThesisTopic}");
			Console.WriteLine($"Supervisor: {Supervisor}");
		}
	}
}
