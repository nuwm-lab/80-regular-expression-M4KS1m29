using System;
using System.Text.RegularExpressions;

namespace TextValidationWithRegex
{
    class Program
    {
        /// <summary>
        /// Перевіряє, чи всі слова у тексті починаються з великої літери за допомогою регулярного виразу.
        /// </summary>
        /// <param name="text">Вхідний текст</param>
        /// <returns>Повертає true, якщо всі слова починаються з великої літери; інакше false</returns>
        static bool AreAllWordsCapitalized(string text)
        {
            // Регулярний вираз для пошуку слів
            string pattern = @"\b[A-ZА-ЯЁ][a-zа-яё]*\b";

            // Використовуємо регулярний вираз для пошуку всіх слів
            MatchCollection matches = Regex.Matches(text, pattern);

            // Розбиваємо текст на слова для перевірки кількості
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Перевіряємо, чи кількість знайдених збігів дорівнює кількості слів
            return matches.Count == words.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть текст:");
            string input = Console.ReadLine();

            bool allWordsCapitalized = AreAllWordsCapitalized(input);

            if (allWordsCapitalized)
            {
                Console.WriteLine("Усі слова починаються з великої літери.");
            }
            else
            {
                Console.WriteLine("Не всі слова починаються з великої літери.");
            }
        }
    }
}