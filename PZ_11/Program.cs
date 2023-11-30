namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 48;
            int num2 = 36;
            int num3 = 60;

            int gcdOfThreeNumbers = FindGCDOfThreeNumbers(num1, num2, num3);
            Console.WriteLine($"НОД чисел {num1}, {num2} и {num3} равен {gcdOfThreeNumbers}");
        }

        // Функция для вычисления НОД двух чисел
        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Процедура для вычисления НОД трех чисел
        static int FindGCDOfThreeNumbers(int a, int b, int c)
        {
            return FindGCD(FindGCD(a, b), c);
        }
    }
}
