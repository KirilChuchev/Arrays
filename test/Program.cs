using System;
using System.Linq;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int[] digits = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


			for (int i = 0; i < digits.Length; i++)
			{
				for (int j = i + 1; j < digits.Length; j++)
				{
					if (digits[j] < digits[i])
					{
						int temp = digits[i];
						digits[i] = digits[j];
						digits[j] = temp;
					}
				}
				
			}

			//foreach (int digit in digits)
			//{
			//	Console.Write(digit + " ");
			//}


			int[] a = digits.Reverse().ToArray();

			digits = digits.Reverse().ToArray();


			//Console.WriteLine(string.Join(" ", digits));
			

			Console.WriteLine(string.Join(" ", digits));

			

		}

	}
}
