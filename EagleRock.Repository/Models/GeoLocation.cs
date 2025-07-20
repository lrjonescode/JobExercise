﻿namespace EagleRock.Repository.Models
{
    public class GeoLocation
    {
        public GeoLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
