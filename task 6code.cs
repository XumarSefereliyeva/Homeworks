namespace Task_6_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("a daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());
            a = 5;
            b = 10;
            (a, b) = (b, a);

            Console.WriteLine(a);
        }
    }
}
