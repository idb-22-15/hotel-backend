using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class RoomRepo(ApplicationDbContext db) : IRoomRepo
    {
        public async Task<bool> ExistsAsync(int id)
        {
            return await db.Rooms.AnyAsync(r => r.Id == id);
        }

        public async Task<Room?> GetByIdAsync(int id)
        {
            return await db.Rooms.Include(r => r.Images).Include(r => r.Reservations).FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await db.Rooms.Include(r => r.Images).Include(r => r.Reservations).ToListAsync();
        }

        public async Task<Room> CreateAsync(Room model)
        {
            await db.AddAsync(model);
            await db.SaveChangesAsync();
            return model;
        }

        public async Task<Room?> DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);
            if (model == null) return null;

            db.Rooms.Remove(model);
            await db.SaveChangesAsync();
            return model;
        }
    }
}