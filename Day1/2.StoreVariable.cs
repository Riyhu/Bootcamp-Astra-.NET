namespace Day1
{
    class StoreVariable
    {
        public static void StoreCharText()
        {
            // store character
            char letter = 'A';
            char digit = '1';
            Console.WriteLine($"{letter} {digit}");

        }
        public static string StoreString()
        {
            string firstName = "Rio";
            string lastName = "Yhuhuda";
            //Console.WriteLine(firstName+" "+lastName);
            return firstName +" "+ lastName;
        }

        public static void StoredNumber()
        {
            int number = 0;
            Console.WriteLine(number);
            float f = 2.3F;
            Console.WriteLine(f);
            double d = 12.5;
            Console.WriteLine(d);
        }
        public static void ShowDouble()
        {
            double nilai1 = 0.1;
            double nilai2 = 0.2;

            if (nilai1+nilai2==0.3)
            {
                Console.WriteLine($"{nilai1}+{nilai2} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{nilai1}+{nilai2} NOT equals 0.3");
            }
        }
        public static void ShowDecimal()
        {
            decimal nilai1 = 0.1M;
            decimal nilai2 = 0.2M;

            if (nilai1 + nilai2 == 0.3M)
            {
                Console.WriteLine($"{nilai1}+{nilai2} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{nilai1}+{nilai2} NOT equals 0.3");
            }
        }
        public static void ShowBoolean()
        {
            bool isStatus = false;
            bool isMerried = true;
        }
        public static void StoreObject()
        {
            object obj = null;
            object firstName = "Butkem";
            object height = 1.6;
            Console.WriteLine($"{firstName} is {height}cm");
        }
        public static void StoreVar()
        {
            var salary = 10_000_000;
            var weight = 12;
        }

        public static void StoreConstant()
        {
            const string myName = "JOJO";
//            myName = "CODEID"; // valuenya tdk bsa di ubah
            const double phi = 13.145;
        }
        public static void ShowBullType()
        {
            
            Nullable<int> a; //primitip kg punya null tipe

            // int ? A => agar manggil di database yg valuenya NULL tdk error
            int? b; //<~ contoh lain dr null
            int ? c=null; //contog lain
            int? f = 45; // ?F = bsa di ksh value null / di kasih nilai jg
            if (f.HasValue) //hasvalue = cek punya value / ngga
            {
                Console.WriteLine(f.Value);
            }
        }
        public static void ShowCasting()
        {
            decimal d = 10.5M;
            int e = (int)d; //casting

            string z= "123";
            int y = Convert.ToInt32(z); //parsing 
            int x = int.Parse(z); //parsing
        }
    }
}