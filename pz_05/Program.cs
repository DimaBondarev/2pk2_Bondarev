namespace pz_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6; // заданное число

            int fibonacci = Fibonacci(n);

            Console.WriteLine(fibonacci);
            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            int a = 0;
            int b = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
    }
}