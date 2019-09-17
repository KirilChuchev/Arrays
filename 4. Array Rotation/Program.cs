using System;
using System.Linq;

namespace _4._Array_Rotation
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string[] array = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			int n = int.Parse(Console.ReadLine());

			string temp = string.Empty;

			for (int i = 0; i < n; i++)
			{
				temp = array[0];

				for (int j = 0; j <= array.Length - 2; j++)
				{
					array[j] = array[j + 1];
				}

				array[array.Length - 1] = temp;
			}

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
	}
}
