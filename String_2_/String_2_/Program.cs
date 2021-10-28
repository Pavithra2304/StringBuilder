using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			
			StringBuilder details;
			details = new StringBuilder();
			Console.WriteLine("Please Enter your Name");
			details.Insert(0, Console.ReadLine());
			Console.WriteLine("Please Enter your age");
			details.Insert(1, Console.ReadLine());
			Console.WriteLine("Please Enter your Qualification");
			details.Insert(2, Console.ReadLine());
			Console.WriteLine("Please Enter your Experience");
			details.Insert(3, Console.ReadLine());
			Console.WriteLine(details);
			Console.Read();
		}
	}
}
