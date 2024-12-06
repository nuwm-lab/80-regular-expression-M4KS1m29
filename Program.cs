
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Інформатика - це наука про інформацію. Інформатика включає різні розділи. Програмування - це частина інформатики.";

        // Регулярний вираз для пошуку речень, що починаються зі слова "Інформатика"
        string pattern = @"\bІнформатика\b";
        // Знаходимо всі збіги
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        // Виводимо кількість знайдених речень
        Console.WriteLine("Кількість речень, які починаються зі слова 'Інформатика': " + matches.Count);

    }
}

//Додаткове завдання!!


//using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        string text = "вк 0964 вс." +
//            "аа 0924 нк." +
//            "вн 3542 то." +
//            "нн 7891 цу." +
//            "ск 5435 фк." +
//            "но 9003 ва." +
//            "вк 4098 он." +
//            "ак 4060 пк." +
//            "ао 4060 пк." +
//            "вм 8932 фу.";

//        string pattern = @"\bвк \d{4} [а-я]{2}\b";

//        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

//        Console.WriteLine("Номерні знаки, що починаються на 'вк':");
//        foreach (Match match in matches)
//        {
//            Console.WriteLine(match.Value);
//        }
//    }
//}
