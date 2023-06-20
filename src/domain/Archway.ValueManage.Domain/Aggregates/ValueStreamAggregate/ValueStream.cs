namespace Archway.ValueManage.Domain.Aggregates.ValueStreamAggregate;

public class ValueStream : AggregateRoot
{
    public string Value { get; private set; }
    public IList<ValueStage> ValueStages { get; private set; }

    public ValueStream(string value)
    {
        Value = value;
        ValueStages = new List<ValueStage>();
    }

    public void AddValueStage(ValueStage valueStage)
    {
        ValueStages.Add(valueStage);
    }
}

