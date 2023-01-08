using System;

namespace FridayNightRandom
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayRandomFood();
			DisplayRandomDrink();
			DisplayRandomMovie();
		}
		private static int GenerateRandomIndex(string[] sameArray)
		{
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, sameArray.Length);
			return randomIndex;
		}

		private static void DisplayRandomFood()
		{
			string[] foods = { "chicken wings", "pizza", "sushi", "popocorn", "salad" };

			Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
		}
		private static void DisplayRandomDrink()
		{
			string[] drinks = { "apple juice", "coke", "fanta", "sprite" };

			Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
		}
		private static void DisplayRandomMovie()
		{
			string[] movies = { "Forest Gump", "Gladiator", "Avatar", "Perl Harbor" };

			Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
		}
	}
}
