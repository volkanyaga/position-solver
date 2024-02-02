using NasaRoverPositonSolver.Enums;

namespace NasaRoverPositonSolver.Models.Base
{
    public abstract class BaseVehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionEnum Direction { get; set; }

        public abstract BaseVehicle MoveVehicle(int areaX, int areaY, string moves);
    }
}
