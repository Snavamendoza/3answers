using System;

namespace _3answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone!");

            Console.WriteLine("What type of pet is the best from these 3 choices?");
            Console.WriteLine("Choose: 1.Dog, 2.Cat, 3.Hamster");
            string response = Console.ReadLine();

            switch (response)
            { 
                case "1":
                    Console.WriteLine("You've chosen the Dog!");
                    string truth = dog();
                    Console.WriteLine(truth);
                    break;
                case "2":
                    Console.WriteLine("You've chosen the Cat!");
                    cat();
                    break;
                case "3":
                    Console.WriteLine("You've chosen the Hamster!");
                    hamster("hershey");
                    break;
                case "4":
                    Console.WriteLine("The Monkey has Chosen you!");
                    break;
                default:
                    Console.WriteLine("You have to choose!");
                    break;
            } 
        }

        private static string dog()
        {
            return "I'm the best!!!";
        }

        private static void cat()
        {
            string[] petNames = { "spot", "fluffy", "whiskers" };
            
            for (int i=0; i < petNames.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Is {0} a good name?", petNames[i]);
            }
        }

        private static void hamster( string name)
        {
            Console.WriteLine(name);
        }
    }
}
