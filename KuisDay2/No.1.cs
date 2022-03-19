namespace Day2Kuis
{
    class No1
    {
        public static void RandomAngka()
        {
            int[] arry = { 15, 2, 30, 12, 10, 5};
            Random random = new Random();
            DisplayArrayNumber(arry);
            //Random random = new Random();
            int[] arr = new int[arry.Length];
            List<int> selectedRandom = new List<int>();


            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = random.Next(arry[i]);
                int temp = random.Next(arr.Length);
                if (!selectedRandom.Contains(temp))
                {
                    selectedRandom.Add(temp);
                    arr[temp] = arry[i];
                }
                else
                {
                    i--;
                }

            }

            Console.WriteLine("Angka setelah random: ");
            foreach (int j in arr)
            {
                Console.Write(j + " ");
            }
        }
        static void DisplayArrayNumber(int[] angka)
        {
            Console.WriteLine("Angka Sebelum : ");
            for (int i = 0; i < angka.Length; i++)
            {
                Console.Write(angka[i] + " ");
            }
            Console.WriteLine();
        }
    }

}