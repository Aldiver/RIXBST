using rixbst.Domain.Common.Models;
using rixbst.Domain.Owners.ValueObjects;

namespace rixbst.Domain.Owners;

public sealed class Owner : AggregateRoot<OwnerId>
{
    public Owner(OwnerId ownerId) : base(ownerId)
    {
    }
}