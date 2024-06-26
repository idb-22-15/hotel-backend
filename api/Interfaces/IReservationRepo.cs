using api.Models;

namespace api.Interfaces
{
    public interface IReservationRepo
    {
        public Task<bool> ExistsAsync(int id);
        public Task<Reservation?> GetByIdAsync(int id);
        public Task<List<Reservation>> GetByRoomIdAsync(int roomId);

        public Task<List<Reservation>> GetAllAsync();
        public Task<Reservation?> CreateAsync(Reservation model);
        public Task<Reservation?> DeleteAsync(int id);
    }
}