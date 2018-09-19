using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/[controller]/[action]/")]
    public class CalculateController : Controller
    {

        [HttpGet("{a}/{b}")]
        public double Add(double a, double b)
        {
            var result = a + b;
            return result;
        }

        [HttpGet("{a}/{b}")]
        public double Minus(double a, double b)
        {
            var result = a - b;
            return result;
        }


        [HttpGet("{a}/{b}")]
        public double Multiple(double a, double b)
        {
            var result = a * b;
            return result;
        }

        [HttpGet("{a}/{b}")]
        public double Devide(double a, double b)
        {
            var result = a / b;
            return result;
        }


        [HttpGet("{price}/{pay}")]
        public CountMoney Pay(int price, int pay)
        {
            int result = pay - price;
            CountMoney cm = new CountMoney();

            if (result >= 1000)
            {
                cm.countThousand = result / 1000;
                result = result - (1000 * cm.countThousand);
            }

            if (result >= 500)
            {
                cm.countFiveHundred = result / 500;
                result = result - (500 * cm.countFiveHundred);
            }

            if (result >= 100)
            {
                cm.countOneHundred = result / 100;
                result = result - (100 * cm.countOneHundred);
            }

            if (result >= 50)
            {
                cm.countFifty = result / 50;
                result = result - (50 * cm.countFifty);
            }

            if (result >= 20)
            {
                cm.countTwenty = result / 20;
                result = result - (20 * cm.countTwenty);
            }

            if (result >= 10)
            {
                cm.countTen = result / 10;
                result = result - (10 * cm.countTen);
            }
            if (result >= 5)
            {
                cm.countFive = result / 5;
                result = result - (5 * cm.countFive);
            }
            if (result >= 1)
            {
                cm.countOne = result / 1;
            }
            return cm;
        }

    }



}
