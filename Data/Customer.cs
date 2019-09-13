using System.Collections.Generic;
namespace bikeservice.Data
{
public class Customer
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public Bike Bike { get; } = new Bike();
    public List<Service> Services { get; } = new List<Service>();
}

public class Bike
{
    public string Model { get; set; }
    public string Year { get; set; }
    public string Serino { get; set; }
}

    public class Service
    {
        public enum Type { BinBakım, AltıBinBakım,OnikiBinBakım }

        public Type ServiceType { get; set; }

        public string SeriNo { get; set; }
        public decimal Price { get; set; }
    }
}