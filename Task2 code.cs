namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem1 daxil et:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reqem2 daxil et:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1%2==0 && num2%2==0)
            {
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine("Daxil olunan ededler cut olmalidi");
            }

        }
    }
}
