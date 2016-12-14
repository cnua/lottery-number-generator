using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryNumberGeneratorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LotteryNumberGeneratorLib.Tests
{
    [TestClass()]
    public class CapitaLotteryTests
    {
        [TestMethod()]
        public void CapitaLottery_CreateTicketWithSingleNumberSet()
        {
            var obj = new CapitaLotteryTicket(1);
            int expected = 1;
            int actual = obj.NumberSet.Count();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CapitaLottery_CreateTicketWithMultipleNumberSet()
        {
            const int numberSetCount = 7;
            var obj = new CapitaLotteryTicket(numberSetCount);
            int expected = numberSetCount;
            int actual = obj.NumberSet.Count();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CapitaLottery_VerifyTicketNumber()
        {
            var obj = new CapitaLotteryTicket(1);
            int expected = 32;
            int actual = obj.TicketReference.Length;

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///  verify its been written as the ticket reference
        /// </summary>
        [TestMethod()]
        public void Save_NamedAsNumberSetReferenceTextFile()
        {
            /*IO testing out of this scope, will slow down testing generally*/
            const int numberSetCount = 7;
            const string fileExtension = ".txt";
            var obj = new CapitaLotteryTicket(numberSetCount);
            obj.Save();
            var expected = true;
            string actual;
            /*open the saved file to verify its been written as the ticket reference*/
            using (StreamReader strm = new StreamReader(obj.TicketReference + fileExtension))
            {
                actual = strm.ReadToEnd();
            }

            Assert.AreEqual(expected,actual.Length > 6);
        }


    }
}