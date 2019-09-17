using System;
using System.Linq;

namespace _07.MaxSequenceEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int[] elements = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			int counter = 0;
			int maxSequence = 0;
			int currentElement = 0;

			for (int i = elements.Length - 1; i > 0; i--)
			{
				if (elements[i] == elements[i - 1])
				{
					counter++;

					if (counter >= maxSequence)
					{
						maxSequence = counter;
						currentElement = elements[i];
					}
				}
				else
				{
					counter = 0;

				}
			}

			for (int i = 0; i < maxSequence + 1; i++)
			{
				Console.Write($"{currentElement} ");
			}

			//Console.Write(Environment.NewLine);
		}
	}
}
