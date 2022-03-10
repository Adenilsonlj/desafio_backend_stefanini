using System;

namespace Example.Domain.ExampleAggregate
{
    public class InvalidAgeExceptions : ArgumentException
    {
        public InvalidAgeExceptions(): base("Example cannot be that old.")
        {
        }
    }
}
