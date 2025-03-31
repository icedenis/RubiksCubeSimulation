using System.ComponentModel;
using System;
using RubiksCubeSimulation.Models;
using static RubiksCubeSimulation.Models.RubiksCube.Color;
using System.Runtime.InteropServices;
using System.Security.Principal;


namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestEdgeRotateFrontClockwise()
        {

            var cube = new RubiksCube();
            cube.up[2, 0] = White;
            cube.up[2, 1] = White;
            cube.up[2, 2] = White;

            cube.right[0, 0] = Red;
            cube.right[1, 0] = Red;
            cube.right[2, 0] = Red;

            cube.down[0, 0] = Yellow;
            cube.down[0, 1] = Yellow;
            cube.down[0, 2] = Yellow;

            cube.left[0, 2] = Orange;
            cube.left[1, 2] = Orange;
            cube.left[2, 2] = Orange;

            cube.RotateFrontClockwise();

            Assert.Equal(Green, cube.front[1, 1]);

            Assert.Equal(White, cube.right[0, 0]);
            Assert.Equal(White, cube.right[1, 0]);
            Assert.Equal(White, cube.right[2, 0]);

            Assert.Equal(Red, cube.down[0, 0]);
            Assert.Equal(Red, cube.down[0, 1]);
            Assert.Equal(Red, cube.down[0, 2]);

            Assert.Equal(Yellow, cube.left[0, 2]);
            Assert.Equal(Yellow, cube.left[1, 2]);
            Assert.Equal(Yellow, cube.left[2, 2]);

            Assert.Equal(Orange, cube.up[2, 0]);
            Assert.Equal(Orange, cube.up[2, 1]);
            Assert.Equal(Orange, cube.up[2, 2]);
        }

        [Fact]
        public void TestRotateFrontClockwise()
        {
          
            var cube = new RubiksCube();
          

     
            cube.front[0, 0] = White;     
            cube.front[0, 1] = Orange;    
            cube.front[0, 2] = Green;     
            cube.front[1, 0] = Red;      
            cube.front[1, 1] = Green;     
            cube.front[1, 2] = Blue;      
            cube.front[2, 0] = Yellow;    
            cube.front[2, 1] = White;     
            cube.front[2, 2] = Orange;    

         
            cube.RotateFrontClockwise();


            Assert.Equal(Yellow, cube.front[0, 0]);    
            Assert.Equal(Red, cube.front[0, 1]);      
            Assert.Equal(White, cube.front[0, 2]);    
            Assert.Equal(White, cube.front[1, 0]);     
            Assert.Equal(Green, cube.front[1, 1]);     
            Assert.Equal(Orange, cube.front[1, 2]);    
            Assert.Equal(Orange, cube.front[2, 0]);    
            Assert.Equal(Blue, cube.front[2, 1]);      
            Assert.Equal(Green, cube.front[2, 2]);     
        }


        [Fact]
        public void TestEdgeRotateUpClockwise()
        {
            var cube = new RubiksCube();

            cube.front[0, 0] = Green;
            cube.front[0, 1] = Green;
            cube.front[0, 2] = Green;

            cube.right[0, 0] = Red;
            cube.right[0, 1] = Red;
            cube.right[0, 2] = Red;

            cube.back[0, 0] = Blue;
            cube.back[0, 1] = Blue;
            cube.back[0, 2] = Blue;

            cube.left[0, 0] = Orange;
            cube.left[0, 1] = Orange;
            cube.left[0, 2] = Orange;

            cube.RotateUpClockwise();

            Assert.Equal(White, cube.up[1, 1]);

            Assert.Equal(Green, cube.left[0, 0]);
            Assert.Equal(Green, cube.left[0, 1]);
            Assert.Equal(Green, cube.left[0, 2]);

            Assert.Equal(Orange, cube.back[0, 0]);
            Assert.Equal(Orange, cube.back[0, 1]);
            Assert.Equal(Orange, cube.back[0, 2]);

            Assert.Equal(Blue, cube.right[0, 0]);
            Assert.Equal(Blue, cube.right[0, 1]);
            Assert.Equal(Blue, cube.right[0, 2]);

            Assert.Equal(Red, cube.front[0, 0]);
            Assert.Equal(Red, cube.front[0, 1]);
            Assert.Equal(Red, cube.front[0, 2]);
        }

        [Fact]
        public void TestRotateUpClockwise()
        {
            var cube = new RubiksCube();

            cube.up[0, 0] = White;
            cube.up[0, 1] = Orange;
            cube.up[0, 2] = Green;
            cube.up[1, 0] = Red;
            cube.up[1, 1] = White;
            cube.up[1, 2] = Blue;
            cube.up[2, 0] = Yellow;
            cube.up[2, 1] = White;
            cube.up[2, 2] = Orange;

            cube.RotateUpClockwise();

            Assert.Equal(Yellow, cube.up[0, 0]);
            Assert.Equal(Red, cube.up[0, 1]);
            Assert.Equal(White, cube.up[0, 2]);
            Assert.Equal(White, cube.up[1, 0]);
            Assert.Equal(White, cube.up[1, 1]);
            Assert.Equal(Orange, cube.up[1, 2]);
            Assert.Equal(Orange, cube.up[2, 0]);
            Assert.Equal(Blue, cube.up[2, 1]);
            Assert.Equal(Green, cube.up[2, 2]);
        }

        [Fact]
        public void TestEdgeRotateRightCounterClockwise()
        {
            var cube = new RubiksCube();

            cube.up[0, 2] = White;
            cube.up[1, 2] = White;
            cube.up[2, 2] = White;

            cube.front[0, 2] = Green;
            cube.front[1, 2] = Green;
            cube.front[2, 2] = Green;

            cube.down[0, 2] = Yellow;
            cube.down[1, 2] = Yellow;
            cube.down[2, 2] = Yellow;

            cube.back[0, 0] = Blue;
            cube.back[1, 0] = Blue;
            cube.back[2, 0] = Blue;

            cube.RotateRightCounterClockwise();

            Assert.Equal(Red, cube.right[1, 1]);

            Assert.Equal(Blue, cube.up[0, 2]);
            Assert.Equal(Blue, cube.up[1, 2]);
            Assert.Equal(Blue, cube.up[2, 2]);

            Assert.Equal(White, cube.front[0, 2]);
            Assert.Equal(White, cube.front[1, 2]);
            Assert.Equal(White, cube.front[2, 2]);

            Assert.Equal(Green, cube.down[0, 2]);
            Assert.Equal(Green, cube.down[1, 2]);
            Assert.Equal(Green, cube.down[2, 2]);

            Assert.Equal(Yellow, cube.back[0, 0]);
            Assert.Equal(Yellow, cube.back[1, 0]);
            Assert.Equal(Yellow, cube.back[2, 0]);
        }

        [Fact]
        public void TestRotateRightCounterClockwise()
        {
            var cube = new RubiksCube();

            cube.right[0, 0] = White;
            cube.right[0, 1] = Orange;
            cube.right[0, 2] = Green;
            cube.right[1, 0] = Red;
            cube.right[1, 1] = Red;
            cube.right[1, 2] = Blue;
            cube.right[2, 0] = Yellow;
            cube.right[2, 1] = White;
            cube.right[2, 2] = Orange;

            cube.RotateRightCounterClockwise();

            Assert.Equal(Green, cube.right[0, 0]);
            Assert.Equal(Blue, cube.right[0, 1]);
            Assert.Equal(Orange, cube.right[0, 2]);
            Assert.Equal(Orange, cube.right[1, 0]);
            Assert.Equal(Red, cube.right[1, 1]);
            Assert.Equal(White, cube.right[1, 2]);
            Assert.Equal(White, cube.right[2, 0]);
            Assert.Equal(Red, cube.right[2, 1]);
            Assert.Equal(Yellow, cube.right[2, 2]);
        }

        [Fact]
        public void TestEdgeRotateBackCounterClockwise()
        {
            var cube = new RubiksCube();

            cube.up[0, 0] = White;
            cube.up[0, 1] = White;
            cube.up[0, 2] = White;

            cube.right[0, 2] = Red;
            cube.right[1, 2] = Red;
            cube.right[2, 2] = Red;

            cube.down[2, 0] = Yellow;
            cube.down[2, 1] = Yellow;
            cube.down[2, 2] = Yellow;

            cube.left[0, 0] = Orange;
            cube.left[1, 0] = Orange;
            cube.left[2, 0] = Orange;

            cube.RotateBackCounterClockwise();

            Assert.Equal(Blue, cube.back[1, 1]);

            Assert.Equal(Orange, cube.up[0, 0]);
            Assert.Equal(Orange, cube.up[0, 1]);
            Assert.Equal(Orange, cube.up[0, 2]);

            Assert.Equal(White, cube.right[0, 2]);
            Assert.Equal(White, cube.right[1, 2]);
            Assert.Equal(White, cube.right[2, 2]);

            Assert.Equal(Red, cube.down[2, 0]);
            Assert.Equal(Red, cube.down[2, 1]);
            Assert.Equal(Red, cube.down[2, 2]);

            Assert.Equal(Yellow, cube.left[0, 0]);
            Assert.Equal(Yellow, cube.left[1, 0]);
            Assert.Equal(Yellow, cube.left[2, 0]);
        }

        [Fact]
        public void TestRotateBackCounterClockwise()
        {
            var cube = new RubiksCube();

            cube.back[0, 0] = White;
            cube.back[0, 1] = Orange;
            cube.back[0, 2] = Green;
            cube.back[1, 0] = Red;
            cube.back[1, 1] = Blue;
            cube.back[1, 2] = Blue;
            cube.back[2, 0] = Yellow;
            cube.back[2, 1] = White;
            cube.back[2, 2] = Orange;

            cube.RotateBackCounterClockwise();

            Assert.Equal(Green, cube.back[0, 0]);
            Assert.Equal(Blue, cube.back[0, 1]);
            Assert.Equal(Orange, cube.back[0, 2]);
            Assert.Equal(Orange, cube.back[1, 0]);
            Assert.Equal(Blue, cube.back[1, 1]);
            Assert.Equal(White, cube.back[1, 2]);
            Assert.Equal(White, cube.back[2, 0]);
            Assert.Equal(Red, cube.back[2, 1]);
            Assert.Equal(Yellow, cube.back[2, 2]);
        }

        [Fact]
        public void TestEdgeRotateLeftClockwise()
        {
            var cube = new RubiksCube();

            cube.up[0, 0] = White;
            cube.up[1, 0] = White;
            cube.up[2, 0] = White;

            cube.front[0, 0] = Green;
            cube.front[1, 0] = Green;
            cube.front[2, 0] = Green;

            cube.down[0, 0] = Yellow;
            cube.down[1, 0] = Yellow;
            cube.down[2, 0] = Yellow;

            cube.back[0, 2] = Blue;
            cube.back[1, 2] = Blue;
            cube.back[2, 2] = Blue;

            cube.RotateLeftClockwise();

            Assert.Equal(Orange, cube.left[1, 1]);

            Assert.Equal(Blue, cube.up[0, 0]);
            Assert.Equal(Blue, cube.up[1, 0]);
            Assert.Equal(Blue, cube.up[2, 0]);

            Assert.Equal(White, cube.front[0, 0]);
            Assert.Equal(White, cube.front[1, 0]);
            Assert.Equal(White, cube.front[2, 0]);

            Assert.Equal(Green, cube.down[0, 0]);
            Assert.Equal(Green, cube.down[1, 0]);
            Assert.Equal(Green, cube.down[2, 0]);

            Assert.Equal(Yellow, cube.back[0, 2]);
            Assert.Equal(Yellow, cube.back[1, 2]);
            Assert.Equal(Yellow, cube.back[2, 2]);
        }

        [Fact]
        public void TestRotateLeftClockwise()
        {
            var cube = new RubiksCube();

            cube.left[0, 0] = White;
            cube.left[0, 1] = Orange;
            cube.left[0, 2] = Green;
            cube.left[1, 0] = Red;
            cube.left[1, 1] = Orange;
            cube.left[1, 2] = Blue;
            cube.left[2, 0] = Yellow;
            cube.left[2, 1] = White;
            cube.left[2, 2] = Orange;

            cube.RotateLeftClockwise();

            Assert.Equal(Yellow, cube.left[0, 0]);
            Assert.Equal(Red, cube.left[0, 1]);
            Assert.Equal(White, cube.left[0, 2]);
            Assert.Equal(White, cube.left[1, 0]);
            Assert.Equal(Orange, cube.left[1, 1]);
            Assert.Equal(Orange, cube.left[1, 2]);
            Assert.Equal(Orange, cube.left[2, 0]);
            Assert.Equal(Blue, cube.left[2, 1]);
            Assert.Equal(Green, cube.left[2, 2]);
        }


        [Fact]
    public void TestEdgeRotateDownCounterClockwise()
        {
            var cube = new RubiksCube();

            cube.front[2, 0] = Green;
            cube.front[2, 1] = Green;
            cube.front[2, 2] = Green;

            cube.right[2, 0] = Red;
            cube.right[2, 1] = Red;
            cube.right[2, 2] = Red;

            cube.back[2, 0] = Blue;
            cube.back[2, 1] = Blue;
            cube.back[2, 2] = Blue;

            cube.left[2, 0] = Orange;
            cube.left[2, 1] = Orange;
            cube.left[2, 2] = Orange;

            cube.RotateDownCounterClockwise();

            Assert.Equal(Yellow, cube.down[1, 1]);

            Assert.Equal(Red, cube.front[2, 0]);
            Assert.Equal(Red, cube.front[2, 1]);
            Assert.Equal(Red, cube.front[2, 2]);

            Assert.Equal(Blue, cube.right[2, 0]);
            Assert.Equal(Blue, cube.right[2, 1]);
            Assert.Equal(Blue, cube.right[2, 2]);

            Assert.Equal(Orange, cube.back[2, 0]);
            Assert.Equal(Orange, cube.back[2, 1]);
            Assert.Equal(Orange, cube.back[2, 2]);

            Assert.Equal(Green, cube.left[2, 0]);
            Assert.Equal(Green, cube.left[2, 1]);
            Assert.Equal(Green, cube.left[2, 2]);
        }

        [Fact]
        public void TestRotateDownCounterClockwise()
        {
            var cube = new RubiksCube();

            cube.down[0, 0] = White;
            cube.down[0, 1] = Orange;
            cube.down[0, 2] = Green;
            cube.down[1, 0] = Red;
            cube.down[1, 1] = Yellow;
            cube.down[1, 2] = Blue;
            cube.down[2, 0] = Yellow;
            cube.down[2, 1] = White;
            cube.down[2, 2] = Orange;

            cube.RotateDownCounterClockwise();

            Assert.Equal(Green, cube.down[0, 0]);
            Assert.Equal(Blue, cube.down[0, 1]);
            Assert.Equal(Orange, cube.down[0, 2]);
            Assert.Equal(Orange, cube.down[1, 0]);
            Assert.Equal(Yellow, cube.down[1, 1]);
            Assert.Equal(White, cube.down[1, 2]);
            Assert.Equal(White, cube.down[2, 0]);
            Assert.Equal(Red, cube.down[2, 1]);
            Assert.Equal(Yellow, cube.down[2, 2]);
        }

 

        [Fact]
        public void TestSequentialRotations()
        {
            var cube = new RubiksCube();

            AssertSolvedCube(cube);

    
            cube.RotateFrontClockwise();
        
            Assert.Equal(Orange, cube.up[2, 0]);
            Assert.Equal(Orange, cube.up[2, 1]);
            Assert.Equal(Orange, cube.up[2, 2]);

            Assert.Equal(White, cube.right[0, 0]);
            Assert.Equal(White, cube.right[1, 0]);
            Assert.Equal(White, cube.right[2, 0]);

            Assert.Equal(Yellow, cube.left[0, 2]);
            Assert.Equal(Yellow, cube.left[1, 2]);
            Assert.Equal(Yellow, cube.left[2, 2]);


            Assert.Equal(Red, cube.down[0, 0]);
            Assert.Equal(Red, cube.down[0, 1]);
            Assert.Equal(Red, cube.down[0, 2]);



   
            cube.RotateRightCounterClockwise();
  
            Assert.Equal(White, cube.front[0, 2]);
            Assert.Equal(White, cube.front[1, 2]);
            Assert.Equal(Orange, cube.front[2, 2]);

            //up 

 
            cube.RotateUpClockwise();
        
            Assert.Equal(Yellow, cube.right[0, 0]);
            Assert.Equal(Blue, cube.right[0, 1]);
            Assert.Equal(Blue, cube.right[0, 2]);

            cube.RotateBackCounterClockwise();
            Assert.Equal(Yellow, cube.back[0, 0]);
            Assert.Equal(Blue, cube.back[0, 1]);
            Assert.Equal(Blue, cube.back[0, 2]);

            cube.RotateLeftClockwise();

            Assert.Equal(Orange, cube.front[0, 0]);
            Assert.Equal(Orange, cube.front[1, 0]);
            Assert.Equal(Blue, cube.front[2, 0]);

            Assert.Equal(Red, cube.up[0, 0]);
            Assert.Equal(Blue, cube.up[1, 0]);
            Assert.Equal(Blue, cube.up[2, 0]);


            cube.RotateDownCounterClockwise();

            // final state matches expected result imgae
            Assert.Equal(Red, cube.up[0, 0]);
            Assert.Equal(Orange, cube.up[0, 1]);
            Assert.Equal(Green, cube.up[0, 2]);

            Assert.Equal(Blue, cube.up[1, 0]);
            Assert.Equal(White, cube.up[1, 1]);
            Assert.Equal(White, cube.up[1, 2]);

            Assert.Equal(Blue, cube.up[2, 0]);
            Assert.Equal(Blue, cube.up[2, 1]);
            Assert.Equal(Blue, cube.up[2, 2]);
        }


        private void AssertSolvedCube(RubiksCube cube)
        {
            // Verify all faces have their expected centers
            Assert.Equal(White, cube.up[1, 1]);
            Assert.Equal(Green, cube.front[1, 1]);
            Assert.Equal(Red, cube.right[1, 1]);
            Assert.Equal(Blue, cube.back[1, 1]);
            Assert.Equal(Orange, cube.left[1, 1]);
            Assert.Equal(Yellow, cube.down[1, 1]);

            // Verify each face is a solid color
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.Equal(White, cube.up[i, j]);
                    Assert.Equal(Green, cube.front[i, j]);
                    Assert.Equal(Red, cube.right[i, j]);
                    Assert.Equal(Blue, cube.back[i, j]);
                    Assert.Equal(Orange, cube.left[i, j]);
                    Assert.Equal(Yellow, cube.down[i, j]);
                }
            }
        }

    }
}