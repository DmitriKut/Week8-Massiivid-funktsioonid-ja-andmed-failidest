using System;
using System.IO;

namespace ChuckNorris
{
	class Program
	{
		static void Main(string[] args)
		{
			
			
				string filePath = @"C:\Users\...\samples\chuck.txt";
				string[] dataFromFile = File.ReadAllLines(filePath);
				string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

				Console.WriteLine($"{randomElement}");

		
		}

		private static int GenerateRandomIndex(string[] dataFromFile)
		{
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, dataFromFile.Length);
			return randomIndex;
		}
	}
}
