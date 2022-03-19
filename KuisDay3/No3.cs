namespace Day3Kuis
{
    class No3
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
        public static void CountDiagonal()
        {
            int[,] matrik = new int[5, 5];
            int tempDiagonal = 0;
            for (int row = 0; row < matrik.GetLength(0); row++)
            {
                for (int col = 0; col < matrik.GetLength(1); col++)
                {
                    Random random = new Random();
                    matrik[row, col] = random.Next(1,9);
                    if (row == col)
                    {
                        tempDiagonal += matrik[row, col]; 
                       
                    }
                }
            }
            ShowResult(matrik);
            Console.WriteLine($"Jumlah Diagonal : {tempDiagonal}");
        }
    }
}