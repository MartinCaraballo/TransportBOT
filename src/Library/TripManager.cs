using Library;
using System.Collections.ObjectModel;
using System.Collections.Generic;


public class TripManager
{
    private List<Trip> Trips = new List<Trip>();

    public ReadOnlyCollection<Trip> Tripspublic => Trips.AsReadOnly();

}