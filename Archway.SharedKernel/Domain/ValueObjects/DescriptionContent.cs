using Archway.SharedKernel.Domain.Exceptions;
using Archway.SharedKernel.Domain.Specifications;

namespace Archway.SharedKernel.Domain.ValueObjects;

public class DescriptionContent : ValueObject
{
    public string Value { get; }

    private const int MaxLength = 512;

    public DescriptionContent(string value)
    {
        Validate(value);
        Value = value;
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
    private static void Validate(string value)
    {
        Specification<string> notNullOrEmptySpec = new NotNullOrWhiteSpaceSpecification();
        Specification<string> maxLengthSpec = new MaxLengthSpecification(MaxLength);

        if (!notNullOrEmptySpec.IsSatisfiedBy(value))
        {
            throw new ValueNotValidException("Value cannot be null or empty.");
        }

        if (!maxLengthSpec.IsSatisfiedBy(value))
        {
            throw new ValueExceedsMaxLengthException("Value exceeds the maximum length.");
        }
    }
}