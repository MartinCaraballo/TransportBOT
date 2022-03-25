using System;

namespace Library
{
    public class Trip
    {
        public int Identifier;
        public float Distance;
        public string Location;
        public string Load;
        public string[] Requirements;
        
        public Trip(float distance, string load, string location, int identifier, string[] requirements)
        {
            this.Distance = distance;
            this.Load = load;
            this.Location = location;
            this.Identifier = identifier;
            this.Requirements = requirements;
        }
    }
}
