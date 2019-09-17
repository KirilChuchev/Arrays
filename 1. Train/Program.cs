using System;
using System.Linq;

namespace _1._Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[] train = new int[n];

			int sum = 0;

			for (int i = 0; i < n; i++)
			{

				train[i] = int.Parse(Console.ReadLine());
			}



			foreach (int people in train)
			{
				
				Console.Write(people + " ");
			}

			Console.WriteLine();
			Console.WriteLine(train.Sum());
		}
	}
}
