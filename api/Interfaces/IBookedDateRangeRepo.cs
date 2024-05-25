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
        public Task<BookedDateRange?> GetByIdAsync(int id);
        public Task<List<BookedDateRange>> GetAllAsync();
        public Task CreateAsync(CreateBookedDateRangeDto dto);
        public Task DeleteAsync(int id);


    }
}