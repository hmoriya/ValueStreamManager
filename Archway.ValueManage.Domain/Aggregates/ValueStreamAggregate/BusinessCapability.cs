using Archway.SharedKernel.Domain.ValueObjects;
using Archway.ValueManage.Domain.ValueObjects;
using Path = System.IO.Path;

namespace Archway.ValueManage.Domain.Aggregates.ValueStreamAggregate;

public class BusinessCapability : AggregateRoot
{
    public BusinessValue BusinessValue { get; private set; }
    public BusinessObjective BusinessObjective { get; private set; }

    private List<BusinessCapability> _children = new List<BusinessCapability>();
    public IReadOnlyList<BusinessCapability> Children => _children.AsReadOnly();

    public BusinessCapability(BusinessValue businessValue, BusinessObjective businessObjective)
    {
        BusinessValue = businessValue ?? throw new ArgumentNullException(nameof(businessValue));
        BusinessObjective = businessObjective ?? throw new ArgumentNullException(nameof(businessObjective));
    }

    public void AddChild(BusinessCapability childCapability)
    {
        _ = childCapability ?? throw new ArgumentNullException(nameof(childCapability));

        _children.Add(childCapability);
    }

    public BusinessCapability? GetChildById(Guid id)
    {
        return _children.FirstOrDefault(c => c.Id == id);
    }
    
}
