namespace pz_12novoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку символов:"); // Вывод на экран просьбы ввести строку символов
            string input = Console.ReadLine();             // Чтение введенной пользователем строки
            char[] charArray = input.ToCharArray();        // Преобразование введенной строки в массив символов
            char mostFrequentChar = FindMostFrequentChar(charArray);                       // Вызов метода для нахождения наиболее часто встречающегося символа
            Console.WriteLine($"Наиболее часто встречающийся символ: {mostFrequentChar}"); // Вывод информации о наиболее часто встречающемся знаке
        }
        static char FindMostFrequentChar(char[] charArray)                // Метод для нахождения наиболее часто встречающегося символа в массиве
        {
            var groupedChars = charArray.GroupBy(c => c)
            .Select(g => new { Char = g.Key, Count = g.Count() });          // Группировка символов и подсчет их встречаемости
            var mostFrequentChar = groupedChars.OrderByDescending(x => x.Count).First().Char;  // Поиск символа с максимальной встречаемостью
            return mostFrequentChar;                                        // Возвращение найденного наиболее часто встречающегося символа
        }
    }
}
