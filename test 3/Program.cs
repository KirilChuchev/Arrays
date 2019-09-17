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
				int counterSubMax = int.MinValue;
				int leftIndexCurrent = int.MaxValue;
				int leftIndex = 0;
				int sum = 0;


				for (int i = sequences.Length - 1; i > 0; i--)
				{
					if (sequences[i] == 1)
					{
						sum++;

						if (counterSub >= counterSubMax)
						{
							counterSubMax = counterSub;
							leftIndexCurrent = i;

							if (leftIndexCurrent <= leftIndex)
							{
								leftIndex = leftIndexCurrent;
							}
						}

						if (sequences[i - 1] == 1)
						{
							counterSub++;
							if (counterSub >= counterSubMax)
							{
								counterSubMax = counterSub;
								leftIndex = i - 1;

								if (leftIndexCurrent <= leftIndex)
								{
									leftIndex = leftIndexCurrent;
								}
							}
						}
						else
						{
							counterSub = 1;
						}
					}
					else
					{
						counterSub = 0;
					}
				}

				if (sequences[0] == 1)
				{
					sum++;
				}

				
				Console.WriteLine("counterSubMax: {0}", counterSubMax);
				Console.WriteLine("leftIndex: {0}", leftIndex);
				Console.WriteLine("sum: {0}", sum);
				Console.WriteLine();
			}
		}
	}
}