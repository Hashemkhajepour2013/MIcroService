namespace Actio.Common.Events;

public class CreateActivityRejected : IRejectedEvent
{
    public string Reason { get; }
    public string Code { get; }
    public Guid Id { get; set; }

    protected CreateActivityRejected()
    {
    }

    public CreateActivityRejected(string reason, string code, Guid id)
    {
        Reason = reason;
        Code = code;
        Id = id;
    }
}