using Archway.SharedKernel.Domain.ValueObjects;

namespace Archway.ValueManage.Domain.Aggregates.ValueStreamAggregate;

public class ValueStage : Entity
{
    public string Name { get; private set; }
    public IList<BusinessCapability> Capabilities { get; private set; }
  

    public ValueStage(string? name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Capabilities = new List<BusinessCapability>();
    }

    public void AddCapability(BusinessCapability businessCapability)
    {
        Capabilities.Add(businessCapability);
    }
    
}

