using System;

namespace _02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the first number:");
			int firstnum = int.Parse (Console.ReadLine ());
			Console.Write ("Enter the second number:");
			int secondnum = int.Parse (Console.ReadLine ());
			Console.Write ("Enter the operation(+,-,*,/,% are allowed):");
			string operation = Console.ReadLine ();

			switch(operation){
			case "+":
				Console.WriteLine ("Result:{0}", firstnum + secondnum);
				break;
			case "-":
				Console.WriteLine ("Result:{0}", firstnum - secondnum);
				break;
			case "*":
				Console.WriteLine ("Result:{0}", firstnum * secondnum);
				break;
			case "/":
				Console.WriteLine ("Result:{0}", firstnum / secondnum);
				break;
			case "%":
				Console.WriteLine ("Result:{0}", firstnum % secondnum);
				break;
			default:
				Console.WriteLine ("You entered {0}, Only +,-,*,/,% are allowed", operation);
				break;
		}
	}
}
}
