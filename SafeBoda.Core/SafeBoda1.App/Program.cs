using SafeBoda.Application;
using SafeBoda.Core;

namespace SafeBoda1.App
{
    
}
class Program
{
    static void Main(string[] args)
    {
        var repo = new InMemoryTripRepository();

        var trips = repo.GetActiveTrips();

        Console.WriteLine("=== Active Trips ===");

        foreach (Trip trip in trips)
        {
            Console.WriteLine($"Trip ID: {trip.Id}");
            Console.WriteLine($"Rider ID: {trip.RiderId}");
            Console.WriteLine($"Driver ID: {trip.DriverId}");
            Console.WriteLine($"Start: {trip.Start.Latitude}, {trip.Start.Longitude}");
            Console.WriteLine($"End: {trip.End.Latitude}, {trip.End.Longitude}");
            Console.WriteLine($"Fare: {trip.Fare} RWF");
        }

        Console.WriteLine("Done! ✅");
    }
}