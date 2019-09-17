using System;
using System.Linq;

namespace _2._Common_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			string line1 = Console.ReadLine();
			string line2 = Console.ReadLine();

			string[] texst1 = line1.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			string[] texst2 = line2.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < texst1.Length; i++)
			{
				for (int j = 0; j < texst2.Length; j++)
				{
					if (texst2[j] == texst1[i])
					{
						Console.Write(texst1[i] + " ");
					}
				}
			}

			Console.WriteLine(Environment.NewLine);
			
		}
	}
}
