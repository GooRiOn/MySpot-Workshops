using MySpot.Core.Reservations.ValueObjects;

namespace MySpot.Core.Entities;

public sealed class Reservation
{
    public Guid Id { get; private set; }
    public Guid ParkingId { get; private set; }
    public Capacity Capacity { get; private set; }
    public string LicencePlate { get; private set; }
    public DateTime Date { get; private set; }
    public string Note { get; private set; }
    public ReservationStatus Status { get; private set; }

    public Reservation(Guid id, Guid parkingId, Capacity capacity, string licencePlate, 
        DateTime date, string note, ReservationStatus status)
    {
        Id = id;
        ParkingId = parkingId;
        Capacity = capacity;
        LicencePlate = licencePlate;
        Date = date;
        Note = note;
        Status = status;
    }

    
}
