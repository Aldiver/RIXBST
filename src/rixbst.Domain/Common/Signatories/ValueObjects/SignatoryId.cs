using rixbst.Domain.Common.Models;

namespace rixbst.Domain.Common.Signatories.ValueObjects;

public sealed class SignatoryId : ValueObject
{
    public Guid Value { get;}
    private SignatoryId(Guid value)
    {
        Value = value;
    }
    public static SignatoryId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
