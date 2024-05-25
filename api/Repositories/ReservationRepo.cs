using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Models;

namespace api.Repositories
{
    public class ReservationRepo : IReservationRepo
    {
        public Task<Reservation> CreateAsync(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reservation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Reservation?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}