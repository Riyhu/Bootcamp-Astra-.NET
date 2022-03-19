namespace Day4
{
    class Collection
    {
        public static void InisialisasiList()
        {
            var number = new List<int>();
            number.Add(1);
            var words = new List<string>() {"code",".net","Botcamp" };
        }
        public static void InsertElementList()
        {
            var number = new List<int> { 1, 2, 3 };
            number.Add(5);
            number.AddRange(new[] { 5, 6, 7 });
            number.Insert(5, 100); //sisipkan 1 doank
            number.InsertRange(5, new[] { 10, 20, 30 });
            Console.WriteLine();
        }

        public static void RemoveList()
        {
            var number = new List<int> { 13, 17, 19, 2, 3, 5, 7, 1, 1, 11,100,120,111,190 };
            number.RemoveAt(19); //value 19
            number.RemoveRange(7, 2); //dari indeks ke 7 sbnyk 2x
            number.RemoveAll(e => e > 100); //e sbgai variable boolean
            number.Clear(); //dlete all
            Console.WriteLine();
        }
        public static void FindList()
        {
            var number = new List<int> { 13, 17, 19, 2, 3, 5, 7, 1, 1, 11, 100, 120, 111, 190 };
            var a = number.Find(e => e < 100);
            var b = number.FindLast(e => e < 100);
            var c = number.FindAll(e => e > 100);
            number.Sort();
            number.Reverse();
            Console.WriteLine();
        }
        public static void InitStack()
        {
            var number = new Stack<int>(new int[] {1,2,3});
            number.Push(5); //insert ke index pertama / 0
            number.Pop(); //hapus index pertama
            Console.WriteLine();
        }
        public static void InitDictionary()
        {
            var dc = new Dictionary<int,string>(); //<key, value>
            var languages = new Dictionary<int, string>()
            {
                {1,"C#" },
                {2,"Java" },
                {3,"C++" },
            };
            languages.Add(4, "Java Script");
            languages.TryAdd(4, "Phyton");
            languages[5] = "SQL";
            languages[6] = "React";
            Console.WriteLine();
        }

        public static void InitHashSet()
        {
            var number = new HashSet<int>() { 1, 2, 3, 1, 3, 4, 4, 5, 5, 6 };
            number.Add(10);
            Console.WriteLine();
        }
    }
}