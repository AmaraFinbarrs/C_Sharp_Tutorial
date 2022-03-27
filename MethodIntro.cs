using System;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Amara", 23);
            SayHi("Amandda", 24);
            SayHi("Finbarrs", 56);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ". You are " + age + " years old");
        }

    }
}

