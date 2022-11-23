using MySpot.Application.DTO;
using MySpot.Core.Reservations.DomainServices;
using MySpot.Core.Reservations.Entities;
using MySpot.Core.Reservations.Repositories;
using MySpot.Core.Reservations.ValueObjects;
using MySpot.Core.Shared.Time;

namespace MySpot.Application.Services;

public sealed class WeeklyReservationsService : IWeeklyReservationsService
{
    private readonly IWeeklyReservationsRepository _repository;
    private readonly IReservationDomainService _domainService;
    private readonly IClock _clock;

    public WeeklyReservationsService(IWeeklyReservationsRepository repository, 
        IReservationDomainService domainService, IClock clock)
    {
        _repository = repository;
        _domainService = domainService;
        _clock = clock;
    }

    public async Task MakeReservationAsync(ReservationDto dto)
    {
        var userId = dto.UserId;
        var currentWeeklyReservations = await _repository.GetForCurrentWeekAsync(userId);

        if (currentWeeklyReservations is null)
        {
            // BO call
            var currentWeek = new Week(_clock.Current());
            currentWeeklyReservations = new WeeklyReservations(Guid.NewGuid(), userId, "employee", currentWeek);

            await _repository.AddAsync(currentWeeklyReservations);
        }

        var lastWeekReservations = await _repository.GetForLastWeekAsync(userId);

        var reservation = new Reservation(dto.Id, dto.SpotId, dto.Capacity, dto.LicencePlate,
            dto.Date, dto.Note);
        
       _domainService.Reserve(currentWeeklyReservations, lastWeekReservations, reservation);

       await _repository.UpdateAsync(currentWeeklyReservations);
    }
}