﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POS.Models;
using POS.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POS.Controllers
{
    public class MockupController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/food-get")]
        public IActionResult FoodFlood()
        {
            OrderInfo newOrder = new OrderInfo();
            return PartialView("Food", newOrder );
        }

        [HttpPost("/food-add")]
        public IActionResult FoodAdd(string name, int id)
        {
            OrderInfo newOrder = new OrderInfo();
            newOrder.FindFood(id);

            return PartialView("FoodAdd", newOrder.FoundFood);
        }


    }
}
