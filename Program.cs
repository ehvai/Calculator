using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// initialize the numeric values
			int num1 = 0;
			int num2 = 0;
			float result = 0f;

			// Request the user enter two numbers and a type of calculation
			Console.WriteLine("<<   Calculator   >>");
			Console.WriteLine("--------------------\n");
			Console.WriteLine("Please enter the first number: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the second number: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please select enter the type of calculation you would like to perform:");
			Console.WriteLine("\ta\t-\tAddition");
			Console.WriteLine("\ts\t-\tSubtraction");
			Console.WriteLine("\tm\t-\tMultiplication");
			Console.WriteLine("\td\t-\tDivision");
			string calculation = Console.ReadLine();

			// Perform calculation based on the values and request
			switch (calculation)
			{
				case "a":
					result = num1 + num2;
					break;
				case "s":
					result = num1 - num2;
					break;
				case "m":
					result = num1 * num2;
					break;
				case "d":
					result = num1 / num2;
					break;
			}
			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
