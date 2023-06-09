namespace Archway.SharedKernel.Domain.Specifications;

public class MaxLengthSpecification : Specification<string>
{
    private readonly int _maxLength;

    public MaxLengthSpecification(int maxLength)
    {
        _maxLength = maxLength;
    }

    public override bool IsSatisfiedBy(string value)
    {
        return value?.Length <= _maxLength;
    }
}