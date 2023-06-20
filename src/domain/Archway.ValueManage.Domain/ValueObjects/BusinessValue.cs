namespace Archway.ValueManage.Domain.ValueObjects;

public class BusinessValue : ValueObject
{
    public static readonly int MaxLength = 1024; // 最大文字列長さの制約

    public string Value { get; private set; }

    public BusinessValue(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Value cannot be empty.", nameof(value));
        }

        if (value.Length > MaxLength)
        {
            throw new ArgumentException($"Value cannot exceed {MaxLength} characters.", nameof(value));
        }

        Value = value;
    }

    public override bool Equals(ValueObject? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;

        return other is BusinessValue otherValue && Value == otherValue.Value;
    }

    protected override int GetCustomHashCode()
    {
        return Value.GetHashCode();
    }
}
