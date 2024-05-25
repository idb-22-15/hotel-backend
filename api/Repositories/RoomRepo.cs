using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Room;
using api.Interfaces;
using api.Models;
using api.Mappers;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class RoomRepo(ApplicationDbContext db) : IRoomRepo
    {
        public async Task<Room?> GetByIdAsync(int id)
        {
            return await db.Rooms.FindAsync(id);
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await db.Rooms.ToListAsync();
        }

        public Task CreateAsync(CreateRoomDto dto)
        {
            throw new NotImplementedException();


        }

        public async Task DeleteAsync(int id)
        {
            var room = await db.Rooms.FindAsync(id);
            if (room == null) return;

            db.Rooms.Remove(room);
            await db.SaveChangesAsync();
        }
    }
}