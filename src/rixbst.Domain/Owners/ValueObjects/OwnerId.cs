using rixbst.Domain.Common.Models;

namespace rixbst.Domain.Owners.ValueObjects;

public sealed class OwnerId : ValueObject
{
    public Guid Value { get;}
    private OwnerId(Guid value)
    {
        Value = value;
    }
    public static OwnerId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
