using System;

namespace _02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter your number:");
			int num = int.Parse (Console.ReadLine ());

			const int SUNDAY    = 0;
			const int MONDAY    = 1;
			const int TUESDAY   = 2;
			const int WEDNESDAY = 3;
			const int THURSDAY  = 4;
			const int FRIDAY    = 5;
			const int SATURDAY  = 6;

			switch (num) 
			{
			case SUNDAY:
				Console.WriteLine ("Sun");
				break;
			case MONDAY:
				Console.WriteLine ("Moon");
				break;
			case TUESDAY:
				Console.WriteLine ("Mars");
				break;
			case WEDNESDAY:
				Console.WriteLine ("Mercury");
				break;
			case THURSDAY:
				Console.WriteLine ("Jupitor");
				break;
			case FRIDAY:
				Console.WriteLine ("Venus");
				break;
			case SATURDAY:
				Console.WriteLine ("Saturn");
				break;
			default:
				Console.WriteLine ("you entered {0}, only 0~6 number are allowed", num);
				break;
			}

		}
	}}