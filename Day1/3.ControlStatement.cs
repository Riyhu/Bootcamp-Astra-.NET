namespace Day1
{
    class ControlStatement
    {
        public static void ValidatePassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password is required");
            }
            else if (password.Length < 8)
            {
                Console.WriteLine("Your password too SHORT !. must at leat 8 character");
            }
            else
            {
                Console.WriteLine("your password is STRONG");
            }
        }
        public static void IfElseReadln()
        {
            Console.Write("Masukkan nomor : ");
            var input = Console.ReadLine();
            int y = Convert.ToInt32(input); //parsing 
            int x = int.Parse(input); //parsing
            int.TryParse(input, out int number); //parsing

            if (number % 2 == 0)
            {
                Console.WriteLine("Genap");
            }
            else
            {
                Console.WriteLine("Ganjil");
            }
        }

        public static void SwitchCase()
        {
            Console.Write("Masukkan nomor (1-10) :  ");
            var input = Console.ReadLine();
            int.TryParse(input, out int number); //parsing
            switch (number)
            {
                case 1:
                    Console.WriteLine("angka kecil");
                    break;
                case 2:
                    Console.WriteLine("Angka Genap, dan Bilangan prima");
                    break;
                case 3:
                    Console.WriteLine("Angka Ganjil, dan Bilangan prima");
                    break;
                case 5:
                    Console.WriteLine("Angka Ganjil, dan Bilangan prima");
                    break;
                case 7:
                    Console.WriteLine("Angka Ganjil, dan Bilangan prima");
                    break;
                case 4:
                    Console.WriteLine("Angka Genap, dan Bukan prima");
                    break;
                case 6:
                    Console.WriteLine("Angka Genap, dan Bukan prima");
                    break;
                case 8:
                    Console.WriteLine("Angka Genap, dan Bukan prima");
                    break;
                case 9:
                    Console.WriteLine("Angka Ganjil, dan Bukan prima");
                    break;
                case 10:
                    Console.WriteLine("Angka Tertinggi, dan Bukan Prima");
                    break;  
                default:
                    Console.WriteLine(" 404 NOT FOUND !! ");
                    break;
            }
        }
    }
}