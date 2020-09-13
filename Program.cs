using System;

namespace _222222
{

    public class ArrayOp
    {

        public static int select_max(int[] a, int b)
        {
            b = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (b < a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }
        public static int select_min(int[] a, int b)
        {
            b = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (b > a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }
        public static int sum(int[] a, int b)
        {
            b = 0;

            for (int i = 0; i < a.Length; i++)
            {
                b += a[i];
            }
            return b;

        }
        public static int ave(int[] a, int b)
        {
            b = 0;
            int c = 0;

            for (int i = 0; i < a.Length; i++)
            {
                c += a[i];
            }
            b = c / a.Length;
            return b;

        }

        public static void Main()
        {


            int n;
            int nMax = 0, nMin = 0, nAve = 0, nSum = 0;
            Console.WriteLine("Please input the length of tne array");
            string c = Console.ReadLine();
            n = int.Parse(c);
            int[] array = new int[n];

            Console.WriteLine("Please input the array");
            for (int i = 0; i < array.Length; i++)
            {
                string b = Console.ReadLine();
                array[i] = int.Parse(b);
            }
            nMax=select_max(array, nMax);
            nMin=select_min(array, nMin);
            nSum=sum(array, nSum);
            nAve=ave(array, nAve);

            Console.WriteLine("the max number of the array is " + nMax);
            Console.WriteLine("the min number of the array is " + nMin);
            Console.WriteLine("the sum of the array is " + nSum);
            Console.WriteLine("the ave of the array is " + nAve);
        }
    }
}
