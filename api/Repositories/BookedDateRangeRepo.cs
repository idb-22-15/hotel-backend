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
    public class BookedDateRangeRepo(ApplicationDbContext db) : IBookedDateRangeRepo
    {
        public async Task<bool> ExistsAsync(int id)
        {

            return await db.BookedDateRanges.AnyAsync(r => r.Id == id);
        }

        public async Task<BookedDateRange?> GetByIdAsync(int id)
        {
            return await db.BookedDateRanges.FindAsync(id);
        }

        public async Task<List<BookedDateRange>> GetAllAsync()
        {
            return await db.BookedDateRanges.ToListAsync();
        }

        public async Task<BookedDateRange> CreateAsync(BookedDateRange range)
        {
            await db.AddAsync(range);
            await db.SaveChangesAsync();
            return range;
        }

        public async Task<BookedDateRange?> DeleteAsync(int id)
        {
            var range = await GetByIdAsync(id);
            if (range == null) return null;

            db.BookedDateRanges.Remove(range);
            await db.SaveChangesAsync();
            return range;
        }
    }
}