using RubiksCubeSimulation.Models;

namespace RubiksCubeSimulation.Services
{
    public class CubeRotationService
    {
        private RubiksCube _cube;

        public CubeRotationService(RubiksCube cube)
        {
            _cube = cube;
        }

        public void PerformChallengeRotations()
        {
            // Implement the rotation sequence
          _cube.RotateFrontClockwise();
            Console.WriteLine("Front C");
            _cube.PrintCube();
            //  _cube.RotateFrontCounterClockwise();
            _cube.RotateRightCounterClockwise();
            Console.WriteLine("R ANtiC");
            _cube.PrintCube();
            Console.WriteLine("UP C");
            _cube.RotateUpClockwise();
            _cube.PrintCube();
            Console.WriteLine("BAck ANti C");
            _cube.RotateBackCounterClockwise();
            _cube.PrintCube();
            Console.WriteLine("LEft  C");
            _cube.RotateLeftClockwise();
            _cube.PrintCube();
            Console.WriteLine("DOWN ANti C");
            _cube.RotateDownCounterClockwise();
            _cube.PrintCube();
            //   _cube.RotateDownClockwise();
        }
    }
}