namespace Day1Kuis
{
    class No7
    {
        public static void Palindrome()
        {
            Console.Write("Masukkan karakter : ");
            String input =Console.ReadLine().ToLower();
            int i;
            int kebalikan = input.Length-1;
            bool cek=true;
            for (i = 0; i < kebalikan; i++)
            {
                if (input[i] != input[kebalikan])
                {
                    cek = true;
                }
                else
                {
                    cek= false;
                    kebalikan--;
                }
                
            }
                
            
            if(cek == false)
            {
                Console.WriteLine("Polindrome");
            }
            else
            {
                Console.WriteLine("bukan");
            }
           // Console.WriteLine(input.Length-1);
        }
    }
}