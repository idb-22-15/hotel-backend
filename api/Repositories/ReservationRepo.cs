using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class ReservationRepo(ApplicationDbContext db) : IReservationRepo
    {
        public async Task<bool> ExistsAsync(int id)
        {
            return await db.Reservations.AnyAsync(r => r.Id == id);
        }

        public async Task<Reservation?> GetByIdAsync(int id)
        {
            return await db.Reservations.Include(r => r.Booker).FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Reservation>> GetByRoomIdAsync(int roomId)
        {
            return await db.Reservations.Include(r => r.Booker).Where(r => r.RoomId == roomId).ToListAsync();
        }

        public async Task<List<Reservation>> GetAllAsync()
        {
            return await db.Reservations.Include(r => r.Booker).Include(r => r.Guests).ToListAsync();
        }

        public async Task<Reservation?> CreateAsync(Reservation model)
        {
            var existingReservations = await GetByRoomIdAsync(model.RoomId);
            bool isIntersect = existingReservations.Any(r =>
                    (model.CheckIn >= r.CheckIn && model.CheckIn < r.CheckOut) ||
                    (model.CheckOut > r.CheckIn && model.CheckOut <= r.CheckOut)
            );
            if (isIntersect) return null;

            await db.Reservations.AddAsync(model);
            await db.SaveChangesAsync();
            return model;
        }

        public async Task<Reservation?> DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);
            if (model == null) return null;

            db.Reservations.Remove(model);
            await db.SaveChangesAsync();
            return model;
        }
    }
}