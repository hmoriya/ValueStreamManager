namespace Archway.ValueManage.Domain.Aggregates.ValueStreamAggregate;

public class ValueStage : Entity
{
    public string Name { get; private set; }
    public IList<BusinessCapability> Capabilities { get; private set; }
    public ValueStream? ParentStream { get; private set; } // 親となるValueStreamを参照します。

    public ValueStage(string? name)
    {
        if(name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        Name = name;
        Capabilities = new List<BusinessCapability>();
    }

    public void AddCapability(BusinessCapability businessCapability)
    {
        Capabilities.Add(businessCapability);
    }

    // 親となるValueStreamを設定するためのメソッド
    public void SetParentStream(ValueStream valueStream)
    {
        ParentStream = valueStream;
    }
}

