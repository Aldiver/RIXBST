using rixbst.Domain.Common.Models;
using rixbst.Domain.Owners.ValueObjects;
using rixbst.Domain.Transactions.Entities;
using rixbst.Domain.Transactions.ValueObjects;

namespace rixbst.Domain.Transactions;

public sealed class Transaction : AggregateRoot<TransactionId>
{
    public string Title { get; }
        public string Description { get; }
        public TransactionType Type { get; }
        public byte[] Document { get; }
        public OwnerId OwnerId { get; }

        public Transaction(
            TransactionId id,
            string title,
            string description,
            TransactionType transactionType,
            byte[] document,
            OwnerId ownerId) : base(id)
        {
            Title = title;
            Description = description;
            Type = transactionType;
            Document = document;
            OwnerId = ownerId;
        }
}