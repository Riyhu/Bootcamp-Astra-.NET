namespace Day2Kuis
{
    class No6
    {
        public static void ConvertMinusArray()
        {
            int[] arry = { 1, 5, 3, 7, 8, 5, 1 };
            Console.WriteLine("Before marker : \n");
            foreach (int h in arry)
            {
                Console.Write(h + " ");
            }
            for (int i = 0; i < arry.Length; i++)
            {
                for (int j = i + 1; j < arry.Length; j++)
                {
                    if (arry[i] == arry[j])
                    {
                        arry[i] = -1; //jika sama maka ubah array di indeks ke i menjadi -1
                    }
                }
            }
            Array.Sort(arry); //di urukan asc
            int cek = 0;
            Console.WriteLine("\n\n After marker : \n");
            foreach (int i in arry)
            {
                if (i > 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    cek++;
                }
            }
            for (int i = 0; i < cek; i++)
            {
                Console.Write(-1 + " ");
            }
            //int[] arr = new int[] { 1, 5, 3, 7, 8, 5, 1 };
            //Console.WriteLine("Before marker : \n");
            //int[] afArr = new int[arr.Length];
            //foreach (int h in arr)
            //{
            //	Console.Write(h + " ");
            //}
            //int smallest = 0;

            //for (int i = 0; i <= arr.Length - 1; i++)
            //{
            //	for (int j = i + 1; j <= arr.Length - 1; j++)
            //	{
            //		if (arr[i] == -1)
            //		{
            //			if (arr[j] != -1)
            //			{
            //				int temp = arr[i];
            //				arr[i] = arr[j];
            //				arr[j] = temp;
            //				//
            //			}
            //			else
            //			{
            //				continue;
            //			}
            //		}


            //		//Console.WriteLine("\n posisi "+ i +" = "+arr[i]+"vs  posisi "+ j +"  = "+arr[j]);
            //		if (arr[i] == arr[j])
            //		{
            //			arr[j] = -1;
            //		}

            //		if (arr[j] != -1 && arr[i] > arr[j])
            //		{
            //			smallest = arr[j];
            //			arr[j] = arr[i];
            //			arr[i] = smallest;
            //		}
            //	}
            //}
            //Console.WriteLine("\n\n After marker : \n");
            //foreach (int k in arr)
            //{
            //	Console.Write(k + " ");
            //}
        }
    }
}