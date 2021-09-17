using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("2.1");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name);


            Console.WriteLine("2.2");
            int a22 = int.Parse(Console.ReadLine());
            int b22 = int.Parse(Console.ReadLine());
            if (b22 == 0)
            {
                Console.WriteLine("Делить на ноль нельзя");

            }
            else
            {
                Console.WriteLine(a22 / b22);

            }



            Console.WriteLine("дз2.1");

            string k = Console.ReadLine();
            string[] alphabet = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };

            for (int i = 0; i < alphabet.Length; i++)

            {
                if (alphabet[i] == k)
                {

                    Console.WriteLine(alphabet[i + 1]);
                }

            }


            Console.WriteLine("дз2.2");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("1-ый корень " + x1);
                Console.WriteLine("2-ой корень " + x2);
            }

            if (D < 0)
            {
                Console.WriteLine("Корней среди действительных чисел нет");

            }
            else
            {
                double x = -b / 2 * a;
                Console.WriteLine("Единственный корень " + x);

            }

            if (a == 0)
            {
                int x3 = -c / b;
                Console.WriteLine("Корень линейного уравнения");
            }



        }
    }
}
