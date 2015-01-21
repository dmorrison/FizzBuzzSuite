using FizzBuzzSuite.Lib;
using System;
using System.Collections.Generic;

namespace FizzBuzzSuite.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var subs = new List<Substitution> {
                new Substitution(3, "Fizz"),
                new Substitution(5, "Buzz"),
                new Substitution(7, "Foo"),
                new Substitution(10, "Bang"),
                new Substitution(11, "Flizzy")
            };

            var fb = new FizzBuzz(100, subs);

            var results = fb.Calculate();

            foreach (var result in results.Values)
            {
                Console.WriteLine(result);
            }
        }
    }
}
