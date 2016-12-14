using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryNumberGeneratorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGeneratorLib.Tests
{
    [TestClass()]
    public class CapitaGeneratorTests
    {
        /// <summary>
        /// Test the ticket returns a string
        /// </summary>
        [TestMethod()]
        public void GetTicketReferene_ReturnsATicketString()
        {
            /*The ticket refernce is a guid; without braces and hypen has 32 characters*/
            int expected = 32;
            var obj = new CapitaGenerator();
            var ticketRef0 = obj.GetTicketReference();

            Assert.AreEqual(expected, ticketRef0.Length);
        }
        /// <summary>
        /// should have 6 non repeating numbers
        /// </summary>
        [TestMethod()]
        public void GetNumberSet_ReturnSingleNumberSet()
        {
            /**/
            int expected = 6;
            var obj = new CapitaGenerator();
            var numberSet = obj.GetNumberSet();

            Assert.AreEqual(expected, numberSet.Count());
        }
        /// <summary>
        /// a number set should have numbers between 1-49
        /// </summary>
        [TestMethod()]
        public void GetNumberSet_NumbersStayWithinSpecifiedRange()
        {
            /**/
            int min = 1;
            int max = 49;
            var obj = new CapitaGenerator();
            var numberSet = obj.GetNumberSet().ToArray();
            bool expected = false;
            bool actual = numberSet.Select(n => n).Where(x => x > max || x < min).Any();

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// a number set should have non repeating numbers
        /// </summary>
        [TestMethod()]
        public void GetNumberSet_ShouldContinNonRepeatingNumbers()
        {
            /**/
            var obj = new CapitaGenerator();
            var numberSet = obj.GetNumberSet().ToArray();
            bool expected = false;
            bool actual = numberSet.GroupBy(x => x).Any(g => g.Count() > 1);
            Assert.AreEqual(expected, actual);
        }
    }
}