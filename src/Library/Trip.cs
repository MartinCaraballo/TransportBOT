using System;

namespace Library
{
    public class Trip
    {
        int Identifier;
        float Distance;
        string Location;
        
        public Trip(float distance, string location, int identifier)
        {
            this.Distance = distance;
            this.Location = location;
            this.Identifier = identifier;
        }
    }
}
