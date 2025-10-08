using SafeBoda.Core;
using SafeBoda.Application;

namespace SafeBoda.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new InMemoryTripRepository();
            var trips = repo.GetActiveTrips();

            foreach (Trip trip in trips)
            {
                Console.WriteLine($"Trip ID: {trip.Id}");
                Console.WriteLine($"Driver ID: {trip.DriverId}");
                Console.WriteLine($"Fare: {trip.Fare}");
                Console.WriteLine($"Start: {trip.Start}");
                Console.WriteLine($"End: {trip.End}");
                Console.WriteLine($"Request Time: {trip.RequestTime}");
                Console.WriteLine("-------------->------------->--------");
            }
        }
    }
}