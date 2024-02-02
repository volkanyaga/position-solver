
using NasaRoverPositonSolver.Enums;
using NasaRoverPositonSolver.Models;

var rover = new Rover();

#region Read Area Info

string[]? fieldSize = null;
while (true)
{
    Console.Write("Please enter the field size = ");
    var fieldSizeStr = Console.ReadLine();
    if (fieldSizeStr is not null && fieldSizeStr != "")
    {
        fieldSize = fieldSizeStr.Split(" ");
        break;
    }
    else
        Console.WriteLine("Entered value not valid. Please try again enter the value");
}

#endregion

#region Read Rover Start Position

while (true)
{
    Console.Write("Please enter rover start position = ");
    var startPosition = Console.ReadLine();
    if (startPosition is not null && startPosition != "")
    {
        var startPositionArray = startPosition.Split(" ");
        if (startPositionArray.Length == 3)
        {
            rover.X = Convert.ToInt32(startPositionArray[0]);
            rover.Y = Convert.ToInt32(startPositionArray[1]);
            rover.Direction = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), startPositionArray[2]);
        }
        break;
    }
    else
        Console.WriteLine("Entered value not valid. Please try again enter the value");
}

#endregion

#region Read Rover Moves

Console.Write("Please enter rover next moves = ");
string moves = Console.ReadLine();

#endregion

try
{
    rover.MoveVehicle(Convert.ToInt32(fieldSize[0]), Convert.ToInt32(fieldSize[1]), moves);
    Console.Write("Rover last position => ");
    Console.WriteLine($"{rover.X} {rover.Y} {rover.Direction.ToString()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();