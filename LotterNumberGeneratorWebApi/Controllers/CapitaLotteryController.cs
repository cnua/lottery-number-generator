/*
 Copyright 2016 wakeelu mamudu
 */using System;
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
    public class CapitaLotteryController : ApiController
    {
        /// <summary>
        /// Generate Capita Lottery Ticket. This demonstrates the original objects and interfaces can be used out of the box and is serialised without modification
        /// </summary>
        /// <param name="numberSetCount">Number sets in ticket</param>
        /// <returns>ILotteryTicket</returns>
        public ILotteryTicket GetCapitaLotteryTicket(int numberSetCount)
        {
            string fileDirectory = "";
            return new CapitaLotteryTicket(numberSetCount, fileDirectory);
        }

    }
}
