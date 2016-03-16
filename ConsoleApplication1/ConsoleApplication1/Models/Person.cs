using System;

namespace ConsoleApplication1.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SayHello()
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                return "Hello Anonymous";

            return $"Hello {LastName} {FirstName}";
        }

        public string GenerateEmail()
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                throw new ArgumentNullException("FirstName or LastName cannot be null or empty");

            return $"{FirstName}.{LastName}@orange.com".ToLower();
        }
    }
}
