using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[] arr1 = new int[n];
			int[] arr2 = new int[n];

			for (int i = 1; i <= n; i++)
			{
				int[] temp = Console
					.ReadLine()
					.Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				if (i % 2 != 0)
				{
					arr1[i-1] = temp[0];
					arr2[i-1] = temp[1];
				}
				else
				{
					arr2[i - 1] = temp[0];
					arr1[i - 1] = temp[1];
				}

				
			}

			for (int i = 0; i < n; i++)
			{
				Console.Write(arr1[i] + " ");

				
			}

			Console.Write(Environment.NewLine);

			for (int i = 0; i < n; i++)
			{
				

				Console.Write(arr2[i] + " ");
			}

			Console.WriteLine(Environment.NewLine);
		}
	}
}
