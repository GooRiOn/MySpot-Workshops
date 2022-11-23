using MySpot.Application.Shared.Commands;

namespace MySpot.Application.Commands.Handlers;

public sealed class MakeReservationHandler : ICommandHandler<MakeReservation>
{
    public Task HandleAsync(MakeReservation command)
    {
        // var userId = dto.UserId;
        // var currentWeeklyReservations = await _repository.GetForCurrentWeekAsync(userId);
        //
        // if (currentWeeklyReservations is null)
        // {
        //     // BO call
        //     var currentWeek = new Week(_clock.Current());
        //     currentWeeklyReservations = new WeeklyReservations(Guid.NewGuid(), userId, "employee", currentWeek);
        //
        //     await _repository.AddAsync(currentWeeklyReservations);
        // }
        //
        // var lastWeekReservations = await _repository.GetForLastWeekAsync(userId);
        //
        // var reservation = new Reservation(dto.Id, dto.SpotId, dto.Capacity, dto.LicencePlate,
        //     dto.Date, dto.Note);
        //
        // _domainService.Reserve(currentWeeklyReservations, lastWeekReservations, reservation);
        //
        // await _repository.UpdateAsync(currentWeeklyReservations);
    }
}