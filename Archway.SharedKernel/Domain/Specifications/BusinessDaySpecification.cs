namespace Archway.SharedKernel.Domain.Specifications;

public class BusinessDaySpecification : Specification<DateTime>
{
    public override bool IsSatisfiedBy(DateTime date)
    {
        // 月曜日から金曜日の範囲に含まれる日付であることをチェックする
        return date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday;
    }
}