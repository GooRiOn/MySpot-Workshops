using MySpot.Core.Reservations.Entities;

namespace MySpot.Core.Reservations.Policies;

internal sealed class BoosReservationPolicy : IReservationPolicy
{
    public bool CanBeApplied(string jobTitle)
        => jobTitle is "boss";

    public bool CanReserve(IEnumerable<Reservation> reservations)
        => true;
}