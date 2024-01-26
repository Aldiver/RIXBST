namespace rixbst.Domain.Groups;
using rixbst.Domain.Common.Models;
using rixbst.Domain.Groups.ValueObjects;
using rixbst.Domain.Users.ValueObjects;

public sealed class Group : AggregateRoot<GroupId>
{
    public string GroupName { get; }
    public string Description { get;}
    private readonly HashSet<UserId> _members = new();
    public UserId DefaultSignatory;
    public IReadOnlyCollection<UserId> Members => _members;

    private Group(
        GroupId groupId, 
        string groupName, 
        string description,
        UserId defaultSignatory) : base(groupId)
    {
        GroupName = groupName;
        Description = description;
        DefaultSignatory = defaultSignatory;
        _members.Add(defaultSignatory);
    }
    public static Group Create(string name, string description, UserId defaultSignatory)
    {
        return new (
            GroupId.CreateUnique(),
            name,
            description,
            defaultSignatory
        );
    }
    public void AddMember(UserId userId)
    {
        _members.Add(userId);
    }
}

