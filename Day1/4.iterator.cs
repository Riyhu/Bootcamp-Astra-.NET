namespace Day1
{
    class iterator
    {
        public static void ShowForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void ShowBox()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= i+1; j++)
                {
                    Console.Write(i+j+" ");
                }
                Console.WriteLine();
            }
        }
        public static void ShowDiffDate()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(10);
            TimeSpan diff = endDate - startDate;
            int dayRemaining = diff.Days;
            Console.WriteLine($"Mulai : {startDate} dan akan berakhir pada {endDate}, durasi harinya adalah {dayRemaining}Hari");
            Console.WriteLine($"{startDate.DayOfWeek}");
        }
        public static void ShowTryCatch()
        {
            try
            {
                int a = 10;
                int b = a / 0;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ShowTryParse()
        {
            Console.WriteLine("input your age : ");
            string? input = Console.ReadLine();
            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"your age : {age}");
            }
            catch (FormatException ex) when (input.Contains("$"))
            {
                Console.WriteLine("do not use $");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}