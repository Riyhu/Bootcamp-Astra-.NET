namespace Day1Kuis
{
    class No4
    {
        public static void ExtractDigit()
        {
            
            Console.Write("Masukkan Angka : ");
            int input = int.Parse(Console.ReadLine());
            String string1 = input.ToString();
            int bacaDariBelakang = string1.Length; //1756
            int x = string1.Length-1; //
            for (int i = 0; i < bacaDariBelakang; i++)
            {
                Console.WriteLine(string1[x]); //6 //5 // 7 // 1
                x--;

            }
            //Console.WriteLine(number);
        }
    }
}