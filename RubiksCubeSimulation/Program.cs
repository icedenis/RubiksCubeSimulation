using RubiksCubeSimulation.Models;
using RubiksCubeSimulation.Services;

class Program
{
    static void Main(string[] args)
    {

        RubiksCube cube = new RubiksCube();

        Console.WriteLine("Initial Cube State:");
        cube.PrintCube();


        Console.WriteLine("1. Front Clockwise Rotation:");
        cube.RotateFrontClockwise();
        cube.PrintCube();

        Console.WriteLine("2. Front Counter Clockwise Rotation:");
        cube.RotateFrontCounterClockwise();
        cube.PrintCube();



        Console.WriteLine("1. Right Clockwise Rotation:");
        cube.RotateRightClockwise();
        cube.PrintCube();

        Console.WriteLine("2. Right Counter Clockwise Rotation:");
        cube.RotateRightCounterClockwise();
        cube.PrintCube();



        //RubiksCube cube = new RubiksCube();

        //Console.WriteLine("Initial Cube State:");
        //cube.PrintCube();

        //CubeRotationService rotationService = new CubeRotationService(cube);
        //rotationService.PerformChallengeRotations();

        //Console.WriteLine("\nCube State After Rotations:");
        //cube.PrintCube();
    }
}