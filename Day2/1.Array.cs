namespace Day2
{
    class Arrays
    {
        public static void InitArray()
        {
            //inisialisasi array
            int[] arr;
            int[] arr2 = new int [10]; //belum ada valuenya tapi bsa menamping sampai 10 index
            int[] arr3 = new int[] {1,2,3};
            int[] arr4 = {2,3,5,7,11,13}; //by value / langsung ada valuenya

            string[] listName = { "astri", "bella", "chintya" };

            DisplayArray(listName);
            DisplayArrayNumber(arr4);
            SumElement(arr2);
            //for (int i = 0; i < listName.Length; i++)
            //{
            //    Console.WriteLine(listName[i]);
            //}
        }
        static void DisplayArray(string[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine (list[i]);
            }
        }
        public static void DisplayArrayNumber(int[] angka)
        {
            for (int i = 0; i < angka.Length; i++)
            {
                Console.Write(angka[i]+" ");
            }
        }
        //2. Prosessing Array
        public static void SumElement(int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum= sum + list[i];
               
            }
            Console.WriteLine("Total Element : "+sum);
        }

        public static int[] RandomArray()
        {
            Random random = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,20);
            }
            return arr;
        }

        //3 FIND max
        public static int FindMaxNumber(int[] list)
        {
            int max = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public static int FindIndexMaxNumber(int[] list)
        {
            int max = list[0];
            int index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                    index = i;
                }
            }
            return index;
        }

        public static void CopyArray(int[] list)
        {
            int [] destArray = new int[list.Length];


            //for (int i = 0; i < list.Length; i++)
            //{
            //    destArray[i] = list[i];
            //}

            //copy array by reference
            int[] target = list;

            //copy array by Method
            Array.Copy(list, 0, destArray, 0, destArray.Length); //cara kedua

            //Sorting
            Array.Sort(destArray);
            Array.Reverse(destArray);
            DisplayArrayNumber(destArray);

        }
    }
}