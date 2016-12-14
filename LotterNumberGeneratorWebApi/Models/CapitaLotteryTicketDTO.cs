using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotterNumberGeneratorWebApi.Models
{
    /// <summary>
    /// Lottery Ticket Data Object
    /// </summary>
    public class CapitaLotteryTicketDTO 
    {
        /// <summary>
        /// Lottery numbers range from 1-49 inclusive.
        ///A non-repeating set of six lottery numbers.
        /// </summary>
        public IEnumerable<IEnumerable<int>> NumberSet { get; set; }
        /// <summary>
        /// A unique identifier for the ticket
        /// </summary>
        public string TicketReference { get; set; }
    }
}
