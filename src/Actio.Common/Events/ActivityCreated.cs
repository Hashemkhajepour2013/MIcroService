namespace Actio.Common.Events;

public class ActivityCreated : IAuthenticatedEvent
{
    public Guid Id { get; }
    public Guid UserId { get; }
    public string Category { get; set; }
    public string Name { get; }
    public string Description { get; }
    public DateTime CreateAt { get; }

    protected ActivityCreated()
    {
    }

    public ActivityCreated(
        Guid id, Guid userId, string category, string name, string description, DateTime createAt)
    {
        Id = id;
        UserId = userId;
        Category = category;
        Name = name;
        Description = description;
        CreateAt = createAt;
    }
}