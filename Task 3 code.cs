using System.ComponentModel.Design;

namespace Task_3_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maasinizi daxil edin");
            int maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kreditinizi daxil edin");
            int kredit = Convert.ToInt32(Console.ReadLine());
            int illikmaas = maas * 12;
            if (kredit < illikmaas * 0.6)
            {
                Console.WriteLine("kredit goture bilersiniz");

            }
            else
            {
                Console.WriteLine("Kredit goture bilmezsiniz");
            }
        }
    }
}

