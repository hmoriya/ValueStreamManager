namespace Archway.SharedKernel.Domain.ValueObjects;

public class NestPath : ValueObject
{
    public string Value { get; private set; }

    public NestPath(string value)
    {
        if(string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Path cannot be empty.", nameof(value));
        }

        Value = value;
    }

    public override bool Equals(ValueObject? other)
    {
        return other is NestPath path && Value == path.Value;
    }

    protected override int GetCustomHashCode() => Value.GetHashCode();

    public static NestPath operator /(NestPath a, Guid b)
    {
        return new NestPath($"{a.Value}/{b.ToString()}");
    }
}