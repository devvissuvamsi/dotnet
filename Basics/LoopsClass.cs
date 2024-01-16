namespace Basics
{
    public class LoopsClass
    {
        static string name = "John Smith";
        public static void ForLoop()
        {

            for(var i=0;i<=name.Length-1;i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        public static void ForEachLoop()
        {
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            var numbers = new int[5] { 1, 2, 3,4,5 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void WhileLoop()
        {
            while(true)
            {
                Console.WriteLine( "Type input: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;

                }
                break;
            }
        }
    }
}
