using System;
using System.Linq;

namespace _6._Equal_Sums
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int[] array = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			int lastElement = array.Length - 1;

			int sumLeft = 0;
			int sumRight = 0;
			int sumTotal = 0;

			bool print = false;

			for (int i = 0; i <= lastElement; i++)
			{
				sumTotal += array[i];
			}


			for (int i = 0; i <= lastElement; i++)
			{
				for (int j = i + 1; j <= lastElement; j++)
				{
					sumRight += array[j];
				}

				sumLeft = sumTotal - sumRight - array[i];

				if (sumLeft == sumRight)
				{
					if (array.Length == 1)
					{
						Console.WriteLine("0");
					}
					else
					{
						Console.WriteLine(i);
					}
					print = true;
					
				}
				sumLeft = 0;
				sumRight = 0;

			}

			if (!print)
			{
				Console.WriteLine("no");
				
			}
				
		}
	}
}
