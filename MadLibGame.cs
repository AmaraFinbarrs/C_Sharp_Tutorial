using System;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.Write("Roses are " + color + "\n");
            Console.Write(pluralNoun + " are blue\n");
            Console.Write("I Love " + celebrity + "\n");
        }

    }
}

