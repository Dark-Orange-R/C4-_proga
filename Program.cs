using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulc4_
{
    class ArrayManipulator
    {
        public int[] GenerateRandomArray(int length, int min, int max)
        {
            int[] ints= new int[length];
            Random random= new Random();
            for (int i = 0; i < length; i++)
            {
                ints[i] = random.Next(min, max);
            }
            return ints;
        }
        public int FindMax(int[] array)
        {
            return array.Max(x => x);
        }
        public void SortArray(int[] array)
        {
            List<int> list = array.ToList();
            list.Sort();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list[i];
            }

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayManipulator a= new ArrayManipulator();
            int[] ints = a.GenerateRandomArray(6,0,9);
            foreach (int x in ints)
            {
                Console.Write(x +" ");
            }
            Console.WriteLine();
            Console.WriteLine(a.FindMax(ints));
            a.SortArray(ints);
            foreach (int x in ints)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}
