namespace Day3Kuis
{
    class No7
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
        public static void SquareMatrix()
        {

            int n = 7 ;
            int[,] matrik = new int[n, n];
            
            for (int row = 0; row < matrik.GetLength(0); row++)
            {

                for (int column = 0; column < matrik.GetLength(1); column++)
                {

                    if (row==0||column==n-1)
                    {
                        matrik[row, column] = row + column;
                        Console.Write(matrik);
                    }else if (row==n-1||column==0)
                    {
                        matrik[row, column] = (((n - 1) * 4) - (row + column));
                        Console.Write(column);
                    }
                    else
                    {
                        Console.Write("");
                    }
                    //if (row == 1)
                    //{
                    //    if (column == 3 || row == 2 || row == 5)
                    //    {
                    //        Console.Write(defff);
                    //        Console.Write("\t");

                    //    }
                    //    else {
                    //        Console.Write(temp);
                    //        Console.Write("\t");
                    //        temp = temp + defff;
                    //    }
                    //}
                    //else if (column == n.GetLength(1))
                    //{


                    //        temp = temp + defff;
                    //        //++temp;
                    //        Console.Write(temp);
                    //        Console.Write("\t");


                    //}
                    //else if (column == 1)
                    //{
                    //    ++nilaiKolom;
                    //    Console.Write(nilaiKolom);

                    //}
                    //else if (row == n.GetLength(0))
                    //{
                    //    ++kebalikan2;
                    //    Console.Write(kebalikan2);
                    //}
                    //else if (column == n.GetLength(1))
                    //{
                    //    ++kebalikan;
                    //    Console.Write(kebalikan);
                    //}

                    //Console.Write("\t");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
//            ShowResult(matrik);
        }
    }
}