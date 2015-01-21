using FizzBuzzSuite.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzzSuite.Tests
{
    [TestClass]
    public class SubstitutionTests
    {
        [TestMethod]
        public void NumberIsSet()
        {
            var sub = new Substitution(3, "Fizz");
            Assert.AreEqual(3, sub.Number);
        }

        [TestMethod]
        public void TextIsSet()
        {
            var sub = new Substitution(3, "Fizz");
            Assert.AreEqual("Fizz", sub.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNumberNotAllowed()
        {
            new Substitution(-1, "Foo");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroNumberNotAllowed()
        {
            new Substitution(0, "Foo");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullTextNotAllowed()
        {
            new Substitution(3, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyTextNotAllowed()
        {
            new Substitution(3, "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OnlySpacesInTextNotAllowed()
        {
            new Substitution(3, "  ");
        }
    }
}
