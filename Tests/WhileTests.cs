using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class WhileTests
    {
        [Fact]
        public void WithoutWhile()
        {
            int counter = 0;

            counter += 1;
            counter += 1;
            counter += 1;

            Assert.Equal(3, counter);
        }

        [Fact]
        public void WithWhile()
        {
            int counter = 0;

            while (counter != 3)
            {
                counter += 1;
            }

            Assert.Equal(3, counter);
        }

        [Fact]
        public void ImpossibleWithoutWhile()
        {
            int counter = 0;

            while (counter != 2147483647)
            {
                counter += 1;
            }

            Assert.Equal(2147483647, counter);
        }
    }
}
