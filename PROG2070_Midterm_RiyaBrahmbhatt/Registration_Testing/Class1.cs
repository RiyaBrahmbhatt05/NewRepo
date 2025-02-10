using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG2070_Midterm_RiyaBrahmbhatt;
using NUnit.Framework;

namespace Registration_Testing
{
    public class Class1
    {
       [Test]
       public void name_Riya_Riya()
        {
            //Arrange
            var registration = new Registration();
            string ExpectedName = "Riya";

            // Act
            string name = registration.RegisterName(ExpectedName);

            // Assert
            Assert.That(name == ExpectedName);

        }

        [Test]
        public void name_NullOrEmpty_ArgumentNullException()
        {
            //Arrange
            var registration = new Registration();
            string ExpectedName = "HH";

            //Act
            string name = registration.RegisterName(ExpectedName);

            //Assert
            Assert.Throws<ArgumentNullException>(() => registration.RegisterName(""));

        }

        [Test]
        public void name_RIYA_RIYA()
        {
            //Arrange
            var registration = new Registration();
            string ExpectedName = "RIYA";

            //Act
            string name = registration.RegisterName(ExpectedName);

            //Assert
            Assert.That(name, Is.EqualTo("RIYA")," It should handle all Upper and Lower cse values");

        }

        public void age_10_10()
        {
            // Arrange
            var registration = new Registration();
            int ExpectedAge = 25;

            // Act
            int age = registration.RegisterAge(ExpectedAge);

            // Assert
            Assert.That(ExpectedAge == age);
        }

        [Test]
        public void Minnage_20_20()
        {
            //Arrange
            var registration = new Registration();
            int ExpectedMinAge = 20;

            //Act
            int age = registration.RegisterAge(ExpectedMinAge);

            //Assert
            Assert.That(age, Is.AtLeast(0), " The age value should not be less that the minimum valid age");

        }

        [Test]
        public void Maxage_50_50()
        {
            //Arrange
            var registration = new Registration();
            int ExpectedMaxAge = 20;

            //Act
            int age = registration.RegisterAge(ExpectedMaxAge);

            //Assert
            Assert.That(age, Is.AtMost(125), " The age value should not be more that the maximum valid age");

        }

    }
}
