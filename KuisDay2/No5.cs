namespace Day2Kuis
{
    class No5
    {
        public static void Sama()
        {
            int [] arry = new int[] {5,2,30,12,10,5,2,10,5};
            //int[] temp = new int[arry.Length];
           
            for (int i = 0; i < arry.Length; i++)
            {
                int flag = 1;
                for (int j = i+1; j < arry.Length; j++)
                {
                    if (arry[i]==arry[j])
                    {
                        flag++;
                    }
                }
                int []arryBaru = arry.Distinct().ToArray();
                Console.WriteLine($"\nbanyak nya angka {arryBaru[i]} sebanyak {flag}");
            }
           
        }
    }
}