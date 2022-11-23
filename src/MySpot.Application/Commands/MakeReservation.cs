using MySpot.Application.Shared.Commands;

namespace MySpot.Application.Commands;

public record MakeReservation(Guid Id, Guid UserId, Guid SpotId, int Capacity, string LicencePlate,
    DateTimeOffset Date, string Note) : ICommand;