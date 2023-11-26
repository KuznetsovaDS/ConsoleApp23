using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Arrays
{
    class Arrs
    {
        private static int to;

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива \t");
            int elemcount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elemcount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < myArray.Length; i++) Console.WriteLine(myArray[i]);
            int sum = Sum(myArray);
            Console.Write($"Сумма элементов {sum}\n");
            int ave = average(myArray);
            Console.Write($"Среднее значение {ave}\n");
            int sump = summaPos(myArray);
            Console.Write($"Сумма положительных элементов {sump}\n");
            int sumn = summaNo(myArray);
            Console.Write($"Сумма отрицательных элементов {sumn}\n");
            int sumR = summaRoz(myArray);
            Console.Write($"Сумма нечетных {sumR}\n");
            int sumY = summaRoy(myArray);
            Console.Write($"Сумма четных {sumY}\n");
            int ind = summaMax(myArray);
            Console.Write($"Индекс максимального чила {ind}\n");
            int bet = between(myArray);
            Console.Write($"Произведение чисел между max и min {bet}\n");
        }
        public static int Sum(int[] arg)
        {
            int res = 0;
            foreach (var i in arg) res += i;
            return res;
        }
        public static int average(int[] arg)
        {
            int ave = 0;
            for (int i = 0; i < arg.Length; i++) ave += arg[i];
            return ave / arg.Length;
        }
        public static int summaPos(int[] arg)
        {
            var summPos = Array.FindAll(arg, x => x > 0).Sum();
            return summPos;
        }
        public static int summaNo(int[] arg)
        {
            int summNo = Array.FindAll(arg, x => x < 0).Sum();
            return summNo;
        }
        public static int summaRoz(int[] arg)
        {
            int res = arg.Where((n, i) => (i++ % 2) == 0).Sum();
            return res;
        }
        public static int summaRoy(int[] arg)
        {
            int res = arg.Where((n, i) => (i++ % 2) != 0).Sum();
            return res;
        }
        public static int summaMax(int[] arg)
        {
            int max = arg.Max();
            int index = Array.FindLastIndex(arg, delegate (int i) { return i == max; });
            return index;
        }
        public static int between(int[] arg)
        {

            int prod = 1;
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] != arg.Max() && arg[i] != arg.Min()) prod = prod * arg[i];
            }
            return prod;

        }
    }
}