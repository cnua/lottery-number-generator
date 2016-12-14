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
    /// testable interfaces for implementation specific:
    ///Ticket numbers
    ///Lottery number sets
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// Generate a reference for the ticket
        /// </summary>
        /// <returns>Return a unique reference for the ticket</returns>
        string GetTicketReference();
        /// <summary>
        /// Get a set of lottery numbers
        /// </summary>
        /// <returns>Set of lottery numbers compliant to specific implementation</returns>
        IEnumerable<int> GetNumberSet();

    }
}
