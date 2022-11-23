using MySpot.Core.Reservations.Entities;
using MySpot.Core.Reservations.ValueObjects;

namespace MySpot.Application.DTO;

public class ReservationDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public  Guid SpotId { get; set; }
    public int Capacity { get; set; }
    public string LicencePlate { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Note { get; set; }
    public ReservationStatus Status { get; set; }
}