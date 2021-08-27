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
        // Method Kata 1
        [Fact]
        public void TestIntToChar()
        {
            char testCh = IntToChar(65);
            Assert.Equal('A', testCh);

            testCh = IntToChar(122);
            Assert.Equal('z', testCh);
        }

        public char IntToChar(int siffra)
        {
            return ' ';
        }

        // Method Kata 2
        [Fact]
        public void CallMe100_000TimesTest()
        {
            Assert.Equal(0, counterCallMe);

            // jobba här
            
            Assert.Equal(100_000, counterCallMe);
        }

        int counterCallMe = 0;
        public void CallMe()
        {
            counterCallMe += 1;
        }

        // Method Kata 3
        [Fact]
        public void MethodChainTest()
        {
            Assert.Equal("", lvlOrder);

            // Koppla ihop metoderna så det blir ordningen som nedan
            MethodLvl1();

            Assert.Equal("lvl1 lvl2 lvl3 lvl4 lvl3 lvl2 lvl1 ", lvlOrder);
        }

        private string lvlOrder = "";
        public void MethodLvl1()
        {
            lvlOrder += "lvl1 ";
            lvlOrder += "lvl1 ";
        }
        public void MethodLvl2()
        {
            lvlOrder += "lvl2 ";
            lvlOrder += "lvl2 ";
        }
        public void MethodLvl3()
        {
            lvlOrder += "lvl3 ";
            lvlOrder += "lvl3 ";
        }
        public void MethodLvl4()
        {
            lvlOrder += "lvl4 ";
        }

        // Method Kata 4
        [Fact]
        public void OändligaAnrop()
        {
            // sätt A att kalla på B och viseversa
            // och steppa och se vad som händer :D
        }
        public void MethodA()
        {
        }
        public void MethodB()
        {
        }

        // Method Kata 5 (denna är en kluring)
        [Fact]
        public void RekursivBottleOfBeerTest()
        {
            string mySong = OneMoreBottleOfBeer("");
            Assert.Equal(Data.WholeSong, mySong);
        }

        string OneMoreBottleOfBeer(string song)
        {
            return song;
        }

        // Method Kata 6 (denna är en kluring)
        [Fact]
        public void BottleOfBeerWhileTest()
        {
            string mySong = "";

            // en smart whilesats här

            Assert.Equal(Data.WholeSong, mySong);
        }
    }
}
