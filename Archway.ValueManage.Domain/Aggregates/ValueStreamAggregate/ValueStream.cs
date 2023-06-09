namespace Archway.ValueManage.Domain.Aggregates.ValueStreamAggregate;

public class ValueStream : AggregateRoot
{
    public string Name { get; private set; }
    public IList<ValueStage> ValueStages { get; private set; }

    public ValueStream(string name)
    {
        Name = name;
        ValueStages = new List<ValueStage>();
    }

    public void AddValueStage(ValueStage valueStage)
    {
        ValueStages.Add(valueStage);
        valueStage.SetParentStream(this);
    }
}

