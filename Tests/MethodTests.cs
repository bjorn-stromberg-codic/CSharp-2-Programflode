using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class MethodTests
    {
        [Fact]
        public void TwoWaysOfPassingDataToMethod()
        {
            string message1 = "Data via klassfält";
            TwoWays twoWaysDemo = new TwoWays();
            Assert.NotEqual("You said: Data via klassfält", twoWaysDemo.Echo1());

            twoWaysDemo.Message = message1;
            Assert.Equal("You said: Data via klassfält", twoWaysDemo.Echo1());

            string message2 = "Data via inparameter";
            Assert.Equal("You said: Data via inparameter", twoWaysDemo.Echo2(message2));
        }
    }

    class TwoWays
    {
        public string Message;
        public string Echo1()
        {
            return "You said: " + Message;
        }

        public string Echo2(string message)
        {
            return "You said: " + message;
        }
    }
}
