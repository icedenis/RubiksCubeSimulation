namespace RubiksCubeSimulation.Models
{
    public class RubiksCube
    {
        public enum Color
        {
            Green, Red, White, Blue, Orange, Yellow
        }

        public Color[,] front;
        public Color[,] right;
        public Color[,] up;
        public Color[,] back;
        public Color[,] left;
        public Color[,] down;

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
           
            Color[,] rotatedFront = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedFront[j, 2 - i] = front[i, j];
            front = rotatedFront;

        
            Color[] upEdge ={ up[2, 0], up[2, 1], up[2, 2] };
            Color[] rightEdge = { right[0, 0], right[1, 0], right[2, 0] };
            Color[] downEdge = { down[0, 0], down[0, 1], down[0, 2] };
            Color[] leftEdge = { left[0, 2], left[1, 2], left[2, 2] };

        
            right[0, 0] = upEdge[0];
            right[1, 0] = upEdge[1];
            right[2, 0] = upEdge[2];

            down[0, 0] = rightEdge[2];
            down[0, 1] = rightEdge[1];
            down[0, 2] = rightEdge[0];

            left[0, 2] = downEdge[0];
            left[1, 2] = downEdge[1];
            left[2, 2] = downEdge[2];

            up[2, 0] = leftEdge[2];
            up[2, 1] = leftEdge[1];
            up[2, 2] = leftEdge[0];
        }

        public void RotateFrontCounterClockwise()
        {
           
            Color[,] rotatedFront = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedFront[2 - j, i] = front[i, j];
            front = rotatedFront;

           
            Color[] upEdge =  { up[2, 0], up[2, 1], up[2, 2] };
            Color[] rightEdge =  { right[0, 0], right[1, 0], right[2, 0] };
            Color[] downEdge =  { down[0, 0], down[0, 1], down[0, 2] };
            Color[] leftEdge = { left[0, 2], left[1, 2], left[2, 2] };

            
            left[0, 2] = upEdge[2];
            left[1, 2] = upEdge[1];
            left[2, 2] = upEdge[0];

            up[2, 0] = rightEdge[0];
            up[2, 1] = rightEdge[1];
            up[2, 2] = rightEdge[2];

            right[0, 0] = downEdge[2];
            right[1, 0] = downEdge[1];
            right[2, 0] = downEdge[0];

            down[0, 0] = leftEdge[0];
            down[0, 1] = leftEdge[1];
            down[0, 2] = leftEdge[2];
        }

        public void RotateRightClockwise()
        {
           
            Color[,] rotatedRight = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedRight[j, 2 - i] = right[i, j];
            right = rotatedRight;

            Color[] upEdge = { up[0, 2], up[1, 2], up[2, 2] };       
            Color[] backEdge = { back[2, 0], back[1, 0], back[0, 0] }; 
            Color[] downEdge = { down[0, 2], down[1, 2], down[2, 2] }; 
            Color[] frontEdge = { front[0, 2], front[1, 2], front[2, 2] };

    
            back[2, 0] = upEdge[0];
            back[1, 0] = upEdge[1];
            back[0, 0] = upEdge[2];

          
            down[0, 2] = backEdge[0];
            down[1, 2] = backEdge[1];
            down[2, 2] = backEdge[2];

        
            front[0, 2] = downEdge[0];
            front[1, 2] = downEdge[1];
            front[2, 2] = downEdge[2];

            up[0, 2] = frontEdge[0];
            up[1, 2] = frontEdge[1];
            up[2, 2] = frontEdge[2];
        }

        public void RotateRightCounterClockwise()
        {
       
            Color[,] rotatedRight = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedRight[2 - j, i] = right[i, j];
            right = rotatedRight;

       
            Color[] upEdge = { up[0, 2], up[1, 2], up[2, 2] };        
            Color[] backEdge = { back[2, 0], back[1, 0], back[0, 0] }; 
            Color[] downEdge = { down[0, 2], down[1, 2], down[2, 2] }; 
            Color[] frontEdge = { front[0, 2], front[1, 2], front[2, 2] };

       
            front[0, 2] = upEdge[0];
            front[1, 2] = upEdge[1];
            front[2, 2] = upEdge[2];

    
            down[0, 2] = frontEdge[0];
            down[1, 2] = frontEdge[1];
            down[2, 2] = frontEdge[2];

           
            back[2, 0] = downEdge[0];
            back[1, 0] = downEdge[1];
            back[0, 0] = downEdge[2];

      
            up[0, 2] = backEdge[0];
            up[1, 2] = backEdge[1];
            up[2, 2] = backEdge[2];
        }

        public void RotateUpCounterClockwise()
        {

            Color[,] rotatedUp = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedUp[2 - j,i] = up[i, j];
            up = rotatedUp;

          
            Color[] frontEdge = { front[0, 0], front[0, 1], front[0, 2] };
            Color[] rightEdge = { right[0, 0], right[0, 1], right[0, 2] };
            Color[] backEdge = { back[0, 0], back[0, 1], back[0, 2] };
            Color[] leftEdge = { left[0, 0], left[0, 1], left[0, 2] };

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

        public void RotateUpClockwise()
        {
      
            Color[,] rotatedUp = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedUp[j, 2 - i] = up[i, j];
            up = rotatedUp;

            Color[] frontEdge =  { front[0, 0], front[0, 1], front[0, 2] };
            Color[] rightEdge = { right[0, 0], right[0, 1], right[0, 2] };
            Color[] backEdge = { back[0, 0], back[0, 1], back[0, 2] };
            Color[] leftEdge = { left[0, 0], left[0, 1], left[0, 2] };

     
            left[0, 0] = frontEdge[0];
            left[0, 1] = frontEdge[1];
            left[0, 2] = frontEdge[2];

            front[0, 0] = rightEdge[0];
            front[0, 1] = rightEdge[1];
            front[0, 2] = rightEdge[2];

            right[0, 0] = backEdge[0];
            right[0, 1] = backEdge[1];
            right[0, 2] = backEdge[2];

            back[0, 0] = leftEdge[0];
            back[0, 1] = leftEdge[1];
            back[0, 2] = leftEdge[2];
        }
        public void RotateBackCounterClockwise()
        {
            Color[,] rotatedBack = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedBack[2 - j, i] = back[i, j];
            back = rotatedBack;

            Color[] upEdge = { up[0, 0], up[0, 1], up[0, 2] };
            Color[] rightEdge = { right[0, 2], right[1, 2], right[2, 2] };
            Color[] downEdge = { down[2, 0], down[2, 1], down[2, 2] };
            Color[] leftEdge = { left[0, 0], left[1, 0], left[2, 0] };

            // Correctly map the edges after back face rotation
            up[0, 0] = leftEdge[2];
            up[0, 1] = leftEdge[1];
            up[0, 2] = leftEdge[0];

            right[0, 2] = upEdge[0];
            right[1, 2] = upEdge[1];
            right[2, 2] = upEdge[2];

            down[2, 0] = rightEdge[2];
            down[2, 1] = rightEdge[1];
            down[2, 2] = rightEdge[0];

            left[0, 0] = downEdge[0];
            left[1, 0] = downEdge[1];
            left[2, 0] = downEdge[2];
        }

        public void RotateBackClockwise()
        {
            Color[,] rotatedBack = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedBack[j, 2 - i] = back[i, j];
            back = rotatedBack;

            Color[] upEdge = { up[0, 0], up[0, 1], up[0, 2] };
            Color[] rightEdge = { right[0, 2], right[1, 2], right[2, 2] };
            Color[] downEdge = { down[2, 0], down[2, 1], down[2, 2] };
            Color[] leftEdge = { left[0, 0], left[1, 0], left[2, 0] };

            up[0, 0] = rightEdge[0];
            up[0, 1] = rightEdge[1];
            up[0, 2] = rightEdge[2];


            left[0, 0] = upEdge[2];
            left[1, 0] = upEdge[1];
            left[2, 0] = upEdge[0];

          right[0, 2] = downEdge[2];
          right[1, 2] = downEdge[1];
          right[2, 2] = downEdge[0];

            down[2, 0] = leftEdge[0];
            down[2, 1] = leftEdge[1];
            down[2, 2] = leftEdge[2];


        }

        public void RotateLeftCounterClockwise()
        {
   
            Color[,] rotatedLeft = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedLeft[2 - j, i] = left[i, j];
            left = rotatedLeft;

            Color[] upEdge = { up[0, 0], up[1, 0], up[2, 0] };
            Color[] frontEdge = { front[0, 0], front[1, 0], front[2, 0] };
            Color[] downEdge = { down[0, 0], down[1, 0], down[2, 0] };
            Color[] backEdge = { back[0, 2], back[1, 2], back[2, 2] };

            back[0, 2] = upEdge[2];
            back[1, 2] = upEdge[1];
            back[2, 2] = upEdge[0];

            down[0, 0] = backEdge[2];
            down[1, 0] = backEdge[1];
            down[2, 0] = backEdge[0];

            front[0, 0] = downEdge[0];
            front[1, 0] = downEdge[1];
            front[2, 0] = downEdge[2];

            up[0, 0] = frontEdge[0];
            up[1, 0] = frontEdge[1];
            up[2, 0] = frontEdge[2];
        }

        public void RotateLeftClockwise()
        {
            Color[,] rotatedLeft = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedLeft[j, 2 - i] = left[i, j];
            left = rotatedLeft;

   
            Color[] upEdge = { up[0, 0], up[1, 0], up[2, 0] };
            Color[] frontEdge = { front[0, 0], front[1, 0], front[2, 0] };
            Color[] downEdge = { down[0, 0], down[1, 0], down[2, 0] };
            Color[] backEdge = { back[0, 2], back[1, 2], back[2, 2] };

            front[0, 0] = upEdge[0];
            front[1, 0] = upEdge[1];
            front[2, 0] = upEdge[2];

            down[0, 0] = frontEdge[0];
            down[1, 0] = frontEdge[1];
            down[2, 0] = frontEdge[2];

          
            back[0, 2] = downEdge[2];
            back[1, 2] = downEdge[1];
            back[2, 2] = downEdge[0];
            //bug here 
            up[0, 0] = backEdge[2];  
            up[1, 0] = backEdge[1];  
            up[2, 0] = backEdge[0];
        }

        public void RotateDownClockwise()
        {
      
            Color[,] rotatedDown = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedDown[j, 2 - i] = down[i, j];
            down = rotatedDown;

      
            Color[] frontEdge = { front[2, 0], front[2, 1], front[2, 2] };
            Color[] rightEdge = { right[2, 0], right[2, 1], right[2, 2] };
            Color[] backEdge = { back[2, 0], back[2, 1], back[2, 2] };
            Color[] leftEdge ={ left[2, 0], left[2, 1], left[2, 2] };

        
            right[2, 0] = frontEdge[0];
            right[2, 1] = frontEdge[1];
            right[2, 2] = frontEdge[2];

            back[2, 0] = rightEdge[0];
            back[2, 1] = rightEdge[1];
            back[2, 2] = rightEdge[2];

            left[2, 0] = backEdge[0];
            left[2, 1] = backEdge[1];
            left[2, 2] = backEdge[2];

            front[2, 0] = leftEdge[0];
            front[2, 1] = leftEdge[1];
            front[2, 2] = leftEdge[2];
        }

        public void RotateDownCounterClockwise()
        {

            Color[,] rotatedDown = new Color[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    rotatedDown[2 - j, i] = down[i, j];
            down = rotatedDown;

      
            Color[] frontEdge =  { front[2, 0], front[2, 1], front[2, 2] };
            Color[] rightEdge =  { right[2, 0], right[2, 1], right[2, 2] };
            Color[] backEdge =  { back[2, 0], back[2, 1], back[2, 2] };
            Color[] leftEdge =  { left[2, 0], left[2, 1], left[2, 2] };

            left[2, 0] = frontEdge[0];
            left[2, 1] = frontEdge[1];
            left[2, 2] = frontEdge[2];

            front[2, 0] = rightEdge[0];
            front[2, 1] = rightEdge[1];
            front[2, 2] = rightEdge[2];

            right[2, 0] = backEdge[0];
            right[2, 1] = backEdge[1];
            right[2, 2] = backEdge[2];

            back[2, 0] = leftEdge[0];
            back[2, 1] = leftEdge[1];
            back[2, 2] = leftEdge[2];
        }






        //public void PrintCube()
        //{
        //    Console.WriteLine("Cube State:");
        //    PrintFace("Up", up);
        //    PrintFace("Front", front);
        //    PrintFace("Right", right);
        //    PrintFace("Back", back);
        //    PrintFace("Left", left);
        //    PrintFace("Down", down);
        //}

        public void PrintCube()
        {
            Console.WriteLine();
            Console.WriteLine("Up Face (White)");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("       "); 
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]:{up[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Left Face (Orange)                    Front Face (Green)                    Right Face (Red)                    Back Face (Blue)");
            for (int i = 0; i < 3; i++)
            {
                // Left face
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]:{left[i, j]} ");
                }
                Console.Write("  ");

       
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]:{front[i, j]} ");
                }
                Console.Write("  ");

       
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]:{right[i, j]} ");
                }
                Console.Write("  ");

          
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]:{back[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Down Face (Yellow)");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("       ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]:{down[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //private void PrintFace(string faceName, Color[,] face)
        //{
        //    Console.WriteLine($"{faceName} Face :");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write($"[{i},{j}]:{face[i, j]} ");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}
    }
}