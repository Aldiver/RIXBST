using rixbst.Domain.Common.Models;

namespace rixbst.Domain.Groups.ValueObjects;

public sealed class GroupId : ValueObject
{
    public Guid Value { get;}
    private GroupId(Guid value)
    {
        Value = value;
    }
    public static GroupId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
