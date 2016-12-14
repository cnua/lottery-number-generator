/*
 Copyright 2016 wakeelu mamudu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGeneratorLib
{
    /// <summary>
    /// This is the class that complies to the assignment specification, hence the name
    /// parameterised constructor specifies number of lottery number sets to produce for the ticket
    /// </summary>
    public class CapitaLotteryTicket : ILotteryTicket
    {
        private readonly string _ticketReference;
        private List<int[]> _numberSet;
        private IGenerator _generator;
        /*these numbers make this implementation Capita specific*/
        private const int _setCount=6;
        private const int _minNumberSet = 1;
        private const int _maxNumberSet = 49;

        private const string _fileExtension = ".txt";
        private readonly string _fileDirectory = "";

        public CapitaLotteryTicket(int numberSetCount, string fileDirectory="")
        {
            _generator = new CapitaGenerator();
            _ticketReference = _generator.GetTicketReference();

            var lst = new List<int[]>();
            for(int i = 0; i < numberSetCount; i++)
            {
                var arr = _generator.GetNumberSet().ToArray();
                lst.Add(arr);
            }
            _numberSet = lst;
        }
        /// <summary>
        /// Lottery numbers range from 1-49 inclusive.
        ///A non-repeating set of six lottery numbers.
        /// </summary>
        public IEnumerable<IEnumerable<int>> NumberSet
        {
            get
            {
                return _numberSet;
            }

        }
        /// <summary>
        /// A unique identifier for the ticket
        /// </summary>
        public string TicketReference
        {
            get
            {
                return _ticketReference;
            }

        }

        /// <summary>
        /// Save a copy of every ticket created on the server
        /// use ticket reference as file name
        /// </summary>
        public void Save()
        {
            /*convert to an array of strings*/
            var arr = new string[_numberSet.Count];
            for (int i = 0; i < _numberSet.Count; i++)
            {
                arr[i] = string.Join(",", _numberSet[i]);
            }
            arr.OrderByDescending(n=>n);
            System.IO.File.WriteAllLines(_fileDirectory + _ticketReference + _fileExtension, arr);
        }
    }
}
