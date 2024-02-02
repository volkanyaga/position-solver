using NasaRoverPositonSolver.Enums;
using NasaRoverPositonSolver.Models.Base;

namespace NasaRoverPositonSolver.Models
{
    public class Rover : BaseVehicle
    {
        public Rover()
        {
            X = 0;
            Y = 0;
            Direction = DirectionEnum.S;
        }


        /// <summary>
        ///  Rover moving
        /// </summary>
        /// <param name="areaX"></param>
        /// <param name="areaY"></param>
        /// <param name="moves"></param>
        public override BaseVehicle MoveVehicle(int areaX, int areaY, string moves)
        {
            if (areaX < this.X || areaY < this.Y)
            {
                Console.WriteLine($"Rover is out of area!! X Axis = {areaX} Y Axis = {areaY}");
                return this;
            }

            foreach (var move in moves.ToCharArray())
            {
                switch (move)
                {
                    case 'M':
                        MoveSameDirection(this);
                        break;
                    case 'L':
                        RoverTurnLeft(this);
                        break;
                    case 'R':
                        RoverTurnRight(this);
                        break;
                    default:
                        Console.WriteLine($"Invalid Move {move}");
                        break;
                }

                if (areaX < this.X || areaY < this.Y)
                {
                    Console.WriteLine($"Rover is out of area!! X Axis = {areaX} Y Axis = {areaY}");
                    break;
                }
            }

            return this;
        }

        /// <summary>
        /// Rover move same direction
        /// </summary>
        /// <param name="rover"></param>
        private static void MoveSameDirection(Rover rover)
        {
            switch (rover.Direction)
            {
                case DirectionEnum.N:
                    rover.Y += 1;
                    break;
                case DirectionEnum.S:
                    rover.Y -= 1;
                    break;
                case DirectionEnum.E:
                    rover.X += 1;
                    break;
                case DirectionEnum.W:
                    rover.X -= 1;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// rover turn left
        /// </summary>
        /// <param name="rover"></param>
        private static void RoverTurnLeft(Rover rover)
        {
            switch (rover.Direction)
            {
                case DirectionEnum.N:
                    rover.Direction = DirectionEnum.W;
                    break;
                case DirectionEnum.S:
                    rover.Direction = DirectionEnum.E;
                    break;
                case DirectionEnum.E:
                    rover.Direction = DirectionEnum.N;
                    break;
                case DirectionEnum.W:
                    rover.Direction = DirectionEnum.S;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// rover turn right
        /// </summary>
        /// <param name="rover"></param>
        private static void RoverTurnRight(Rover rover)
        {
            switch (rover.Direction)
            {
                case DirectionEnum.N:
                    rover.Direction = DirectionEnum.E;
                    break;
                case DirectionEnum.S:
                    rover.Direction = DirectionEnum.W;
                    break;
                case DirectionEnum.E:
                    rover.Direction = DirectionEnum.S;
                    break;
                case DirectionEnum.W:
                    rover.Direction = DirectionEnum.N;
                    break;
                default:
                    break;
            }
        }
    }
}
