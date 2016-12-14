/*
 Copyright 2016 wakeelu mamudu
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGeneratorLib
{
    public class CapitaGenerator : IGenerator
    {
        /**/
        private const int _setCount = 6;
        private const int _minNumberSet = 1;
        private const int _maxNumberSet = 49;
        private Random _rand=new Random();
        /// <summary>
        /// Capita specification return a non rdepeating number set between 1-49 
        /// </summary>
        /// <param name="setCount"></param>
        /// <returns></returns>
        public IEnumerable<int> GetNumberSet()
        {
            return Enumerable.Range(_minNumberSet, _maxNumberSet).OrderBy(x => _rand.Next(1, 49)).Take(_setCount);
        }
        /// <summary>
        /// Unique string represents a ticket which can be one or more number sets [capita spec]
        /// </summary>
        /// <returns></returns>
        public string GetTicketReference()
        {
            /*return guidd without hypen and braces*/
            return Guid.NewGuid().ToString("N");
        }
    }
}
