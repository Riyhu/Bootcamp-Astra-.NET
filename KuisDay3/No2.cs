namespace Day3Kuis
{
    class No2
    {
        static void ShowResult(int[,] matrix)
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
        public static void inverseMatrix5x5()
        {
            int[,] matrik = new int[5, 5];
            int rverse = matrik.GetLength(0);
            for (int row = 0; row < matrik.GetLength(0); row++)
            {
                for (int col = 0; col < matrik.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        matrik[row, col] = rverse;//valuee;
                        rverse--;
                    }
                    else if (row > col)
                    {
                        matrik[row, col] = 10;
                    }
                    else
                    {
                        matrik[row, col] = 20;
                    }
                }
            }
            ShowResult(matrik);
        }
    }
}