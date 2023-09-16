namespace pz_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 11:");
            int k = Convert.ToInt32(Console.ReadLine());

            string message;

            switch (k)
            {
                case 1:
                    message = "Привет, первоклассник";
                    break;
                case 2:
                    message = "Привет, второклассник";
                    break;
                case 3:
                    message = "Привет, третьеклассник";
                    break;
                case 4:
                    message = "Привет, четвероклассник";
                    break;
                case 5:
                    message = "Привет, пятиклассник";
                    break;
                case 6:
                    message = "Привет, шестиклассник";
                    break;
                case 7:
                    message = "Привет, седьмиклассник";
                    break;
                case 8:
                    message = "Привет, восьмиклассник";
                    break;
                case 9:
                    message = "Привет, девятиклассник";
                    break;
                case 10:
                    message = "Привет, десятиклассник";
                    break;
                case 11:
                    message = "Привет, одиннадцатиклассник";
                    break;
                default:
                    message = "Некорректное число";
                    break;
            }

            Console.WriteLine(message);
        }
    }
}