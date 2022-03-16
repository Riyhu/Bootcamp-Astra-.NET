namespace Day1Kuis
{
    class Kuis1
    {
        public static void RandomNumber()
        {
            Console.WriteLine("Guess Magic Number (0-20) : ");
            Random random = new Random();
            int angkaRandom = random.Next(0, 20);
        cobalagi:
            Console.Write("Enter your guess?  ");
            int input = int.Parse(Console.ReadLine());
            while (input != angkaRandom)
            {
                if (input < angkaRandom)
                {
                    Console.WriteLine("your guess is too low");
                }
                else if (input > angkaRandom)
                {
                    Console.WriteLine("your guess is too high");
                }
                goto cobalagi;
            }
            Console.WriteLine($"Tebakan kamu benar {angkaRandom}");
        }
    }
}
