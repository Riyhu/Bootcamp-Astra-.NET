namespace Day1Kuis
{
    class No8
    {
        public static void VowelConsonant()
        {
            Console.Write("Masukkan karakter : ");
            String input = Console.ReadLine();
            int vowel = 0;
            int consonan = 0;
            int leng = input.Length;
            for (int i = 0; i < leng; i++)
            {
                if (input[i] == 'a' || input[i] == 'i' || input[i] == 'u' || input[i] == 'e' || input[i] == 'o')
                {
                    vowel++;
                }
                else if(input[i]>='a' && input[i]<='z')
                {
                    consonan++;
                }

            }
            Console.WriteLine("jumlah vowel : " + vowel);
            Console.WriteLine("jumlah Consonant : "+consonan);
            
        }
    }
}