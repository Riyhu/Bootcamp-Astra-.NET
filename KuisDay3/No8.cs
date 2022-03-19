namespace Day3Kuis
{
    class No8
    {
        static void ShowResult(string[,] matrix)
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
        public static void StudentExam()
        {
            string[,] stdnExam =
            {
                {"A","B","A","C","C","D","E","E","A","D" },
                {"D","B","A","B","C","A","E","E","A","D" },
                {"E","D","D","A","C","B","E","E","A","D" },
                {"C","B","A","E","D","C","E","E","A","D" },
                {"A","B","D","C","C","D","E","E","A","D" },
                {"B","B","E","C","C","D","E","E","A","D" },
                {"B","B","A","C","C","D","E","E","A","D" },
                {"E","B","E","C","C","D","E","E","A","D" }

            };
            ShowResult(stdnExam);
            Console.WriteLine();
            string[,] kncJwbn =
            {
            {"D","B","D","C","C","D","A","E","A","D" }
            };
            ShowResult(kncJwbn);
            for (int i = 0; i < stdnExam.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < stdnExam.GetLength(1); j++)
                {
                    for (int k = 0; k < kncJwbn.GetLength(0); k++)
                    {
                        if (stdnExam[i, j] == kncJwbn[k, j])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Jawaban Siswa {i} : yang benar adalah {count}");
            }
        }
    }
}