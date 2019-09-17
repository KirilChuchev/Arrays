using System;
using System.Linq;

namespace _8._Magic_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int[] integers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			int number = int.Parse(Console.ReadLine());

			int sum = 0;

			for (int i = 0; i < integers.Length; i++)
			{
				for (int j = i + 1; j < integers.Length; j++)
				{
					if (integers[i] + integers[j] == number)
					{
						Console.WriteLine($"{integers[i]} {integers[j]}");
					}
				}
			}
		}
	}
}
