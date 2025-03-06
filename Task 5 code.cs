namespace Task_5_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eni daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzunlugu daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());

            int P = 2 * (a + b);
            int S = (a * b);
            Console.WriteLine("Sahe:" + S);
            Console.WriteLine("Perimetr:" + P);



        }
    }
}
    
