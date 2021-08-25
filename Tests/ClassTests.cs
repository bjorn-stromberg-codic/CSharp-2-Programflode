using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ClassTests
    {
        [Fact]
        public void ClassesAreUnique()
        {
            Human aHuman = new Human();
            House aHouse = new House();

            Assert.True(aHouse is House);
            Assert.True(aHuman is Human);

            Assert.False(aHuman is House);
            Assert.False(aHouse is Human);
        }

        [Fact]
        public void ClassesCanBeRelated()
        {
            var aDoctor = new Doctor();
            var aStudent = new Student();

            Assert.True(aDoctor is Human);
            Assert.True(aStudent is Human);

            Assert.False(aDoctor is Student);
            Assert.False(aStudent is Doctor);
        }
    }

    class Human
    {
        public string Name;
    }

    class House
    {
        public string Name;
    }

    class Doctor : Human
    {

    }

    class Student : Human
    {
        
    }
}
