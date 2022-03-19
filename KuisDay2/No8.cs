namespace Day2Kuis
{
    class No8
    {
        
        public static void RandomChar()
        {
            var alpa = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            char[] list = new char[100];
            for (int i = 0; i < 100; i++)
            {
                list[i] = alpa[rand.Next(0,26)];
            }
            ReadChar(list);
            Console.WriteLine(" ======== Result ======== ");
            Array.Sort(list);
            int count = 1;
            for (int i = 0; i < list.Length; i++)
            {
                int x = list[i];
                if (i < list.Length - 1 && x == list[i + 1])
                {
                    count++;
                }
                else if (i == list.Length - 1 && x == list[i - 1])
                {
                    Console.Write($"{count} {list[i]} ");
                }
                else
                {
                    Console.Write($"{count} {list[i]} ");
                    count = 1;
                }
            }
        }


        public static void ReadChar(char[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]} ");

            }
            Console.WriteLine();
        }
    }
}