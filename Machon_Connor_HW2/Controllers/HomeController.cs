//Author: Connor Machon 
//Date: 9/23/2020
//Assignment: Homework 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Machon_Connor_HW2.Models;

namespace Machon_Connor_HW2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckoutWalkup()
        {
            return View();
        }
        public IActionResult WalkupTotals(WalkupOrder walkupOrder)
        {
            TryValidateModel(walkupOrder);

            if (ModelState.IsValid == false)
            {
                return View("CheckoutWalkup", walkupOrder);
            }

            //if it makes it to here then it's valid

            //set customer type
            walkupOrder.CustomerType = CustomerType.Walkup;
            //call calulate totals method from walkuporder
            walkupOrder.CalcTotals();
            //display walkuptotals view
            return View("WalkupTotals", walkupOrder);
        }
        public IActionResult CheckoutWholesale()
        {
            return View();
        }
        public IActionResult WholesaleTotals(WholesaleOrder wholesaleOrder)
        {
            TryValidateModel(wholesaleOrder);

            if (ModelState.IsValid == false)
            {
                return View("CheckoutWholesale", wholesaleOrder);
            }

            //set customer type
            wholesaleOrder.CustomerType = CustomerType.Wholesale;
            //Call calculate method
            wholesaleOrder.CalcTotals(wholesaleOrder.DeliveryFee);
            //display wholesaletotals view
            return View(wholesaleOrder);
        }
    }
}
