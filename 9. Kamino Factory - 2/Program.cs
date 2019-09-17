using System;
using System.Linq;

namespace _9._Kamino_Factory___2
{
	class Program
	{
		static void Main(string[] args)
		{
			int dnaLength = int.Parse(Console.ReadLine());

			int sampleCount = 0;
			int sampleCountBest = 0;
			int greaterSum = 0;
			string bestDna = string.Empty;
			string command = string.Empty;
			int counterSubMax = int.MinValue;

			while ((command = Console.ReadLine()) != "Clone them!")
			{
				int[] sequences = command
					.Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				sampleCount++;

				int leftmostIndex = sequences.Length;
				int counterSub = 1;
				
				int counterMax = int.MinValue;
				int leftIndex = 0;
				int sum = 0;


				for (int i = sequences.Length - 1; i > 0; i--)
				{
					if (sequences[i] == 1)
					{
						sum++;

						if (sequences[i - 1] == 1)
						{
							counterSub++;
							if (counterSub >= counterSubMax)
							{
								counterSubMax = counterSub;
								leftIndex = i - 1;
							}
						}
						else
						{
							counterSub = 1;
						}
					}
				}

				if (sequences[0] == 1)
				{
					sum++;
				}

				Console.WriteLine(counterSubMax);
				Console.WriteLine(leftIndex);
				Console.WriteLine(sum);



				if (counterSubMax > counterMax)
				{
					counterMax = counterSubMax;
					leftmostIndex = leftIndex;
					greaterSum = sum;
					bestDna = string.Join(" ", sequences);
					sampleCountBest = sampleCount;
				}
				else if (counterSubMax == counterMax && leftIndex < leftmostIndex)
				{
					counterMax = counterSubMax;
					leftmostIndex = leftIndex;
					greaterSum = sum;
					bestDna = string.Join(" ", sequences);
					sampleCountBest = sampleCount;

					Console.WriteLine("!");


				}
				else if (counterSubMax == counterMax && leftIndex == leftmostIndex && sum > greaterSum)
				{

					counterMax = counterSubMax;
					leftmostIndex = leftIndex;
					greaterSum = sum;
					bestDna = string.Join(" ", sequences);
					sampleCountBest = sampleCount;

					Console.WriteLine("!!");


					//Console.WriteLine(counterMax);
					//Console.WriteLine(leftmostIndex);
					//Console.WriteLine(greaterSum);
					//Console.WriteLine(bestDna);


					
				}
			}

			Console.WriteLine($"Best DNA sample {sampleCountBest} with sum: {greaterSum}.");
			Console.WriteLine($"{bestDna}");
		}
	}
}
