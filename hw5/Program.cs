using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите два числа");
                FirstTask(Console.ReadLine(), Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы не указали значения");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("На 0 делить нельзя");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число!");
                Console.ReadLine();
            }

            try
            {
                SecondTask();
            }
            catch (IndexOutOfRangeException excrption)
            {
                Console.WriteLine(excrption.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Обработки массива завершена");
                Console.ReadLine();
            }
        }

        public static void FirstTask(string divisible, string divider)
        {
            if (string.IsNullOrEmpty(divisible) || string.IsNullOrEmpty(divider))
            {
                throw new ArgumentNullException();
            }

            if (int.Parse(divider) == 0)
            {
                throw new ArgumentException();
            }

            int temp;

            if (!int.TryParse(divisible, out temp) || !int.TryParse(divider, out temp))
            {
                throw new FormatException();
            }

            Console.WriteLine(double.Parse(divisible) / double.Parse(divider));
            Console.ReadLine();
        }

        public static void SecondTask()
        {
            int[] array = new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length + 1; i++)
            {
                Console.ReadKey();
                Console.Write(array[i]);
            }
        }      
    }
}
