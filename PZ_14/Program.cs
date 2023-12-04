namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрос имени файла у пользователя
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();
            try
            {
                // Проверка существования файла
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("Файл не найден. Проверьте правильность пути к файлу.");
                }
                // Считываем все строки из файла
                string[] lines = File.ReadAllLines(filePath);
                // Создаем поток для добавления информации в конец файла
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine("Информация о количестве символов и слов в каждой строке:");
                    for (int i = 0; i < lines.Length; i++)
                    {
                        int charCount = lines[i].Length;
                        int wordCount = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        // Запись информации о каждой строке в файл и вывод в консоль
                        string info = $"Строка {i + 1}: Количество символов - {charCount}, Количество слов - {wordCount}";
                        Console.WriteLine(info);
                        sw.WriteLine(info);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }
        }
    }
}