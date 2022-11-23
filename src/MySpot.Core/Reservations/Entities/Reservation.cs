using MySpot.Core.Reservations.Types;
using MySpot.Core.Reservations.ValueObjects;

namespace MySpot.Core.Reservations.Entities;

public sealed class Reservation
{
    public ReservationId Id { get; private set; }
    public  ParkingSpotId SpotId { get; private set; }
    public Capacity Capacity { get; private set; }
    public LicensePlate LicencePlate { get; private set; }
    public Date Date { get; private set; }
    public string Note { get; private set; }
    public ReservationStatus Status { get; private set; }

    public Reservation(ReservationId id, ParkingSpotId spotId, Capacity capacity, 
        LicensePlate licencePlate, Date date, string note)
    {
        Id = id;
        SpotId = spotId;
        Capacity = capacity;
        LicencePlate = licencePlate;
        Date = date;
        Note = note;
        Status = ReservationStatus.Pending;
    }

    internal void ChangeNote(string note)
        => Note = note;
    
    internal void ChangeLicensePlate(LicensePlate licensePlate)
        => LicencePlate = licensePlate;

    internal void MarkAsVerified()
        => Status = ReservationStatus.Verified;

    internal void MarkAsInvalid()
        => Status = ReservationStatus.Invalid;
}
