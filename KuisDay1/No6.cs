namespace Day1Kuis
{
    class No6
    {
        public static void ShowPrimeNumber()
        {
            Console.Write("Masukkan Angka : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int cek = 0;
            int i, j;
			for ( i = 1; i <= input; i++)
			{
                for (j=1;j<=i;j++)
                {
                    if (i%j==0)
                    {
                        cek++;
                    }
                }
                if (cek==2)
                {
                    Console.Write(i+" ");
                }
                cek = 0;
			}	
		}
    }
}

