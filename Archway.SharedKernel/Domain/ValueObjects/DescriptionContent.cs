namespace Archway.SharedKernel.Domain.ValueObjects;

public class DescriptionContent : ValueObject
{
    public string Value { get; }

    public const int MinLength = 0;
    public const int MaxLength = 512;

    public DescriptionContent(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("DescriptionContent cannot be null or empty.", nameof(value));
        if (value.Length < MinLength || value.Length > MaxLength)
            throw new ArgumentException($"DescriptionContent length must be between {MinLength} and {MaxLength} characters.", nameof(value));
        Value = value;
    }
    public static ValidSpecification<TitleName> GetLengthSpecification()
    {
        return new ValidSpecification<TitleName>(desc => desc.Value.Length >= MinLength && desc.Value.Length <= MaxLength);
    }
    public override bool Equals(ValueObject? other)
    {
        if (other is null || GetType() != other.GetType())
            return false;

        return Value == ((DescriptionContent)other).Value;
    }

    protected override int GetCustomHashCode()
    {
        return Value.GetHashCode();
    }
}