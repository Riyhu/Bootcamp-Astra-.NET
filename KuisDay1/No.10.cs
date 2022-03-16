namespace Day1Kuis
{
    class No10
    {
        public static void MiddleChar()
        {
            Console.Write("Masukkan karakter : ");
            String input = Console.ReadLine();
            List<String> list = new List<String>();
            list = input.Split(' ').ToList(); // LIST ~> "AKU" "MAEN" "Game" aku = index ke 1
            for (int i = 0; i < list.Count; i++) //di periksa index ke 1 =AKU
            {
                for (int j = 0; j < list[i].Length; j++) // dia meriksa di index ke 1 dari i = aku
                {
                    if (j == 0 || j == list[i].Length - 1) //kalo huruf di index ke 0 / indeks ke akhir 
                    {
                        Console.Write(list[i][j]); //cetak hurufnya
                    }
                    else
                    {
                        Console.Write("*"); //jika berada ditengah" / bkn di indeks ke 0 maupun trakhir maka replace dengan *
                    }
                }Console.Write(" ");
            }
        }
    }
}