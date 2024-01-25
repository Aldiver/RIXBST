using rixbst.Domain.Common.Models;
using rixbst.Domain.Transactions.Entities;
using rixbst.Domain.Transactions.ValueObjects;

namespace rixbst.Domain.Transactions;

public sealed class Transaction : AggregateRoot<TransactionId>
{
    public string Name {get;}
    public string Description { get;}
    public TransactionType Type { get;}
    public byte[] Document { get;}
    public string DigitalSignature { get;} //must be list i think
    public string? Status { get;} =  null; 

    public Transaction(
        TransactionId id, 
        string name, 
        string description, 
        TransactionType transactionType, 
        byte[] document, 
        string digitalSignature, 
        string status) : base(id)
    {
    }
}