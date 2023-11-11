using Orfarm.Models.Base;

namespace Orfarm.Models.Transport
{
    public class Car:CommonProp
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? ColorId { get; set; }
        public Colors? Colors { get; set; }
        public List<Images>? Images { get; set; }
        public int? Year { get; set; }
        public byte[]? Type { get; set; }
        public string? Description { get; set; }
        public double Kilometer { get; set; }
        public byte[]? FuelType { get; set; }
        public byte[]? GearBox { get; set; }
        public byte[]? TransmissionType { get; set; }
        public double? EngineSize { get; set; }
        public string? Condition { get; set; }
        public decimal Price { get; set; }
        public string? VehicleType { get; set; }
        public int? NumberOfAirbags { get; set; }
        public string? InteriorMaterial { get; set; }

    }
}
