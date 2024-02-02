using NasaRoverPositonSolver.Enums;

namespace NasaRoverPositonSolver.Models.Base
{
    public abstract class BaseVehicle
    {

        #region Properties
        
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionEnum Direction { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="areaX"></param>
        /// <param name="areaY"></param>
        /// <param name="moves"></param>
        /// <returns></returns>
        public abstract BaseVehicle MoveVehicle(int areaX, int areaY, string moves);

        #endregion
    }
}
