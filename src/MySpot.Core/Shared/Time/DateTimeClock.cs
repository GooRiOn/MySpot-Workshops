namespace MySpot.Core.Shared.Time;

internal sealed class DateTimeClock : IClock
{
    public DateTime Current() => DateTime.UtcNow;
}