namespace rixbst.Domain.Groups;
using rixbst.Domain.Common.Models;
using rixbst.Domain.Groups.ValueObjects;
using rixbst.Domain.Users;

public sealed class Group : AggregateRoot<GroupId>
{
    public string Name { get; }
    public string Description { get;}
    private readonly List<User> _members = new();

    private Group(GroupId groupId, string name, string description) : base(groupId)
    {
        Name = name;
        Description = description;
    }

    public IReadOnlyList<User> Members => _members.AsReadOnly();

    public static Group Create(string name, string description)
    {
        return new (
            GroupId.CreateUnique(),
            name,
            description
        );
    }
    public void AddMember(User user)
    {
        _members.Add(user);
    }
}

