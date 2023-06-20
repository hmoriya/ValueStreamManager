namespace Archway.SharedKernel.Domain.Exceptions;

public class ValueNotValidException : Exception
{
    public ValueNotValidException(string message) : base(message) { }
}