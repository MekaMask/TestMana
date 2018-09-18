using System;
using TestApi.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace TestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cm = new CalculateController();
            var result = cm.Pay(640,1000);
            var expected = new countMoney
            {
                countThousand = 0,
                countFiveHundred = 0,
                countOneHundred = 3,
                countFifty = 1,
                countTwenty = 0,
                countTen = 1,
                countFive = 0,
                countOne = 0
            };

            Assert.Equal(expected.countThousand, result.countThousand);
            Assert.Equal(expected.countFiveHundred, result.countFiveHundred);
            Assert.Equal(expected.countOneHundred, result.countOneHundred);
            Assert.Equal(expected.countFifty, result.countFifty);
            Assert.Equal(expected.countTwenty, result.countTwenty);
            Assert.Equal(expected.countTen, result.countTen);
            Assert.Equal(expected.countFive, result.countFive);
            Assert.Equal(expected.countOne, result.countOne);

        }
        

        // public void Test2() {
        //     var addition = new CalculateController();
        //     var sum = addition.Add(4,5);
        //     var expected = 
        // }


    
    }
}
