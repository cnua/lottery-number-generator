/*
 Copyright 2016 wakeelu mamudu
 */
using System.Collections.Generic;

namespace LotteryNumberGeneratorLib
{
    /// <summary>
    /// implement this interface to properly constrain the variation across ticket types
    /// example the Euro format and UK Lotto differences
    /// </summary>
 public    interface ILotteryTicket
    {
        IEnumerable<IEnumerable<int>> NumberSet { get; }
        /// <summary>
        /// ticket reference should be unique
        /// extends to multiset of numbers
        /// </summary>
        string TicketReference { get;}
        /// <summary>
        /// save a copy on the server
        /// note: bonus feature
        /// </summary>
        void Save();




    }
}