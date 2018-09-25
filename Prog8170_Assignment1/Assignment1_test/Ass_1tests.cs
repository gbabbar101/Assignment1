using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog8170_Assignment1;
using NUnit.Framework;

namespace Assignment1_test
{
    [TestFixture]
    class Ass_1tests
    {
        [Test]
        public void GetLength_input3_expectLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);

        }
        [Test]
        public void GetWidth_input5_expectWidthEquals5()
        {
            //Arrange
            int l = 3;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);

        }

        [Test]
        public void SetLength_input3_expectLengthEquals3()
        {
            //Arrange
            int length = 3;
            Rectangle testRectangle = new Rectangle();

            //Act
            testRectangle.SetLength(length);

            //Assert
            Assert.AreEqual(length, 3);

        }

        [Test]
        public void SetWidth_input5_expectLengthEquals5()
        {
            //Arrange
            int width = 5;
            Rectangle testRectangle = new Rectangle();

            //Act
            testRectangle.SetLength(width);

            //Assert
            Assert.AreEqual(width, 5);

        }

        [Test]

        public void GetPerimeter_input4_expectPerimeterEquals16()
        {
            //Arrange
            int length = 5;
            int width = 5;
            Rectangle testRectangle = new Rectangle(length,width);

            //Act
            int Result = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(Result, 20);


        }

        [Test]

        public void GetArea_input4_expectAreaEquals16()
        {
            //Arrange
            int length = 5;
            int width = 5;
            Rectangle testRectangle = new Rectangle(length, width);

            //Act
            int Result = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(Result,25);

        }








    }
}
