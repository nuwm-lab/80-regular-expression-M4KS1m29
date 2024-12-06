using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть текст для перевірки:");
        string inputText = Console.ReadLine();

        // Регулярний вираз для перевірки, чи всі слова починаються з великої літери
        string pattern = "\\b[A-ZА-ЯЁ][a-zа-яё]*\\b";

        // Знайти всі слова в тексті
        MatchCollection matches = Regex.Matches(inputText, pattern);

        // Розбиваємо текст на слова
        string[] words = inputText.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Перевірка
        bool allWordsStartWithCapital = matches.Count == words.Length;

        if (allWordsStartWithCapital)
        {
            Console.WriteLine("Всі слова починаються з великої літери.");
        }
        else
        {
            Console.WriteLine("Не всі слова починаються з великої літери.");
        }
    }
}
