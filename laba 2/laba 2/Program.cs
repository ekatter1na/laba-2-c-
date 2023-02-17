using System.Globalization;

namespace laba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите разерность массива");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < length; i++)
            {
                int s = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > s)
                {
                    array[j + 1] = array[j];
                    array[j] = s;
                    j--;
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}