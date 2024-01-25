using rixbst.Domain.Common.Models;
using rixbst.Domain.Transactions.ValueObjects;

namespace rixbst.Domain.Transactions.Entities;

public sealed class TransactionType : Entity<TransactionTypeId>
{
    public string Name { get;}
    public string Description { get; }
    public TransactionType(TransactionTypeId transactionTypeId, string name, string description) : base(transactionTypeId)
    {
        Name = name;
        Description = description;
    }
    
}
