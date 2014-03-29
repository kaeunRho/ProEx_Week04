using System;

namespace Lab01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the first number:");
			int firstnum = int.Parse (Console.ReadLine ());

			Console.Write ("Enter the second number:");
			int secondnum = int.Parse (Console.ReadLine ());

			Console.Write ("Enter the operation(+,-,*,/,% is allowed):");
			string operation = Console.ReadLine ();

			if (operation == "+") {
				Console.WriteLine ("result:{0}", firstnum + secondnum);
			} else if (operation == "-") {
				Console.WriteLine ("result:{0}", firstnum - secondnum);
			} else if (operation == "*") {
				Console.WriteLine ("result:{0}", firstnum * secondnum);
			} else if (operation == "/") {
				Console.WriteLine ("result:{0}", firstnum / secondnum);
			} else if (operation == "%") {
				Console.WriteLine ("result:{0}", firstnum % secondnum);
			}
			 else {
				Console.WriteLine ("You enter the {0}, Only +,-,*,/,% are allowed ",operation);
			}

		}
	}
}