using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.BookedDateRange;
using api.Interfaces;
using api.Models;

namespace api.Repositories
{
    public class BookedDateRangeRepo : IBookedDateRangeRepo
    {
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
    }
}