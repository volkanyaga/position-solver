using NasaRoverPositonSolver.Enums;

namespace NasaRoverPositonSolver.Models
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionEnum Direction { get; set; }
    }
}
