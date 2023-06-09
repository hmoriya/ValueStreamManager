namespace Archway.SharedKernel.Domain.Specifications;

public class IsNullOrWhiteSpaceSpecification : Specification<string>
{
    public override bool IsSatisfiedBy(string value)
    {
        return string.IsNullOrWhiteSpace(value);
    }
}