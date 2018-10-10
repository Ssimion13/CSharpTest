using System;

namespace CsharpTestingChamber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(checkScore(21));
            Console.WriteLine(checkScore(22));
            Console.WriteLine(checkScore(18));
            Console.WriteLine(checkScore(20));
            checkScoreTwo(21);
            checkScoreTwo(22);
            checkScoreTwo(20);
            checkScoreTwo(18);
            Console.WriteLine(comparison(20, 22));
            Console.WriteLine(comparison(22, 22));
            Console.WriteLine(comparison(18, 16));
        }

        //A constructor is a method whose name is the same as its type.

        public class Person
        {
            public string last;
            public string first;

            public Person(string lastName, string firstName)
            {
                last = lastName;
                first = firstName;
            }
        }




        static String checkScore(int x)
        {
            if (x > 20)
                return "Hello";
            else
                return "World";
        }

        static void checkScoreTwo(int score)
        {
            switch (score)
            {
                case 20:
                    Console.WriteLine("Hello");
                    break;
                case 18:
                    Console.WriteLine("Worldy");
                    break;
                case 21:
                    Console.WriteLine("21 is a pretty cool guy");
                    break;
                default:
                    Console.WriteLine("Not one of the switched values");
                    break;
            }
        }

        static String comparison(int first, int second)
        {
            if (first > second)
            /* huh, in C# you don't necessarily need the curly braces. */
            {
                return "The first is better than the second";
            }
            else if (second > first)
            {
                return "The second is better than the first";
            }
            else return "They are equal.";
        }
    }
}
