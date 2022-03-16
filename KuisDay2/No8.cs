namespace Day2Kuis
{
    class No8
    {
        public static void RandomChar()
        {
            String[] arry = new String[100];
            String[] arry2 = new String[arry.Length];
            Random random = new Random();
            for (int i = 0; i < arry.Length; i++)
            {
                int temp = random.Next();
                arry2[temp] = arry[i];
            }
            Console.WriteLine("Angka setelah random: ");
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(arry[i] + " ");
            }
        }
    }
}