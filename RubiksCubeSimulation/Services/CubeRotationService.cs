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

          _cube.RotateFrontClockwise();
           
            _cube.RotateRightCounterClockwise();

            _cube.RotateUpClockwise();

            _cube.RotateBackCounterClockwise();
      
            _cube.RotateLeftClockwise();
  
            _cube.RotateDownCounterClockwise();

    
        }
    }
}