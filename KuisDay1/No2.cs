namespace Day1Kuis
{
    class No2
    {
        public static void Perbandingan()
        {
            int tampung = 0;
        cobalagi:
            Console.Write("Enter Integer [Type 0 for exit] :  ");
            int input = int.Parse(Console.ReadLine());
            while (input!=0)
            {
                
                if (input>tampung)
                {
                    tampung = input;
                    
                }
                goto cobalagi;
            }
            
                Console.WriteLine("Angka terbesar : " + tampung);
            
        }
    }
}