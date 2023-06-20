namespace Archway.SharedKernel.Domain.Specifications;

public class NotNullOrWhiteSpaceSpecification : Specification<string>
{
    public override bool IsSatisfiedBy(string value)
    {
        // null や空白文字列でないことをチェックする
        return !string.IsNullOrWhiteSpace(value);
    }
}