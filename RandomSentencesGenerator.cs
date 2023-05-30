using System;

namespace Random_Sentences_Generator
{
    internal class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Martin", "Nikolay", "Georgi", "Megi", "Dani", "Estela", "Nikoleta", "Plamen", "Stoian" };

            string[] places = { "Varna", "Sofia", "Konstantinovo", "Plovdiv", "Beloslav", "Shumen", "Chenge", "Tulenovo", "Kavarna", "Balchick" };

            string[] verbs = { "eats", "holds", "sees", "plays with", "brings", "hits", "catches" };

            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes", "cup", "a book", "cable" };

            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };

            string[] details = { "near the river", "at home", "in the park", "on work" , " in the sea" , "in the garden" , "in the cinema" };

            Console.WriteLine("Hello i'm Martin .");
            Console.WriteLine("This is your first random-generated sentence: ");

            while (true)
            {
                Console.WriteLine("--------------------------------------");
                string randomName = GetRandomWord(names);
                string randomPlaces = GetRandomWord(places);
                string randomVerbs = GetRandomWord(verbs);
                string randomNouns = GetRandomWord(nouns);
                string randomAdverbs = GetRandomWord(adverbs);
                string randomDetails = GetRandomWord(details);

                string who = $"{randomName} from {randomPlaces}";
                string actions = $"{randomAdverbs} {randomVerbs} {randomNouns}";
                string sentence = $"{who} {actions} {randomDetails}";
                Console.WriteLine();
                Console.WriteLine(sentence);
                Console.WriteLine();
                Console.WriteLine("Click [Enter] to next one. ");

                Console.ReadLine();
            }
        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}