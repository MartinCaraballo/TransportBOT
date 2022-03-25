using Library;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// Esta clase se encarga de administrar todo lo relacionado con los viajes,
/// se encarga de almacenarlos y de buscar entre los almacenados.
/// </summary>
public class TripManager
{
    private static List<Trip> Trips = new List<Trip>();

    public ReadOnlyCollection<Trip> Tripspublic => Trips.AsReadOnly();

    public static void CreateInstance(float distance, string load, string location, int identifier, string[] requirements)
    {
        TripManager.Trips.Add(new Trip(distance, load, location, identifier, requirements));
    }

    public Trip SearchForLoad(string load) =>
        Tripspublic.Where(trip => trip.Load == load).FirstOrDefault();

    public Trip SearchForIdentifier(int identifier) =>
        Tripspublic.Where(trip => trip.Identifier == identifier).FirstOrDefault();

    public Trip SearchForLocation(string location) =>
        Tripspublic.Where(trip => trip.Location == location).FirstOrDefault();

    public Trip SearchForRequirements(string[] requirements) =>
        Tripspublic.Where(trip => trip.Requirements.Equals(requirements)).FirstOrDefault();
}