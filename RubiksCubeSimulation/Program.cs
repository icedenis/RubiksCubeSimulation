using RubiksCubeSimulation.Models;
using RubiksCubeSimulation.Services;

class Program
{
    static void Main(string[] args)
    {

        RubiksCube cube = new RubiksCube();


        Console.WriteLine("Initial Cube State:");
        cube.PrintCube();

        CubeRotationService rotationService = new CubeRotationService(cube);
        rotationService.PerformChallengeRotations();

        Console.WriteLine("\nCube State After Rotations:");
        cube.PrintCube();
    }
}