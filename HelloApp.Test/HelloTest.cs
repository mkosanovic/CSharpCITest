using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace HelloApp.Test
{
    [TestFixture]
    public class HelloTest
    {
        [Test]
        public void WorldIsSafe()
        {
            // arrange
            bool isTrue;

            // act
            isTrue = true;

            // assert
            isTrue.ShouldBe(true);
        }

        [Test]
        public void RandomTest()
        {
        }
    }
}
