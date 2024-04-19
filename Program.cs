using System;

class Program
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum TimesOfDay
    {
        Утро,
        День,
        Вечер,
        Ночь
    }

    static void Main()
    {
        Console.WriteLine("Введите день недели ( с большой буквы): ");
        string userInputDay = Console.ReadLine();

        // Проверяем корректность ввода дня недели
        bool isDayValid = Enum.TryParse(userInputDay, out DaysOfWeek userDay);

        if (!isDayValid)
        {
            Console.WriteLine("Ошибка ввода дня недели");
            return;
        }

        Console.WriteLine("Введите текущее время (от 0 до 23): ");
        int userInputTime = Convert.ToInt32(Console.ReadLine());

        // Проверяем корректность ввода времени
        if (userInputTime < 0 || userInputTime > 23)
        {
            Console.WriteLine("Ошибка ввода времени");
            return;
        }

        // Определяем время суток
        TimesOfDay timeOfDay = GetTimeOfDay(userInputTime);

        // Выводим сообщение
        Console.WriteLine($"Сейчас {userDay}, {timeOfDay}, {userInputTime}:00");
    }

    static TimesOfDay GetTimeOfDay(int time)
    {
        if (time >= 7 && time < 12)
        {
            return TimesOfDay.Утро;
        }
        else if (time >= 12 && time < 18)
        {
            return TimesOfDay.День;
        }
        else if (time >= 18 && time < 24)
        {
            return TimesOfDay.Вечер;
        }
        else
        {
            return TimesOfDay.Ночь;
        }
    }
}