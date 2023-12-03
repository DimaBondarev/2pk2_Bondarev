namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя текстового файла с расширением (например, input.txt): ");
            string fileName = Console.ReadLine();

            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                int lineCount = lines.Length;
                Console.WriteLine($"Количество строк в файле: {lineCount}");
                for (int i = 0; i < lines.Length; i++)
                {
                    int characterCount = lines[i].Length;
                    int wordCount = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine($"Строка {i + 1}: Количество символов - {characterCount}, Количество слов - {wordCount}");
                    }
                }

                Console.WriteLine("Информация о количестве символов и слов в каждой строке была успешно добавлена в файл.");
            }
            else
            {
                Console.WriteLine("Файл не найден. Пожалуйста, убедитесь, что файл существует в директории вашей программы.");
            }
           
        }
    }
}
