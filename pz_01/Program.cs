namespace pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = -1;
            int c = 4;
            double d = Math.Pow(10, -3);
            double f = Math.Tan(-8);
            double s = a - c;
            double g = Math.Pow(a, 2) + Math.Pow(b, 2);
            double h = s * g;
            double j = Math.Pow(2, a) + Math.Pow(b, 2) - 2.2 * c;
            double k = Math.Pow(j, 1 / 3);
            double l = Math.Cos(2 * a) / Math.Sin(5);
            double Rez = d * f - (h / k) - l;

            { Console.WriteLine(Rez); }
        }
    }
}