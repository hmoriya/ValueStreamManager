namespace Archway.SharedKernel.Domain.Specifications;

public class ValidDateRangeSpecification : Specification<(DateTime StartDate, DateTime EndDate)>
{
    public override bool IsSatisfiedBy((DateTime StartDate, DateTime EndDate) dateRange)
    {
        // 開始日と終了日が有効な範囲内にあることをチェックする
        DateTime currentDate = DateTime.Now.Date;
        return dateRange.StartDate >= currentDate && dateRange.EndDate >= currentDate && dateRange.StartDate <= dateRange.EndDate;
    }
}