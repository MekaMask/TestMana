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
            var result = cm.Pay(640, 1000);
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


        [Theory]
        [InlineData(324, 1000, new int[] { 0, 1, 1, 1, 1, 0, 1, 1 })]
        [InlineData(1456, 2345, new int[] { 0, 1, 3, 1, 1, 1, 1, 4 })]
        [InlineData(1456, 5000, new int[] { 3, 1, 0, 0, 2, 0, 0, 4 })]
        public void TestChange(int price, int pay, int[] expected)
        {
            var cm = new CalculateController();
            var result = cm.Pay(price, pay);
            Assert.Equal(expected[0], result.countThousand);
            Assert.Equal(expected[1], result.countFiveHundred);
            Assert.Equal(expected[2], result.countOneHundred);
            Assert.Equal(expected[3], result.countFifty);
            Assert.Equal(expected[4], result.countTwenty);
            Assert.Equal(expected[5], result.countTen);
            Assert.Equal(expected[6], result.countFive);
            Assert.Equal(expected[7], result.countOne);

        }




        // [Theory]
        // [InlineData(400,500,)]
        // public void Test2(int price, int pay, countMoney expected)
        // {
        //     var cal = new CalculateController();
        //     var result = cal.Pay(price, pay);


        //     Assert.Equal(expected.countThousand, result.countThousand);
        //     Assert.Equal(expected.countFiveHundred, result.countFiveHundred);
        //     Assert.Equal(expected.countOneHundred, result.countOneHundred);
        //     Assert.Equal(expected.countFifty, result.countFifty);
        //     Assert.Equal(expected.countTwenty, result.countTwenty);
        //     Assert.Equal(expected.countTen, result.countTen);
        //     Assert.Equal(expected.countFive, result.countFive);
        //     Assert.Equal(expected.countOne, result.countOne);


        // }

        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(6, 5, 11)]
        [InlineData(3, 5, 8)]
        [InlineData(11, 5, 16)]
        public void TestAdd(int a, int b, int expected)
        {
            var addition = new CalculateController();
            var result = addition.Add(a, b);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(6, 5, 1)]
        [InlineData(7, 5, 2)]
        [InlineData(11, 5, 6)]
        public void TestMunus(int a, int b, int expected)
        {
            var minustion = new CalculateController();
            var result = minustion.Minus(a, b);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(6, 5, 30)]
        [InlineData(7, 5, 35)]
        [InlineData(11, 5, 55)]
        public void TestMultiple(int a, int b, int expected)
        {
            var multiple = new CalculateController();
            var result = multiple.Multiple(a, b);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(6, 3, 2)]
        [InlineData(35, 5, 7)]
        [InlineData(24, 6, 4)]
        public void TestDevide(int a, int b, int expected)
        {
            var devide = new CalculateController();
            var result = devide.Devide(a, b);

            Assert.Equal(expected, result);

        }





    }
}
