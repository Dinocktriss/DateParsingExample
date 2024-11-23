using System;
using System.Globalization;

namespace DateParsingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод даты для Parse
            while (true)
            {
                Console.WriteLine("Введите год, месяц и день для Parse (в формате ГГГГ ММ ДД):");
                string yearInput = Console.ReadLine();
                string monthInput = Console.ReadLine();
                string dayInput = Console.ReadLine();
                string dateString1 = $"{yearInput}-{monthInput}-{dayInput}";

                try
                {
                    DateTime date1 = DateTime.Parse(dateString1);
                    Console.WriteLine($"Parse: {date1}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат для Parse. Попробуйте снова.");
                }
            }

            // Ввод даты для ParseExact
            while (true)
            {
                Console.WriteLine("Введите день, месяц и год для ParseExact (в формате ДД ММ ГГГГ):");
                string dayInput = Console.ReadLine();
                string monthInput = Console.ReadLine();
                string yearInput = Console.ReadLine();
                string dateString2 = $"{dayInput}/{monthInput}/{yearInput}";

                try
                {
                    DateTime date2 = DateTime.ParseExact(dateString2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine($"ParseExact: {date2}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат для ParseExact. Попробуйте снова.");
                }
            }

            // Предопределенные строки для TryParse и TryParseExact
            string dateString3 = "2024-11-23"; // Используем формат ГГГГ-ММ-ДД
            string dateString4 = "2024-11-23T17:42:00";

            // TryParse
            if (DateTime.TryParse(dateString3, out DateTime date3))
            {
                Console.WriteLine($"TryParse (\"{dateString3}\"): {date3}");
            }
            else
            {
                Console.WriteLine("Неверный формат для TryParse.");
            }

            // TryParseExact
            if (DateTime.TryParseExact(dateString4, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date4))
            {
                Console.WriteLine($"TryParseExact (\"{dateString4}\"): {date4}");
            }
            else
            {
                Console.WriteLine("Неверный формат для TryParseExact.");
            }
        }
    }
}
