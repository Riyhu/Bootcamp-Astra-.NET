namespace Day1Kuis
{
    class No9
    {
        public static void JumlahKalimat()
        {
            Console.Write("Masukkan karakter : ");
            String input = Console.ReadLine();
            List<string> list = new List<string>();
            list = input.Split(' ').ToList();
            int kalimat = 0;
//            int leng = input.Length;
            foreach (string cek in list)
            {
                if (cek.Length!=0)
                {
                    kalimat += 1;
                }
            }
            Console.WriteLine("jumlah kalimat : " + kalimat);
        }
    }
}