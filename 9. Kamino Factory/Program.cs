using System;
using System.Linq;

namespace _9._Kamino_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			int DNA_length = int.Parse(Console.ReadLine());

			string command = string.Empty;

			int currentCountSubsequenceOnes = 0;
			int currentFirstIndexOnes = 0;
			int sumAllOnes = 0;
			int currentCountSubsequenceOnesMax = 0;

			string arrayString = string.Empty;
			

			int firstIndexOnesMin = DNA_length - 1;
			int sumAllOnesMax = 0;

			int counterArray = 0;
			int bestSequenceIndex = 0;
			int countSubsequenceOnesMax = 0;
			int countSubsequenceOnes = 0;

			bool one = false;
			bool two = false;

			

			while ((command = Console.ReadLine()) != "Clone them!")
			{
				int[] elements = command.Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				int[] elementsNeeded = new int[elements.Length];
				counterArray++;

				for (int i = 0; i < DNA_length; i++)
				{
					

					

					for (int j = i; j < DNA_length; j++)        // opredelqne na currentCountSubsequenceOnesMax
					{
						if (elements[i] == elements[j])
						{
							currentCountSubsequenceOnes++;
						}
						else
						{
							
							break;
						}
					}

					if (currentCountSubsequenceOnes >= currentCountSubsequenceOnesMax)       // opredelqne na currentCountSubsequenceOnesMax
					{
						currentCountSubsequenceOnesMax = currentCountSubsequenceOnes;
						currentCountSubsequenceOnes = 0;
					}
				}

				// end of current sequence

				
				

				if (currentCountSubsequenceOnesMax > countSubsequenceOnesMax)
				{
					countSubsequenceOnesMax = currentCountSubsequenceOnesMax;
					elementsNeeded = elements;
					bestSequenceIndex = counterArray;
					currentCountSubsequenceOnesMax = 0;

					
				}
				else if (currentCountSubsequenceOnesMax == countSubsequenceOnesMax)
				{
					for (int i = 0; i < DNA_length; i++)
					{
						if (elements[i] == 1 && currentFirstIndexOnes != 1)    //opredelqne na firstIndexOnes
						{
							currentFirstIndexOnes = i;
						}
					}

					if (currentFirstIndexOnes < firstIndexOnesMin)
					{
						firstIndexOnesMin = currentFirstIndexOnes;
						elementsNeeded = elements;
						bestSequenceIndex = counterArray;
					}
					else if (currentFirstIndexOnes == firstIndexOnesMin)
					{
						for (int i = 0; i < DNA_length; i++)
						{
							if (elements[i] == 1)               // opredelqne na sumAllOnes
							{
								sumAllOnes++;
							}
						}

						if (sumAllOnes > sumAllOnesMax)
						{
							one = true;
							sumAllOnesMax = sumAllOnes;
							elementsNeeded = elements;
							bestSequenceIndex = counterArray;
						}
					}
				}

				arrayString = string.Empty;

				for (int i = 0; i < DNA_length; i++)
				{
					arrayString += elementsNeeded[i] + " ";

					
				}

				if (!one)
				{
					sumAllOnesMax = 0;
					for (int j = 0; j < DNA_length; j++)
					{
						if (elements[j] == 1)               // opredelqne na sumAllOnes
						{
							sumAllOnesMax++;
						}
					}
				}
			}


			Console.WriteLine($"Best DNA sample { bestSequenceIndex} with sum: {sumAllOnesMax}. {arrayString}");

		}
	}
}
