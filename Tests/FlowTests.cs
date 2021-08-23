using System;
using System.Threading;
using Xunit;

namespace Tests
{
    public class FlowTests
    {
        [Fact]
        public void NeverEndingProgram()
        {
            int counter = 0;

            while (true)
            {
                counter += 1;
            }
        }

        [Fact]
        public void FastProgram()
        {
            int counter = 0;

            counter += 1;

            Assert.Equal(1, counter);
        }

        [Fact]
        public void SlightlySlowProgram()
        {
            int counter = 0;

            while (counter < int.MaxValue)
            {
                counter += 1;
            }

            Assert.Equal(int.MaxValue, counter);
        }

        [Fact]
        public void IllegalProgram()
        {
            int zero = 0;
            int notAllowed = 5 / zero;
        }

        [Fact]
        public void ProgramWithBreak()
        {
            int counter = 0;

            Thread.Sleep(10 * 1000);

            counter += 1;

            Thread.Sleep(10 * 1000);

            Assert.Equal(1, counter);
        }

        [Fact]
        public void ProgramWithSuddenEnd()
        {
            int counter = 0;

            while (counter < int.MaxValue)
            {
                counter += 1;
                
                if (counter == 3)
                {
                    return;
                }
            }

            Assert.Equal(1, counter);
        }
    }
}
