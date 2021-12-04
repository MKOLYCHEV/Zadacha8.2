using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Array.txt";
            int[] array = new int[10];
            Random random = new Random();
            Console.WriteLine("Сформированный массив:");
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-100000, 100000);
                Console.WriteLine("{0,8:0,0}", array[i]);
            }
            Console.WriteLine();
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(array[i]);
                }
            }
            string[] array1 = File.ReadAllLines(path);
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += Convert.ToInt32(array1[i]);
            }
            Console.WriteLine("Сумма чисел сформированного массива равна {0:0,0}.", sum);
            Console.ReadKey();
        }
    }
}
