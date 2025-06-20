﻿using FakeBooking.API.Database;
using FakeBooking.API.Models;

namespace FakeBooking.API.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {

        private readonly AppDbContext _context;

        public TouristRouteRepository(AppDbContext context)
        {
            _context = context;
        }
        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _context.TouristRoutes
                .FirstOrDefault(n => n.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _context.TouristRoutes;
        }
    }
}
