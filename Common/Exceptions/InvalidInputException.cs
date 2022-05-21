using System;
namespace Common.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string input) : base(String.Format("Invalid input: {0}", input))
        {
        }
    }
}

