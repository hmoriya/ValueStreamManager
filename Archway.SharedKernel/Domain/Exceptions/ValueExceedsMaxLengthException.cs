namespace Archway.SharedKernel.Domain.Exceptions;

public class ValueExceedsMaxLengthException : Exception
{
    public ValueExceedsMaxLengthException(string message) : base(message) { }
}