namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение e:");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение g:");
            double g = Convert.ToDouble(Console.ReadLine());

            double x, y, функция;

            if (e > 13)
            {
                x = Math.E - (g / (0.5 * (Math.E - g)));
            }
            else
            {
                x = Math.Log(Math.Pow(Math.E, 3) - 11 * g);
            }

            if (x > 1)
            {
                y = Math.Pow(Math.Sin(x), 2) / Math.Sqrt(x);
            }
            else
            {
                y = Math.Cos(e * g) * Math.Pow(x, 2);
            }

            функция = Math.Pow(x, 2) + 3 * y + 4 * g;

            Console.WriteLine("Значение x: {0}", x);
            Console.WriteLine("Значение y: {0}", y);
            Console.WriteLine("Значение функции: {0}", функция);
        }
    }
}