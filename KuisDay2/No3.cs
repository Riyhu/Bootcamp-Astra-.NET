namespace Day2Kuis
{
    class No3
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
        public static void RotateArrayLEFT()
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
//                int l = arr[arr.Length - 1];
                for (i = 0; i < arr.Length; i++)
                {

                    if (i == arr.Length - 1)
                    {
                        temp[i] = arr[0];
                    }
                    else
                    {
                        temp[i] = arr[i + 1];
                    }
                }
                Console.Write("Rotasi ke " + b + " :\n");
                Array.Copy(temp, arr, temp.Length);
                foreach (int j in temp)
                {
                    Console.Write(j + " ");
                }
                //arr = temp;
                Console.Write("\n");
            }
        }

    }
}