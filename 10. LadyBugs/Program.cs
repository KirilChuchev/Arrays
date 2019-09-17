using System;
using System.Linq;

namespace _10._LadyBugs
{
	class Program
	{
		static void Main(string[] args)
		{
			int fildSize = int.Parse(Console.ReadLine());
			int[] fild = new int[fildSize];						//fildSize = fild.Length

			string initialIndexesAsString = Console.ReadLine();

			int[] initialIndexes = initialIndexesAsString
				.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int totalLadyBugs = 0;

			for (int i = 0; i < initialIndexes.Length; i++)			//определяне на броя калинки с валидни индекси
			{
				if (initialIndexes[i] < fildSize)
				{
					totalLadyBugs++;
				}
			}

			int[] correctInitialIndexes = new int[totalLadyBugs];        //totalLadyBugs = correctInitialIndexes.Length
			int count = 0;
			for (int i = 0; i < initialIndexes.Length; i++)
			{
				if (initialIndexes[i] < fildSize)                   //	correctInitialIndexes.Length (totalLadyBugs) <= initialIndexes.Length <= fild.Length (fildSize)
				{													//  така че totalLadyBugs <= fildSize
					correctInitialIndexes[count] = initialIndexes[i];
					count++;
				}
				
			}

			for (int i = 0; i < correctInitialIndexes.Length; i++)
			{
				fild[correctInitialIndexes[i]] = 1;
			}

			//Console.WriteLine(string.Join(" ", correctInitialIndexes));

			//Console.WriteLine(string.Join(" ", fild));

			
			string command = string.Empty;

			while ((command = Console.ReadLine()) != "end")
			{
				string[] instructions = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

				int ladyBugInPosition = int.Parse(instructions[0]);
				string actionDirection = instructions[1];
				int actionLength = int.Parse(instructions[2]);


				int ladyBugInPositionNext = ladyBugInPosition;
				fild[ladyBugInPosition] = 0;
				

				while (true)
				{
					if (actionDirection == "right")
					{
						ladyBugInPositionNext += actionLength;
					}
					else if (actionDirection == "left")
					{
						ladyBugInPositionNext -= actionLength;
					}

					if (ladyBugInPositionNext >= 0 && ladyBugInPositionNext < fildSize)   // ladyBugInPositionNext < 0 || ladyBugInPositionNext >= fildSize
					{
						if (fild[ladyBugInPositionNext] == 0)
						{
							fild[ladyBugInPositionNext] = 1;
							break;
						}
						else
						{
							continue;
						}

					}
					else
					{
						break;
					}
					
				}

			}

			Console.WriteLine(string.Join(" ", fild));
		}
	}
}
