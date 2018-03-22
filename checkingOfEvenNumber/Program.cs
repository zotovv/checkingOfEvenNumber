using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkingOfEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки на чётность: ");
            byte userNumber = Convert.ToByte(Console.ReadLine());
            byte n = (byte)(userNumber << 7);

            if (n == 0)
            {
                Console.WriteLine("Число является чётным.");
            }
            else
            {
                Console.WriteLine("Число  нечётное.");
            }

            Console.ReadKey();

        
        }
    }
}
