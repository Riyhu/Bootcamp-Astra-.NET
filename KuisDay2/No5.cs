namespace Day2Kuis
{
    class No5
    {
        static void DisplayArrayNumber(int[] angka)
        {
            
            for (int i = 0; i < angka.Length; i++)
            {
                Console.Write(angka[i] + " ");
            }
            Console.WriteLine();
        }
        public static void CountValue()
        {
            int[] arry = new int[] { 5, 2, 30, 12, 10, 5, 2, 10, 5 };
            DisplayArrayNumber(arry);
            //int[] temp = new int[arry.Length];
            List<int> nilaiSama = new List<int>();

            for (int i = 0; i < arry.Length; i++)
            {
                int flag = 1;
                if (nilaiSama.Contains(arry[i]))
                {
                    continue;
                }
                for (int j = i + 1; j < arry.Length; j++)
                {

                    if (arry[i] == arry[j])
                    {
                        flag++;
                        nilaiSama.Add(arry[i]);
                    }
                }
                Console.WriteLine("banyak nya angka " + arry[i] + " sebanyak " + flag);
            }
        }

    }
}
