using System;

namespace IterationStatementTaylorRamsamy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please input a number between 2 and 10.");
			String NumberInput;
			NumberInput = Console.ReadLine();
			int Number;
			Number = Convert.ToInt32(NumberInput);
			Console.ReadLine();

			if (Number % 2 == 1)

			{
				int Count;
				Count = 0;
				while (Count < Number - 1)
				{
					Count++;
					Console.WriteLine(Count + ". You have entered an odd number");
					
				}

			}

			else

			{
				int Count;
				Count = 0;
				while (Count < Number + 1)
				{
					Count++;
					Console.WriteLine(Count + ". You have entered an odd number");
					
				}
			}
		}
	}
}
