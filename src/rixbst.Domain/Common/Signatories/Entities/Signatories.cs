using rixbst.Domain.Common.Models;
using rixbst.Domain.Common.Signatories.ValueObjects;

namespace rixbst.Domain.Common.Signatories.Entities;

public sealed class Signatories : Entity<SignatoryId>
{
    public SignatoryStatus Status { get; }
    public Signatories(
        SignatoryId signatoryId,
        SignatoryStatus status 
        ) : base(signatoryId)
    {
        Status = status;
    }
    
}

public enum SignatoryStatus
    {
        Pending,
        Approved,
        Rejected
    }