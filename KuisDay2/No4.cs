namespace Day2Kuis
{
    class No4
    {
        static void DisplayArrayNumber(int[] angka)
        {
            Console.WriteLine("Angka Sebelum : ");
            for (int i = 0; i < angka.Length; i++)
            {
                Console.Write(angka[i] + " ");
            }
            Console.WriteLine();
        }
        public static void RotateArrayRIGHT()
        {
            int[] arr = new int[] { 15, 2, 30, 12, 10, 5 };
            DisplayArrayNumber(arr);
            int[] temp = new int[arr.Length];
            int i;
            int b;
            Console.WriteLine("Input nilai n :");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            Console.WriteLine("Rotate Shifting " + n + "x");

            for (b = 1; b <= n; b++)
            {
                int l = arr[arr.Length - 1];
                for (i = arr.Length - 1; i >= 0; i--)
                {

                    if (i == 0)
                    {
                        temp[i] = l;
                    }
                    else
                    {
                        temp[i] = arr[i - 1];
                    }
                }
                Console.Write("Rotasi ke " + b + " :\n");
                foreach (int j in temp)
                {
                    Console.Write(j + " ");
                }
                arr = temp;
                Console.Write("\n");
            }
        }
    }
}