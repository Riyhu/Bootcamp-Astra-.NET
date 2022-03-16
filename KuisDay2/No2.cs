namespace Day2Kuis
{
    class No2
    {
        public static void ShiftingArry()
        {
            int [] arr = new int[] {15,2,30,12,10,5};
            int[] temp = new int[arr.Length];
            int i;

            for ( i = 0; i <= arr.Length-1; i++)
            {
                if (i==arr.Length-1)
                {
                    temp[i] = arr[0];
                }
                else
                {
                    temp[i]=arr[i+1];
                }
                
            }
            foreach (int j in temp)
            {
                Console.Write(j+" ");
            }


        }
     
    }
}