namespace pz_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            // Заполнение массива случайными числами от 0 до 4
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 5);
            }
            // Проверка наличия одинаковых соседних элементов
            bool hasDuplicates = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    hasDuplicates = true;
                    break;
                }
            }
            // Вывод результатов
            Console.WriteLine("Массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            if (hasDuplicates)
            {
                Console.WriteLine("В массиве есть одинаковые соседние элементы."); //
            }
            else
            {
                Console.WriteLine("В массиве нет одинаковых соседних элементов.");
            }
            Console.ReadLine();
        }
    }
}