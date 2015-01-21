using System;

namespace FizzBuzzSuite.Lib
{
    // I'm making a couple assumptions about validation here
    // (number can't be <= 0 and text to substitute can't be
    // null, blank, or only whitespace).
    public class Substitution
    {
        private int number;
        private string text;

        public int Number
        {
            get { return number; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Number must be greater than 0.");

                this.number = value;
            }
        }

        public string Text
        {
            get { return text; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Text cannot be null, empty, or only whitespace.");

                text = value;
            }
        }

        public Substitution(int number, string text)
        {
            Number = number;
            Text = text;
        }
    }
}
