namespace Day1Kuis
{
    class No11
    {
        public static void Dateee()
        {
            DateTime startDate = DateTime.Now;
            Console.Write("Masukkan Tanggal : ");
            DateTime input = DateTime.Parse(Console.ReadLine());
            DateTime endDate = input;
            TimeSpan diff = endDate - startDate;
            int dayRemaining = diff.Days;
            Console.WriteLine($"pada hari :  {endDate.DayOfWeek}\n {dayRemaining} Hari LAGI !!");
            //Console.WriteLine($"{startDate.DayOfWeek}");
        }
    }
}