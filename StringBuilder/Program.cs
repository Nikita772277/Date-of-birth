using System.Text.RegularExpressions;
while (true)
{

    Console.WriteLine("Введите дату рождения");
    Console.WriteLine();
    Console.WriteLine("Пример ввода - 24.9.1980");
    Console.WriteLine();
    string date = Console.ReadLine();
    if (date == "" || date == " ")
    {
        Console.WriteLine($"Вы ввели некорректные данные");
        Console.WriteLine();
    }
    else
    {
        Regex regex = new Regex(@"[1-30,1-9]{1,2}.[1-12,1-9]{1,2}.[1913-2017,1-9]{3,4}$");
        regex.IsMatch(date);
        if (regex.IsMatch(date))
        {
            Console.WriteLine($"Дата рождения принята");
            Console.WriteLine();
            Console.WriteLine($"Введённая дата рождения - {date}");
        }
        else
        {
            Console.WriteLine("Вы ввели некорректные данные");
        }
    }
}