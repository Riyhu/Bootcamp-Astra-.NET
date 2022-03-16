namespace Day1Kuis
{
    class No5
    {
        public static void ShowAngkaPembagi()
        {
            Console.Write("Masukkan Angka : ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < input; i++)
            {
                if (input%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}