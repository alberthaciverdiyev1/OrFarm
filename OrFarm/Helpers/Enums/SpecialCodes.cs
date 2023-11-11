namespace Orfarm.Helpers.Enums
{
    public class SpecialCodes
    {
        public enum Types
        {
            Bus = 0x001,
            CompactCar = 0x002,
            Convertible = 0x003,
            Coupe = 0x004,
            Crossover = 0x005,
            Electric = 0x006,
            Hatchback = 0x007,
            Hybrid = 0x008,
            Limousine = 0x009,
            Microcar = 0x010,
            Minivan = 0x011,
            OffRoad = 0x012,
            Pickup = 0x013,
            Truck = 0x014,
            Roadster = 0x015,
            Sedan = 0x016,
            SportsCar = 0x017,
            StationWagon = 0x018,
            SUV = 0x019,
            Supercar = 0x020,
            Van = 0x021,
            Wagon = 0x022,
            Motorcycle = 0x023
        }

        public enum FuelTypes
        {
            Petrol = 0x001,
            Diesel = 0x002,
            Hybrid = 0x003,
            Electric = 0x004,
            LiquefiedPetroleumGas = 0x005,
            CompressedNaturalGas = 0x006,
            Ethanol = 0x007,
            Biodiesel = 0x008,
            HydrogenFuelCell = 0x009,
            PluginHybrid = 0x010,
            FlexFuel = 0x011,
            Bioethanol = 0x012,
            Propane = 0x013,
            SyntheticFuels = 0x014
        }

        public enum Seats
        {
            one = 0x001,
            two = 0x002,
            three = 0x003,
            four = 0x004,
            five = 0x005,
            six = 0x006,
            seven = 0x007,
            eight = 0x008,
            more = 0x009
        }

        public enum Gears
        {
            Front = 0x001,
            Back = 0x002,
            Front_Back = 0x003
        }

        public enum GearBoxes
        {
            Manual = 0x001,
            Automatic = 0x002,
            ContinuouslyVariable = 0x003,
            DualClutch = 0x004,
            AutomatedManual = 0x005,
            SequentialManual = 0x006,
            Direct_ShifGearbox = 0x007,
            Tiptronic = 0x008,
            Hydrostatic = 0x009,
            InfinitelyVariable = 0x010,
            TorqueConverter = 0x011,
            E_CVT = 0x012
        }
    }

}
