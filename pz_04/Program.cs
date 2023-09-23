namespace pz_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            int start = 20;
            int end = 100;
            int step = 4;

            for (int i = start; i <= end; i += step)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            // задание 2
            char startChar = 'f'; // указанный символ
            int g = 7; // количество символов для вывода

            for (int i = 0; i < g; i++)
            {
                char currentChar = (char)(startChar + i);
                Console.Write(currentChar);
            }

            Console.ReadLine();
            // задание 3
            int n = 4; // количество знаков '#' в строке
            int m = 6; // количество строк

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            // задание 4
            int a = -50; // начало диапазона
            int b = 50; // конец диапазона
            int number = 11; // заданное число
            int count = 0; // счетчик кратных чисел

            for (int i = start; i <= end; i++)
            {
                if (i % number == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }

            Console.WriteLine("\nКоличество кратных чисел: " + count);
            Console.ReadLine();
            // задание 5
            int k = 2; // начальное значение переменной i
            int s = 40; // начальное значение переменной j
            int difference = 19; // заданная разница

            while (Math.Abs(k - s) != difference)
            {
                Console.WriteLine("k = " + k + ", s = " + s);
                k++;
                s--;
            }

            Console.ReadLine();
        }
    }
}