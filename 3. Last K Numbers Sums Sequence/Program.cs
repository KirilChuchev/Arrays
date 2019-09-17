using System;

namespace _3._Last_K_Numbers_Sums_Sequence
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int k = int.Parse(Console.ReadLine());

			if (n > 0 && k >= 0)
			{
				int[] numbers = new int[n];

				numbers[0] = 1;

				int temp = 0;

				for (int i = 1; i <= n - 1; i++)
				{
					for (int j = i - k; j <= i - 1; j++)
					{

						if (j >= 0)
						{
							temp += numbers[j];
						}
						else
						{
							continue;
						}

					}

					if (temp != 0)
					{
						numbers[i] = temp;
						temp = 0;
					}
				}

				for (int i = 0; i < n; i++)
				{
					Console.Write(numbers[i] + " ");
				}
				Console.WriteLine();
			}

			
		}
	}
}
