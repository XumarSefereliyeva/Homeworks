namespace Task_4_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            int onluq = num / 10;
            int teklik = num % 10;
            if (onluq > teklik)
            {
                Console.WriteLine("Onluq boyukdur");
            }
            else
            {
                Console.WriteLine("Teklik boyukdur");
            }
        }
    }
}
