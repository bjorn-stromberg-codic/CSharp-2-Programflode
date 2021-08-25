using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

        [Fact]
        public void ASmallerThanF()
        {
            char a = 'A';
            char f = 'F';

            Assert.True(a < f);
        }

        [Fact]
        public void FEqualsF()
        {
            char f = 'F';

            Assert.Equal('F', f);
        }

        [Fact]
        public void IncreaseFromAToB()
        {
            char ch = 'A';

            ch = (char) (ch + 1);

            Assert.Equal('B', ch);
        }

        [Fact]
        public void TestWhileInsideWhile()
        {
            Color color = Color.Aqua;
            char col = 'A';
            int row = 1;

            while (col < 'F')
            {
                col = (char) (col + 1);
                while (row < 17)
                {
                    Color bgColor = color;
                }
            }
        }

        [Fact]
        public void EToX()
        {
            // Utmaning, att byta alla e till x
            string testString = "hello there fellow human";
            char[] charSerie = testString.ToCharArray();

            int index = 0;
            while (index < charSerie.Length)
            {
                //vi behöver en if() här

                // Detta förändrar innehållet
                charSerie[index] = 'a';

                // Man kan lägga inneållet i en variabel med
                char ch = charSerie[index];
            }

            testString = new string(charSerie);
            Assert.Equal("hxllo thxrx fxllow human", testString);
        }
    }
}
