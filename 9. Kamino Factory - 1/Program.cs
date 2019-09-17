using System;
using System.Linq;

namespace _9._Kamino_Factory___1
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;

			int bestIndex = input.Length - 1;
			int greaterSum = 0;
			string dnaNeeded = string.Empty;

			while ((input = Console.ReadLine()) != "Clone them!")
			{
				int[] dna = input.Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				int counter = 1;
				int maxCounterOnes = 0;
				bestIndex = 0;
				greaterSum = 0;

				int sumElements = dna.Sum();

				for (int i = dna.Length - 1; i >= 1; i--)
				{
					
					if (dna[i] == dna[i - 1] && dna[i] == 1)
					{
						counter++;
						if (counter >= maxCounterOnes)
						{
							if (i <= bestIndex)
							{
								if (sumElements >= greaterSum)
								{

									maxCounterOnes = counter;
									bestIndex = i - 1;
									greaterSum = sumElements;


									for (int j = 0; j < dna.Length; j++)
									{
										dnaNeeded += dna[i] + " ";
									}
								}
							}
							
						}
					}
					else
					{
						counter = 1;
					}
				}
			}

			Console.WriteLine($"Best DNA sample {bestIndex} with sum: {greaterSum}.");

			Console.WriteLine(dnaNeeded);

			
		}
	}
}
