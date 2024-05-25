using api.Models;

namespace api.Interfaces
{
    public interface IRoomRepo
    {
        public Task<bool> ExistsAsync(int id);
        public Task<Room?> GetByIdAsync(int id);
        public Task<List<Room>> GetAllAsync();
        public Task<Room> CreateAsync(Room model);
        public Task<Room?> DeleteAsync(int id);
    }
}