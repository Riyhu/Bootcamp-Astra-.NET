namespace Day1Kuis
{
    class No3
    {
        public static void ExtractDigit()
        {

            Console.Write("Masukkan Angka : ");
            long input = long.Parse(Console.ReadLine());
            String chr = input.ToString();
            int digit = 0;            
            while (input > 0)
            {
                digit++;
                input = input / 10;
            }
            Console.WriteLine(digit);
        }
    }
}