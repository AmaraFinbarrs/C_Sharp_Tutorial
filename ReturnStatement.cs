using System;

namespace myproject
{
    class ReturnStatement
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}

