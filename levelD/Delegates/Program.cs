namespace Delegates
{
    delegate string Translator(string input); //Hiring the Translator (Reference type)
    delegate bool del(int a , int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Translator translator = new Translator(englishToFrench); // pointing to the method

            //string input = translator.Invoke("Hi");
            //Console.WriteLine(input);

            List<int> list = new List<int>() { 10,4,9,5,16,48,59,14};

            var output = filterValues(list , 10 ,isGreater);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

        }
        #region Delegates
        //public static string englishToFrench(string input)
        //{
        //    return "Bonjour";
        //}
        //public static string englishToSpanish(string input)
        //{
        //    return "Hola";
        //}
        //public static string englishToGerman(string input)
        //{
        //    return "Hallo";
        //}
        //public static string englishToItalian(string input)
        //{
        //    return "Ciao";
        //}
        #endregion

        public static List<int> filterValues(List<int> numbers,int m, del Operation)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (Operation(number,m))
                {
                    result.Add(number);
                }
            }
            return result;
        }
        public static bool isGreater(int a, int b)
        {
            return a > b;
        }
        public static bool isLess(int a, int b)
        {
            return a < b;
        }
    }
}
