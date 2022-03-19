namespace Day3Kuis
{
    class No4
    {
        public static void SquareMatrix()
        {
            int[,] n = new int [7,7];
            int nilaiBaris ;
            int nilaiKolom=0;
            int kebalikan = 6;


            for (int row = 1; row <= n.GetLength(0); row++)
            {
                nilaiBaris = 0;
                int kebalikan2 = 6;


                for (int column = 1; column <= n.GetLength(1); column++)
                {
                    if (row == 1 )
                    {
                        Console.Write(nilaiBaris);
                        nilaiBaris++;
                    } 
                    else if (column==1)
                    {
                        ++nilaiKolom;
                        Console.Write(nilaiKolom);
                        
                    }
                    else if (row == n.GetLength(0))
                    {
                        ++kebalikan2;
                        Console.Write(kebalikan2);
                    }else if (column == n.GetLength(1))
                    {
                        ++kebalikan;
                        Console.Write(kebalikan);
                    }
                    else
                    {
                        Console.Write("");
                    }
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}