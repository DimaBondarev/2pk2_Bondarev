namespace pz_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5]; // размерность массива

            Random random = new Random();

            // Заполнение массива случайными числами от 0 до 199
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(200);
                }
            }

            // Вывод массива на экран
            Console.WriteLine("Двумерный массив случайных чисел:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int count = 0; // счетчик двухзначных чисел, у которых сумма цифр кратна 2

            // Поиск и подсчет двухзначных чисел, у которых сумма цифр кратна 2
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] >= 10 && array[i, j] <= 99) // проверка, что число двухзначное
                    {
                        int sum = array[i, j] % 10 + array[i, j] / 10; // вычисление суммы цифр числа
                        if (sum % 2 == 0) // проверка, что сумма цифр кратна 2
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine("Количество двухзначных чисел, у которых сумма цифр кратна 2: " + count);

            Console.ReadLine();
        }
    }
}