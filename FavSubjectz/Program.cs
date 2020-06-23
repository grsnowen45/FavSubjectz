using System;

namespace FavSubjectz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch (subject)
            {
                case "Science":
                    Console.WriteLine("Science Stinks!");
                    break;

                case "Math":
                    Console.WriteLine("Math is the worst!");
                    break;

                case "English":
                    Console.WriteLine("English is for dummies!!");
                    break;
                case "History":
                    Console.WriteLine("Eh, History is old!!");
                    break;
                case "Coding":
                    Console.WriteLine("Ayyyyyeeee Coding Rules!");
                    break;
                default:
                    Console.WriteLine("Thats not a subject you dummy!!");
                    break;

            }
        }
    }
}
