namespace Archway.ValueManage.Domain.ValueObjects;

public class BusinessObjective : ValueObject
{
    public static readonly int MaxLength = 1024; // 最大文字列長さの制約
    public string Objective { get; private set; }

    public BusinessObjective(string objective)
    {
        if (string.IsNullOrEmpty(objective))
        {
            throw new ArgumentException("Objective cannot be empty.", nameof(objective));
        }
        if (objective.Length > MaxLength)
        {
            throw new ArgumentException($"Value cannot exceed {MaxLength} characters.", nameof(objective));
        }
        Objective = objective;
    }

    public override bool Equals(ValueObject? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;

        return other is BusinessObjective otherObjective && Objective == otherObjective.Objective;
    }

    protected override int GetCustomHashCode()
    {
        return Objective.GetHashCode();
    }
}






