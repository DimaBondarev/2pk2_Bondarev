namespace pz_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int firstDimensionLength = 5;
            int secondDimensionLength = random.Next(3, 21);

            //  Создание ступенчатого массива и заполнение его значениями
            int[][] jaggedArray = new int[firstDimensionLength][];
            for (int i = 0; i < firstDimensionLength; i++)
            {
                jaggedArray[i] = new int[secondDimensionLength];
                for (int j = 0; j < secondDimensionLength; j++)
                {
                    jaggedArray[i][j] = random.Next(1, 101); // Заполнение случайными значениями от 1 до 100
                }
            }

            //  Вывод сгенерированного массива в консоль
            Console.WriteLine("Сгенерированный массив:");
            foreach (int[] row in jaggedArray)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            //  Создание нового одномерного массива и запись в него последних элементов каждой строки
            int[] lastElementsArray = new int[firstDimensionLength];
            for (int i = 0; i < firstDimensionLength; i++)
            {
                lastElementsArray[i] = jaggedArray[i][secondDimensionLength - 1];
            }

            // Вывод нового массива
            Console.WriteLine("Массив последних элементов:");
            foreach (int element in lastElementsArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            //  Поиск максимального элемента в каждой строке и запись их в другой массив
            int[] maxElementsArray = new int[firstDimensionLength];
            for (int i = 0; i < firstDimensionLength; i++)
            {
                int maxElement = jaggedArray[i][0];
                for (int j = 1; j < secondDimensionLength; j++)
                {
                    if (jaggedArray[i][j] > maxElement)
                    {
                        maxElement = jaggedArray[i][j];
                    }
                }
                maxElementsArray[i] = maxElement;
            }

            // Вывод содержимого массива максимальных элементов
            Console.WriteLine("Массив максимальных элементов:");
            foreach (int element in maxElementsArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            //  Обмен первого элемента и максимального элемента в каждой строке
            for (int i = 0; i < firstDimensionLength; i++)
            {
                int maxElementIndex = Array.IndexOf(jaggedArray[i], maxElementsArray[i]);
                int temp = jaggedArray[i][0];
                jaggedArray[i][0] = jaggedArray[i][maxElementIndex];
                jaggedArray[i][maxElementIndex] = temp;
            }

            // Вывод обновленного массива
            Console.WriteLine("Обновленный массив:");
            foreach (int[] row in jaggedArray)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            //  Реверс каждой строки ступенчатого массива
            for (int i = 0; i < firstDimensionLength; i++)
            {
                Array.Reverse(jaggedArray[i]);
            }

            // Вывод обновленного массива после реверса
            Console.WriteLine("Массив после реверса:");
            foreach (int[] row in jaggedArray)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            //  Вычисление среднего значения в каждой строке
            double[] averageValuesArray = new double[firstDimensionLength];
            for (int i = 0; i < firstDimensionLength; i++)
            {
                double sum = 0;
                for (int j = 0; j < secondDimensionLength; j++)
                {
                    sum += jaggedArray[i][j];
                }
                averageValuesArray[i] = sum / secondDimensionLength;
            }
        }
    }
}