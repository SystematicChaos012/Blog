namespace Zot.Ddd;

/// <summary>
/// Domain event
/// </summary>
public abstract class DomainEvent
{
    /// <summary>
    /// The timestamp when the domain event was created
    /// </summary>
    public DateTime TimeStamp { get; } = DateTime.UtcNow;
}
