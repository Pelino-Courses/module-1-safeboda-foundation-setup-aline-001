using SafeBoda.Core;

namespace SafeBoda.App
{
    class TripRepository
    {
        static void Main(string[] args)
        {
            var rider = new Rider(Guid.NewGuid(), "Aline", "+250788888888");
            var driver = new Driver(Guid.NewGuid(), "Asiimwe", "+250781111111", "RAE123C");
            var start = new Location(-1.9441, 30.0619); 
            var end = new Location(-1.9501, 30.0589);

            var trip = new Trip(
                Guid.NewGuid(),
                rider.Id,
                driver.Id,
                start,
                end,
                2500m,
                DateTime.Now
            );

            Console.WriteLine($"Trip started from {trip.Start} to {trip.End}");
            Console.WriteLine($"Rider: {rider.Name}, Driver: {driver.Name}");
            Console.WriteLine($"Fare: {trip.Fare} RWF");
        }
    }
} 