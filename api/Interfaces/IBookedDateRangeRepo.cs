using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.BookedDateRange;
using api.Models;

namespace api.Interfaces
{
    public interface IBookedDateRangeRepo
    {
        public Task<bool> ExistsAsync(int id);

        public Task<BookedDateRange?> GetByIdAsync(int id);
        public Task<List<BookedDateRange>> GetAllAsync();
        public Task<BookedDateRange> CreateAsync(CreateBookedDateRangeDto dto);
        public Task<BookedDateRange?> DeleteAsync(int id);


    }
}