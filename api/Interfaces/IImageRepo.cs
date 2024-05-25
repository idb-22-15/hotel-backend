using api.Models;

namespace api.Interfaces
{
    public interface IImageRepo
    {
        public Task<bool> ExistsAsync(int id);
        public Task<Image?> GetByIdAsync(int id);
        public Task<List<Image>> GetAllAsync();
        public Task<Image> CreateAsync(Image model);
        public Task<Image?> DeleteAsync(int id);
    }
}