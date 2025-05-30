using FakeBooking.API.Models;

namespace FakeBooking.API.Services
{
    public class MockTouristRouteRepository : ITouristRouteRepository
    {
        private List<TouristRoute> _routes;

        public MockTouristRouteRepository()
        {
            if (_routes == null)
            {
                InitializeTouristRoutes();
            }
        }

        private void InitializeTouristRoutes()
        {
            _routes = new List<TouristRoute>
            {
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "YellowStone",
                    Description="Yellowstone features dramatic canyons, alpine rivers, " +
                    "lush forests, hot springs and gushing geysers, including its most famous, Old Faithful.",
                    OriginalPrice = 1299,
                    Features = "<p>Geyser</p>",
                    Fees = "<p>Living, car rental</p>",
                    Notes="<p>No swimming</p>"
                },
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "Grand Canyon",
                    Description="The Grand Canyon in Arizona is a natural formation distinguished by layered bands of red rock, " +
                    "revealing millions of years of geological history in cross-section. " +
                    "Much of the area is a national park, with Colorado River white-water rapids and sweeping vistas.",
                    OriginalPrice = 1299,
                    Features = "<p>Grand Canyon</p>",
                    Fees = "<p>Living, car rental</p>",
                    Notes="<p>No jump</p>"
                }
            };
        }
        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            //linq
            return _routes.FirstOrDefault(n=>n.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            //linq
            return _routes;
        }
    }
}
