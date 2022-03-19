﻿namespace Day2Kuis
{
    class No7
    {
        //public static void Distinct (){
        //    int [] arry = new int[] {1,2,3,2,7,7,1,6,3,4,5,2,3,6,8,9 };
        //    int[] temp = arry.Distinct().ToArray();
        //    DisplayArrayNumber(arry);

        //    Console.WriteLine("\nAngka Sesudah di Distinct : ");
        //    Array.Sort(temp);
        //    for(int i = 0; i < temp.Length; i++)
        //    {
        //        Console.Write(temp[i]+" "); 
        //    }
        //}
        public static void Distinct()
        {
            int[] arry = new int[] { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };
            Console.WriteLine("Before Remove");
            DisplayArrayNumber(arry);
            Console.WriteLine("After Remove Duplicate");
            Array.Sort(arry);
            for (int i = 0; i < arry.Length; i++)
            {
                int x = arry[i];
                if (i < arry.Length - 1 && x == arry[i + 1])
                {
                    continue;
                }
                Console.Write($"{arry[i]} ");
            }
            Console.WriteLine();
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