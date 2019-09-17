using System;
using System.Linq;

namespace _5._Top_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int[] integers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			
			bool notTopInt = false;

			for (int i = 0; i <= integers.Length - 1; i++)
			{
				for (int j = i; j <= integers.Length - 2; j++)
				{
					if (integers[i] <= integers[j + 1])
					{
						notTopInt = true;
						
					}
				}

				if (!notTopInt)
				{
					Console.Write(integers[i] + " ");
					
				}

				notTopInt = false;
			}

			//Console.Write(integers[integers.Length - 1]);

			Console.Write(Environment.NewLine);
		}
	}
}
