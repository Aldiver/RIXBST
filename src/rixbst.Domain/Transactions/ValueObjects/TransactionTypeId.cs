using rixbst.Domain.Common.Models;

namespace rixbst.Domain.Transactions.ValueObjects;

public sealed class TransactionTypeId : ValueObject
{
    public Guid Value { get;}
    private TransactionTypeId(Guid value)
    {
        Value = value;
    }
    public static TransactionTypeId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
