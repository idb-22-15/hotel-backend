using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.BookedDateRange;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class BookedDateRangeRepo(ApplicationDbContext db) : IBookedDateRangeRepo
    {
        public async Task<bool> ExistsAsync(int id)
        {
            return await db.BookedDateRanges.AnyAsync(b => b.Id == id);
        }

        public Task CreateAsync(CreateBookedDateRangeDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookedDateRange>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookedDateRange?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<BookedDateRange> IBookedDateRangeRepo.CreateAsync(CreateBookedDateRangeDto dto)
        {
            throw new NotImplementedException();
        }

        Task<BookedDateRange?> IBookedDateRangeRepo.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}