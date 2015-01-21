using System;
using System.Collections.Generic;

namespace FizzBuzzSuite.Lib
{
    public class FizzBuzz
    {
        private int max;
        private List<Substitution> substitutions;

        public int Max
        {
            get { return max; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Max must be greater than 0.");

                max = value;
            }
        }

        public List<Substitution> Substitutions
        {
            get { return substitutions; }
            set
            {
                if (value == null)
                    substitutions = new List<Substitution>();
                else
                    substitutions = value;

                // TODO: We could also check if there are any duplicates
                // in the list here. Though, we wouldn't be able to guarantee
                // this later on if the list was manipulated. A different
                // data structure could be used to guarantee uniqueness (but
                // the order of substitutions would still need to be preserved).
                // Or we could choose to not expose Max and Substitutions
                // publicly.
            }
        }

        public FizzBuzz(int max)
        {
            Max = max;

            Substitutions = new List<Substitution> {
                new Substitution(3, "Fizz"),
                new Substitution(5, "Buzz")
            };
        }

        public FizzBuzz(int max, List<Substitution> substitutions)
        {
            Max = max;
            Substitutions = substitutions;
        }

        public SortedList<int, string> Calculate()
        {
            var results = new SortedList<int, string>();

            for (int i = 1; i <= Max; i++)
            {
                var result = "";

                // TODO: Checking by iterating over each substitution
                // will be slow if there are many subs in the list. Probably
                // would want to improve this.
                foreach (var sub in Substitutions)
	            {
                    if (i % sub.Number == 0)
                        result += sub.Text;
	            }

                if (result == "")
                    result = i.ToString();

                results.Add(i, result);
            }

            return results;
        }
    }
}
