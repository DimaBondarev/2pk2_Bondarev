namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку A:");
            string A = Console.ReadLine();         // Ввод строки A
            Console.WriteLine("Введите строку B:");
            string B = Console.ReadLine();         // Ввод строки B
            int index = A.IndexOf(B);  
            if (index != -1)                       // Если подстрока B найдена
            {
                string reversedSubstring = ReverseString(B); // Переворачивание символов подстроки B
                A = A.Remove(index, B.Length).Insert(index, reversedSubstring); // Замена подстроки B на перевернутую подстроку в строке A
            }
            Console.WriteLine("Обновленная строка A: " + A); // Вывод обновленной строки A
        }
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray(); // Преобразование строки в массив символов
            Array.Reverse(charArray);             // Переворачивание массива символов
            return new string(charArray);         // Преобразование массива символов обратно в строку
        }
    }
}
