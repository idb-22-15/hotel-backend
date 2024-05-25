using api.Models;

namespace api.Interfaces
{
    public interface IBookedDateRangeRepo
    {
        public Task<bool> ExistsAsync(int id);

        public Task<BookedDateRange?> GetByIdAsync(int id);
        public Task<List<BookedDateRange>> GetAllAsync();
        public Task<BookedDateRange> CreateAsync(BookedDateRange range);
        public Task<BookedDateRange?> DeleteAsync(int id);


    }
}