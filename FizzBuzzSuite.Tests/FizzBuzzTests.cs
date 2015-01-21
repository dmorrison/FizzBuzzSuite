using FizzBuzzSuite.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FizzBuzzSuite.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void DefaultFizzWorks()
        {
            var fb = new FizzBuzz(10);
            var results = fb.Calculate();

            Assert.AreEqual(results[3], "Fizz");
        }

        [TestMethod]
        public void DefaultBuzzWorks()
        {
            var fb = new FizzBuzz(10);
            var results = fb.Calculate();

            Assert.AreEqual(results[5], "Buzz");
        }

        [TestMethod]
        public void CustomSubsWorks()
        {
            var subs = new List<Substitution> {
                new Substitution(3, "Fizz"),
                new Substitution(5, "Buzz"),
                new Substitution(8, "Ate"),
                new Substitution(10, "Boom")
            };
            var fb = new FizzBuzz(40, subs);
            var results = fb.Calculate();

            Assert.AreEqual(results[16], "Ate");
            Assert.AreEqual(results[10], "BuzzBoom");
        }

        [TestMethod]
        public void CustomSubsOrderIsCorrect()
        {
            var subs = new List<Substitution> {
                new Substitution(3, "Fizz"),
                new Substitution(5, "Buzz"),
                new Substitution(8, "Ate"),
                new Substitution(10, "Boom")
            };
            var fb = new FizzBuzz(40, subs);
            var results = fb.Calculate();

            Assert.AreEqual(results[40], "BuzzAteBoom");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeMaxNotAllowed()
        {
            new FizzBuzz(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroMaxNotAllowed()
        {
            new FizzBuzz(0);
        }

        [TestMethod]
        public void NullSubstitutionsIsHandled()
        {
            var fb = new FizzBuzz(3, null);
            Assert.IsNotNull(fb.Substitutions);
        }
    }
}
