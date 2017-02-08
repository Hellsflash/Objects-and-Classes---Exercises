using System;

namespace _02.Advertisement_Message
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of its category.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can’t live without this product.";

            var events = new string[6];
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles. I am happy of the results!";
            events[3] = "I cannot believe but now I feel awesome.";
            events[4] = "Try it yourself, I am very satisfied..";
            events[5] = "I feel great!";

            var author = new string[8];
            author[0] = "Diana";
            author[1] = "Petya";
            author[2] = "Stella";
            author[3] = "Elena";
            author[4] = "Katya";
            author[5] = "Iva";
            author[6] = "Annie";
            author[7] = "Eva";

            var city = new string[5];
            city[0] = "Burgas";
            city[1] = "Sofia";
            city[2] = "Plovdiv";
            city[3] = "Varna";
            city[4] = "Ruse";

            Random rng = new Random();




            for (int i = 0; i < number; i++)
            {
                var currPhrase = phrases[i];
                var currEvent = events[i];
                var currAuthor = author[i];
                var currCity = city[i];

                var phrasesIndex = rng.Next(0, phrases.Length);
                var eventIndex = rng.Next(0, events.Length);
                var authorIndex = rng.Next(0, author.Length);
                var cityIndex = rng.Next(0, city.Length);

                var temp1 = phrases[i];
                var temp2 = events[i];
                var temp3 = author[i];
                var temp4 = city[i];

                phrases[i] = temp1;
                events[i] = temp2;
                author[i] = temp3;
                city[i] = temp4;

                phrases[phrasesIndex] = currPhrase;
                events[eventIndex] = currEvent;
                author[authorIndex] = currAuthor;
                city[cityIndex] = currCity;




                Console.Write($"{phrases[cityIndex]} {events[eventIndex]} {author[authorIndex]} - {city[cityIndex]}");
                Console.WriteLine();

            }

        }
    }
}
