using RubiksCubeSimulation.Models;
using RubiksCubeSimulation.Services;

class Program
{
    static void Main(string[] args)
    {

        RubiksCube cube = new RubiksCube();

        Console.WriteLine("Initial Cube State:");
        cube.PrintCube();


        //Console.WriteLine("1. Front Clockwise Rotation:");
        //cube.RotateFrontClockwise();
        //cube.PrintCube();

        //Console.WriteLine("2. Front Counter Clockwise Rotation:");
        //cube.RotateFrontCounterClockwise();
        //cube.PrintCube();

        //Console.WriteLine("1. UP Clockwise Rotation:");
        //cube.RotateUpClockwise();
        //cube.PrintCube();

        //Console.WriteLine("2. UP Counter Clockwise Rotation:");
        //cube.RotateUpCounterClockwise();
        //cube.PrintCube();


        //Console.WriteLine("1. Right Clockwise Rotation:");
        //cube.RotateRightClockwise();
        //cube.PrintCube();

        //Console.WriteLine("2. Right Counter Clockwise Rotation:");
        //cube.RotateRightCounterClockwise();
        //cube.PrintCube();


        //Console.WriteLine("1. LEFT Clockwise Rotation:");
        //cube.RotateLeftClockwise();
        //cube.PrintCube();

        //Console.WriteLine("2. LEFT Counter Clockwise Rotation:");
        //cube.RotateLeftCounterClockwise();
        //cube.PrintCube();


        //Console.WriteLine("1. BACK Clockwise Rotation:");
        //cube.RotateBackClockwise();
        //cube.PrintCube();

        //Console.WriteLine("2. BACK Counter Clockwise Rotation:");
        //cube.RotateBackCounterClockwise();
        //cube.PrintCube();


        //Console.WriteLine("1. DOWN Clockwise Rotation:");
        //cube.RotateDownClockwise();
        //cube.PrintCube();

        //Console.WriteLine("2. DOWN Counter Clockwise Rotation:");
        //cube.RotateDownCounterClockwise();
        //cube.PrintCube();






        ////     RubiksCube cube = new RubiksCube();

        Console.WriteLine("Initial Cube State:");
        cube.PrintCube();

        CubeRotationService rotationService = new CubeRotationService(cube);
        rotationService.PerformChallengeRotations();

        Console.WriteLine("\nCube State After Rotations:");
        cube.PrintCube();
    }
}