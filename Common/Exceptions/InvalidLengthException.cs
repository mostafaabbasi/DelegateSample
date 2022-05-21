using System;
namespace Common.Exceptions
{
    public class InvalidLengthException : Exception
    {
        public InvalidLengthException(string name) : base(String.Format("Invalid length of name: {0}", name))
        {
        }
    }
}