namespace Day3Kuis
{
    class No6
    {
        public static void TriagleMatrix()
        {
            int n = 7;
            int nilai = 1;
            int[] arry = new int[n];
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i>=2 && i<=5 && j==6)
                    {
                        Console.Write("");
                    }
                    else if (i >= 2 && i <= 4 && j == 5)
                    {
                        Console.Write("");
                    }
                    else if (i>=2 && i<=3 &&j==4)
                    {
                        Console.Write("");
                    }else if (i==2 &&j==3)
                    {
                        Console.Write("");
                    }
                    
                    else
                    {
                        if (i <= j)
                        {
                            Console.Write(nilai);
                            nilai ++;
                        }
                    }
                    
                    //else
                    //{
                    //    Console.Write("");
                    //}
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}