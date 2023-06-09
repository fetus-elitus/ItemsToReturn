﻿namespace ThingsToReturn.ViewModels
{
    public class AddressVM
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string? BuildingNr { get; set; }
        public int? ApartmentNr { get; set; }
    }
}
