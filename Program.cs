using System;
using System.Text.RegularExpressions;

namespace Calculator
{
	class Calculate
	{
		public static double DoCalculation(double num1, double num2, string calculation)
		{
			double result = double.NaN;
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
					if (num2 != 0)
					{
						result = num1 / num2;
					}
					break;
				case "%":
					result = num1 % num2;
					break;
				default:
					break;
			}
			return result;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			bool stopCalc = false;

			// Calculator header
			Console.WriteLine("<<   Calculator   >>");
			Console.WriteLine("--------------------\n");

			while (!stopCalc)
			{
				// initialize the numeric values
				string? num1Input="";
				string? num2Input="";
				double result = 0;

				// Request the user enter the first number
				Console.WriteLine("Please enter a number: ");
				num1Input = Console.ReadLine();

				double num1 = 0;
				while (!double.TryParse(num1Input, out num1))
				{
					Console.WriteLine("This is not a valid input.  Please enter a numeric value.");
					num1Input = Console.ReadLine();
				}

				// Request the user enter the second number
				Console.WriteLine("Please enter a number: ");
				num2Input = Console.ReadLine();

				double num2 = 0;
				while (!double.TryParse(num2Input, out num2))
				{
					Console.WriteLine("This is not a valid input.  Please enter a numeric value.");
					num2Input = Console.ReadLine();
				}

				// Request the user enter the type of calculation to perform
				Console.WriteLine("Please select enter the type of calculation you would like to perform:");
				Console.WriteLine("\ta - Addition");
				Console.WriteLine("\ts - Subtraction");
				Console.WriteLine("\tm - Multiplication");
				Console.WriteLine("\td - Division");
				Console.WriteLine("\t% - Modulo");
				string? calculation = Console.ReadLine();

				if(calculation == null || ! Regex.IsMatch(calculation, "[a|s|m|d|%]"))
				{
					Console.WriteLine("That selection was not one of the approved actions.");
				}
                else
                {
					try
					{
						result = Calculate.DoCalculation(num1, num2, calculation);
						if (double.IsNaN(result))
						{
							Console.WriteLine("This calculation will result in a mathematical error.\n");
						}
						else
						{
							Console.WriteLine("Your result is: {0:0.##}\n", result);
						}

					}
					catch (Exception e)
					{
						Console.WriteLine($"An exception occured trying to do the math.\n Details: {e.Message}");
					}
                }
				Console.WriteLine("Press 'n' and Enter to close the app, or 'y' if you would like to do another calculation.");
				if (Console.ReadLine() == "n") stopCalc = true;
			}
			return;
		}
	}
}
