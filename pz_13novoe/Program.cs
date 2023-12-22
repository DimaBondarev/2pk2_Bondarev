namespace pz_13novoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5; // Порядковый номер члена прогрессии
            double a1 = 0;
            double d = -0.3;
            double b1 = 6;
            double q = 0.2;
            int A = 3;
            int B = 8;

            // 1. Рекурсивное вычисление n-го члена арифметической прогрессии
            double nthTermArithmeticProgression = GetNthTermArithmeticProgression(a1, d, n);
            Console.WriteLine($"n-й член арифметической прогрессии с a1={a1} и d={d}: {nthTermArithmeticProgression}");

            // 2. Рекурсивное вычисление n-го члена геометрической прогрессии
            double nthTermGeometricProgression = GetNthTermGeometricProgression(b1, q, n);
            Console.WriteLine($"n-й член геометрической прогрессии с b1={b1} и q={q}: {nthTermGeometricProgression}");

            // 3. Рекурсивный вывод чисел от A до B в порядке возрастания или убывания
            if (A < B)
            {
                PrintNumbersIncreasing(A, B);
            }
            else
            {
                PrintNumbersDecreasing(A, B);
            }
        }

        // 1. Рекурсивное вычисление n-го члена арифметической прогрессии
        static double GetNthTermArithmeticProgression(double a1, double d, int n)
        {
            if (n == 1)
            {
                return a1;
            }
            else
            {
                return GetNthTermArithmeticProgression(a1, d, n - 1) + d;
            }
        }

        // 2. Рекурсивное вычисление n-го члена геометрической прогрессии
        static double GetNthTermGeometricProgression(double b1, double q, int n)
        {
            if (n == 1)
            {
                return b1;
            }
            else
            {
                return GetNthTermGeometricProgression(b1, q, n - 1) * q;
            }
        }

        // 3. Рекурсивный вывод чисел от A до B в порядке возрастания
        static void PrintNumbersIncreasing(int A, int B)
        {
            if (A <= B)
            {
                Console.Write($"{A} ");
                PrintNumbersIncreasing(A + 1, B);
            }
        }

        // 3. Рекурсивный вывод чисел от A до B в порядке убывания
        static void PrintNumbersDecreasing(int A, int B)
        {
            if (A >= B)
            {
                Console.Write($"{A} ");
                PrintNumbersDecreasing(A - 1, B);
            }
        }
    }
}
