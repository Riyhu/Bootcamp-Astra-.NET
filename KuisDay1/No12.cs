namespace Day1Kuis
{
    class No12
    {
        public static void CariKarakterYangSama()
        {
            Console.Write("Masukkan karakter : ");
            String input1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Masukkan karakter : ");
            String input2 = Console.ReadLine();
            int jumlah = 0;
            cobalagi:
            int cekk = input1.IndexOf(input2);
            while (cekk != -1)
            {
                input1 = input1.Remove(cekk, input2.Length);
                jumlah++;
                goto cobalagi;
            }
            Console.WriteLine(jumlah);

        }
    }
}