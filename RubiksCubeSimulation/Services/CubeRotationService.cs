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
            _cube.RotateFrontCounterClockwise();
            //_cube.RotateRightCounterClockwise();
            //_cube.RotateUpClockwise();
            //_cube.RotateBackCounterClockwise();
            //_cube.RotateLeftClockwise();
            //_cube.RotateDownCounterClockwise();
        }
    }
}