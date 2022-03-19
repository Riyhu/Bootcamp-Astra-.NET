namespace Day3
{
    class Arrays2D
    {
        public static void InsialisasiMatrix()
        {
            int[,] matrix = new int[5,5];
            int[,] matrix2 =
            {
                {1,2,3,4,5},
                {11,12,13,14,15},
                {21,22,23,24,25},
                {31,32,33,34,35},
                {41,42,43,44,45}
            };
            ShowResult(matrix2);
        }
        public static void ShowResult(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.Write("\n");
            }
        }


        
        public static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        public static int[,] RandomMatrix()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[column, row] = column+row;
                }
            }
            return matrix;
        }
    }
}