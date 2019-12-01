using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StudentOlder_01
    {
        private string _firstName;
        public string FirstName { get { return _firstName; } }
        private string _lastName;
        public string LastName { get { return _lastName; } }
        public StudentOlder_01(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException(message: "Cannot be blank", paramName: nameof(lastName));
            _firstName = firstName;
            _lastName = lastName;
        }
    }
    public class StudentOlder_02
    {
        private readonly string _firstName;
        public string FirstName { get { return _firstName; } }
        private readonly string _lastName;
        public string LastName { get { return _lastName; } }
        public StudentOlder_02(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException(message: "Cannot be blank", paramName: nameof(lastName));
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}
