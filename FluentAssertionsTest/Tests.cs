using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionsTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_does_stuff()
        {
            var actual = new List<Interval>
            {
                new Interval { Pos = 1, Qty = -1583.7m, Price = 39.51m },
                new Interval { Pos = 2, Qty = -1412m, Price = 35.22m },
                new Interval { Pos = 3, Qty = -1400m, Price = 34.92m },
            };

            var expected = new List<Interval>
            {
                new Interval { Pos = 3, Qty = -1400m, Price = 34.92m },
                new Interval { Pos = 2, Qty = -1412m, Price = 35.22m },
                new Interval { Pos = 1, Qty = -1583.7m, Price = 39.51m },
            };

            actual.Should().BeEquivalentTo(expected);
        }
    }
    
    public class Interval
    {
        public int Pos { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
    }
}
