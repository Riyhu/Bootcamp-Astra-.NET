namespace Day2Kuis
{
    class No1
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

        public static void RandomDisplay()
        {
            int[] arry = {15,2,30,12,10,5};
            Random random = new Random();
            DisplayArrayNumber(arry);
            //Random random = new Random();
            int[] arr = new int[arry.Length];


            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = random.Next(arry[i]);
                int temp = random.Next(arry.Length);
                arr[temp] = arry[i];
            }
            Console.WriteLine("Angka setelah random: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            
            //            ShowRandomDisplay(arry);
            
        }
    }
}