using Archway.SharedKernel.Domain.Specifications;

namespace Archway.SharedKernel.Domain.ValueObjects;

public class TitleName : ValueObject
{
    public string Value { get; }

    public const int MinLength = 0;
    public const int MaxLength = 512;

    public TitleName(string value)
    {
        
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Name cannot be null or empty.", nameof(value));

        if (value.Length < MinLength || value.Length > MaxLength)
            throw new ArgumentException($"Name length must be between {MinLength} and {MaxLength} characters.", nameof(value));

        Value = value;
    }

    public override bool Equals(ValueObject? other)
    {
        if (other is null || GetType() != other.GetType())
            return false;

        return Value == ((TitleName)other).Value;
    }

    protected override int GetCustomHashCode()
    {
        return Value.GetHashCode();
    }
    
    public static ValidSpecification<TitleName> GetLengthSpecification()
    {
        return new ValidSpecification<TitleName>(name => name.Value.Length >= MinLength && name.Value.Length <= MaxLength);
    }
}



public class ValidNameLengthSpecification : Specification<TitleName>
{
    public override bool IsSatisfiedBy(TitleName titleName)
    {
        // 名前の妥当性の条件をここに実装する
        return titleName.Value.Length >= TitleName.MinLength && titleName.Value.Length <= TitleName.MaxLength;
    }
}
