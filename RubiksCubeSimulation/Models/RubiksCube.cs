namespace RubiksCubeSimulation.Models
{
    public class RubiksCube
    {
        public enum Color
        {
            Green, Red, White, Blue, Orange, Yellow
        }

        private Color[,] front;
        private Color[,] right;
        private Color[,] up;
        private Color[,] back;
        private Color[,] left;
        private Color[,] down;

        public RubiksCube()
        {
            InitializeSolvedCube();
        }

        private void InitializeSolvedCube()
        {
            front = CreateFace(Color.Green);
            right = CreateFace(Color.Red);
            up = CreateFace(Color.White);
            back = CreateFace(Color.Blue);
            left = CreateFace(Color.Orange);
            down = CreateFace(Color.Yellow);
        }

        private Color[,] CreateFace(Color color)
        {
            Color[,] face = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    face[i, j] = color;
            return face;
        }


        public void RotateFrontClockwise()
        {
            // Rotate 
            Color[,] rotatedFront = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedFront[j, 2 - i] = front[i, j];
            front = rotatedFront;

        
            // original edge colors
            Color[] upEdge = { up[2, 0], up[2, 1], up[2, 2] };
            Color[] rightEdge = { right[0, 0], right[1, 0], right[2, 0] };
            Color[] downEdge = { down[0, 2], down[0, 1], down[0, 0] };
            Color[] leftEdge = { left[2, 2], left[1, 2], left[0, 2] };

            // Color Changes        
            up[2, 0] = leftEdge[2];
            up[2, 1] = leftEdge[1];
            up[2, 2] = leftEdge[0];

        
            right[0, 0] = upEdge[0];
            right[1, 0] = upEdge[1];
            right[2, 0] = upEdge[2];

            down[0, 2] = rightEdge[2];
            down[0, 1] = rightEdge[1];
            down[0, 0] = rightEdge[0];

         
            left[2, 2] = downEdge[0];
            left[1, 2] = downEdge[1];
            left[0, 2] = downEdge[2];
        }

        public void RotateFrontCounterClockwise()
        {
            // Rotate  Anti
            Color[,] rotatedFront = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedFront[2 - j, i] = front[i, j];
            front = rotatedFront;

            // original edge colors
            Color[] upEdge = { up[2, 0], up[2, 1], up[2, 2] };
            Color[] rightEdge = { right[0, 0], right[1, 0], right[2, 0] };
            Color[] downEdge = { down[0, 2], down[0, 1], down[0, 0] };
            Color[] leftEdge = { left[2, 2], left[1, 2], left[0, 2] };

            // Color Changes     
            up[2, 0] = rightEdge[0];
            up[2, 1] = rightEdge[1];
            up[2, 2] = rightEdge[2];

            right[0, 0] = downEdge[2];
            right[1, 0] = downEdge[1];
            right[2, 0] = downEdge[0];

        
            down[0, 2] = leftEdge[2];
            down[0, 1] = leftEdge[1];
            down[0, 0] = leftEdge[0];

           
            left[2, 2] = upEdge[2];
            left[1, 2] = upEdge[1];
            left[0, 2] = upEdge[0];
        }

        public void RotateRightClockwise()
        {
            // Rotate 
            Color[,] rotatedRight = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedRight[j, 2 - i] = right[i, j];
            right = rotatedRight;

            // original edge colors
            Color[] upEdge = { up[0, 2], up[1, 2], up[2, 2] };
            Color[] backEdge = { back[0, 0], back[1, 0], back[2, 0] };
            Color[] downEdge = { down[0, 0], down[1, 0], down[2, 0] };
            Color[] frontEdge = { front[0, 2], front[1, 2], front[2, 2] };


            // Color Changes    
            up[0, 2] = frontEdge[0];
            up[1, 2] = frontEdge[1];
            up[2, 2] = frontEdge[2];

      
            back[0, 0] = upEdge[2];
            back[1, 0] = upEdge[1];
            back[2, 0] = upEdge[0];

        
            down[0, 0] = backEdge[0];
            down[1, 0] = backEdge[1];
            down[2, 0] = backEdge[2];

            front[0, 2] = downEdge[0];
            front[1, 2] = downEdge[1];
            front[2, 2] = downEdge[2];
        }

        public void RotateRightCounterClockwise()
        {
            // Rotate 
            Color[,] rotatedRight = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedRight[2 - j, i] = right[i, j];
            right = rotatedRight;

            // original edge colors
            Color[] upEdge = { up[0, 2], up[1, 2], up[2, 2] };
            Color[] backEdge = { back[0, 0], back[1, 0], back[2, 0] };
            Color[] downEdge = { down[0, 0], down[1, 0], down[2, 0] };
            Color[] frontEdge = { front[0, 2], front[1, 2], front[2, 2] };


            // Color Changes 
            up[0, 2] = backEdge[2];
            up[1, 2] = backEdge[1];
            up[2, 2] = backEdge[0];

     
            back[0, 0] = downEdge[0];
            back[1, 0] = downEdge[1];
            back[2, 0] = downEdge[2];

  
            down[0, 0] = frontEdge[0];
            down[1, 0] = frontEdge[1];
            down[2, 0] = frontEdge[2];

           
            front[0, 2] = upEdge[0];
            front[1, 2] = upEdge[1];
            front[2, 2] = upEdge[2];
        }


        public void RotateUpClockwise()
        {
            // Rotate 
            Color[,] rotatedUp = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedUp[j, 2 - i] = up[i, j];
            up = rotatedUp;

            // original edge colors
            Color[] frontEdge = { front[0, 0], front[0, 1], front[0, 2] };
            Color[] rightEdge = { right[0, 0], right[0, 1], right[0, 2] };
            Color[] backEdge = { back[0, 0], back[0, 1], back[0, 2] };
            Color[] leftEdge = { left[0, 0], left[0, 1], left[0, 2] };

            // Color Changes 
            right[0, 0] = frontEdge[0];
            right[0, 1] = frontEdge[1];
            right[0, 2] = frontEdge[2];

            back[0, 0] = rightEdge[0];
            back[0, 1] = rightEdge[1];
            back[0, 2] = rightEdge[2];

        
            left[0, 0] = backEdge[0];
            left[0, 1] = backEdge[1];
            left[0, 2] = backEdge[2];

          
            front[0, 0] = leftEdge[0];
            front[0, 1] = leftEdge[1];
            front[0, 2] = leftEdge[2];
        }

        public void RotateUpCounterClockwise()
        {
            // Rotate anti
            Color[,] rotatedUp = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedUp[2 - j, i] = up[i, j];
            up = rotatedUp;

            // original colors 
            Color[] frontEdge = { front[0, 0], front[0, 1], front[0, 2] };
            Color[] rightEdge = { right[0, 0], right[0, 1], right[0, 2] };
            Color[] backEdge = { back[0, 0], back[0, 1], back[0, 2] };
            Color[] leftEdge = { left[0, 0], left[0, 1], left[0, 2] };

            // Color Changes 
            front[0, 0] = leftEdge[0];
            front[0, 1] = leftEdge[1];
            front[0, 2] = leftEdge[2];

           
            left[0, 0] = backEdge[0];
            left[0, 1] = backEdge[1];
            left[0, 2] = backEdge[2];

         
            back[0, 0] = rightEdge[0];
            back[0, 1] = rightEdge[1];
            back[0, 2] = rightEdge[2];

           
            right[0, 0] = frontEdge[0];
            right[0, 1] = frontEdge[1];
            right[0, 2] = frontEdge[2];
        }






        public void PrintCube()
        {
            Console.WriteLine("Cube State:");
            PrintFace("Up", up);
            PrintFace("Front", front);
            PrintFace("Right", right);
            PrintFace("Back", back);
            PrintFace("Left", left);
            PrintFace("Down", down);
        }

        private void PrintFace(string faceName, Color[,] face)
        {
            Console.WriteLine($"{faceName} Face :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]:{face[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}