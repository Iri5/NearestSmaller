using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theNearestSmaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numb = new List<int>();
            Console.WriteLine("Сколько цифр в массиве?");
            int countN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массив цифр");
            for (int i = 0; i < countN; i++)
            {
               numb.Add(Convert.ToInt32(Console.ReadLine()));
            }
            List<int> done = NearestSmaller(numb);
            
            Console.WriteLine("done");
            done.ForEach(Console.WriteLine);
        }
        static List<int> NearestSmaller(List<int> numbers)
        {
            int count = numbers.Count;
            //найти число больше чем предыдущее переставить перед наименьшим
            int biggest = 0;
            int index = 0;
            int tocha = 0;
            int inc = 0;
            for (int i = count - 1; i > 0; i--)
            {
                if ((biggest == 0) && (numbers[i- 1] > numbers[i]))
                {
                    biggest = numbers[i - 1];
                    index = i-1;
                }

            }
            for (int i = index +1; i <= count - 1; i++)
            {
                if ((numbers[i] < biggest) && (numbers[i] > tocha))
                {
                    tocha = numbers[i];
                    inc = i;
                }
            }
            numbers[index] = tocha;
            numbers[inc] = biggest;
            int[] array = new int[count - index - 1];
            numbers.CopyTo(index + 1, array, 0, 4);
            Array.Sort(array);
            Array.Reverse(array);
            int j = index + 1;
            for (int i = 0; i < array.Length; i++)
            {
                numbers[j] = array[i];
                j++;
            }
            return numbers; 
        }
    }
}
