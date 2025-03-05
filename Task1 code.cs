using System.Threading.Channels;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1

            
            {
                Console.WriteLine("Enter your score: ");
                int score = Convert.ToInt32(Console.ReadLine());
                if (score > 90)
                {
                    Console.WriteLine("Your score is: A");
                }
                else if (score > 80)
                {
                    Console.WriteLine("Your score is: B");
                }
                else if (score > 70)
                {
                    Console.WriteLine("Your score is: C");
                }
                else if (score > 61)
                {
                    Console.WriteLine("Your score is: D");
                 
                }
            }
        }
    }

}
#endregion




