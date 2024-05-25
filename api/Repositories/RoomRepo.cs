using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return await db.Rooms.FindAsync(id);
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await db.Rooms.ToListAsync();
        }

        public async Task<Room> CreateAsync(Room room)
        {
            await db.AddAsync(room);
            await db.SaveChangesAsync();
            return room;
        }

        public async Task<Room?> DeleteAsync(int id)
        {
            var room = await GetByIdAsync(id);
            if (room == null) return null;

            db.Rooms.Remove(room);
            await db.SaveChangesAsync();
            return room;
        }


    }
}