/*
 Copyright 2016 wakeelu mamudu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LotteryNumberGeneratorLib;
using LotterNumberGeneratorWebApi.Models;

namespace LotterNumberGeneratorWebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class CapitaLotteryDTOController : ApiController
    {
        /// <summary>
        /// Generate Capita Lottery Ticket. 
        /// </summary>
        /// <param name="numberSetCount">Number sets in ticket</param>
        /// <returns>A data object cast from ILotteryTicket source</returns>
        public CapitaLotteryTicketDTO GetCapitaLotteryTicketDTO(int numberSetCount)
        {
            string fileDirectory = "";
            /* todo: automapper would be used in enterprise solution to map data between the objects*/
            var obj = new CapitaLotteryTicket(numberSetCount, fileDirectory);
            return new CapitaLotteryTicketDTO() { TicketReference = obj.TicketReference, NumberSet = obj.NumberSet };
        }
    }
}
