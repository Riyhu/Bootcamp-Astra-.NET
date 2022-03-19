namespace Day3Kuis
{
    class No1
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
        public static void Matrix5x5()
        {
            int[,] matrik = new int[5,5];
            //int valuee = 0;
            int diagonal = 1;
            for (int row = 0; row < matrik.GetLength(0); row++)
            {
                for (int col = matrik.GetLength(1)-1; col >=0; col--)
                {
                    if (row==col)
                    {
                        Console.Write($"{matrik[row,col]+diagonal++}");
                        //matrik[row, col] = diagonal++;//valuee;
                        //valuee++;
                    }else if (row<col)
                    {
                        Console.Write($"{matrik[row, col] = 10}");
                        //matrik[row, col] = ;
                    }
                    else
                    {
                        Console.Write($"{matrik[row, col] = 20}");
                    }
                    Console.Write("\t");

                }
                Console.WriteLine();
            }
//            ShowResult(matrik);
        }
    }
}