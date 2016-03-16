using ConsoleApplication1.Models;
using System;
using Xunit;

namespace UnitTestProject.Models
{
    /// <summary>
    /// Summary description for PersonUnitTest
    /// </summary>
    public class PersonUnitTest
    {
        [Theory]
        [InlineData("Mercier", "Pierre", "Hello Mercier Pierre")]
        [InlineData(null, null, "Hello Anonymous")]
        [InlineData("", "", "Hello Anonymous")]
        [InlineData(" ", " ", "Hello Anonymous")]
        public void SayHello_Should_ReturnCorrectly(string lastname, string firstname, string expectedResult)
        {
            var person = new Person { LastName = lastname, FirstName = firstname };
            string result = person.SayHello();
            Assert.Equal<string>(expectedResult, result);
        }

        [Theory]
        [InlineData("Mercier", "Pierre", "pierre.mercier@orange.com")]
        public void GenerateEmail_Should_ReturnCorrectly(string lastname, string firstname, string expectedResult)
        {
            var person = new Person { LastName = lastname, FirstName = firstname };
            string result = person.GenerateEmail();
            Assert.Equal<string>(expectedResult, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData(" ", " ")]
        public void GenerateEmail_ShouldThrowArgumentNullException(string lastname, string firstname)
        {
            var person = new Person { LastName = lastname, FirstName = firstname };
            Assert.Throws<ArgumentNullException>(() => person.GenerateEmail());
        }
    }
}
