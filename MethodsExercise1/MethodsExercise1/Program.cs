using System;

namespace MethodsExercise1
{
    internal class Storytelling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am a storytelling program. All I need to begin is a few pieces of information. What should I call you?");
            var firstName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {firstName}. What is your favorite food?");
            var favoriteFood = Console.ReadLine();

            Console.WriteLine("Now, in what year were you born?");
            var birthYear = Console.ReadLine();

            Console.WriteLine("What about your birthplace?");
            var birthPlace = Console.ReadLine();

            Console.WriteLine("If you could live in any city in the world, where would you want to live?");
            var cityName = Console.ReadLine();

            Console.WriteLine("Lastly, if you could be any animal, what would you want to be?");
            var animal = Console.ReadLine();

            Console.WriteLine("Alright, I think I have a good story for you.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();

            Console.WriteLine($"{animal}tatouille, by {firstName}.");

            Console.WriteLine($"One sunny day in {birthYear}, a baby {animal} was brought into this world. But - this was no ordinary {animal}. \n" +
                $"This {animal} had the potential to become a world class {favoriteFood} chef. \n" +
                $"No human would dare give a {animal} the chance to learn fine cuisine in {birthPlace}, so how would {firstName} realize their dreams of Michelin Star-level {favoriteFood} creation?");

            Console.WriteLine();
            Console.WriteLine($"It would take a great trek to unknown lands, known as {cityName} to start this venture. There, rumors began to spread of a world-renowned chef mentoring a young {animal}. \n" +
                $"Fast-forward to the year 2022, {cityName} is home to the legendary {animal} chef, {firstName} - providing visitors and critics with a {favoriteFood} experience great enough to bring Gordon Ramsay to tears.");

        }
    }
}
