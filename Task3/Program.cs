string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскреснье" };
Console.Write("Введите номер дня недели: ");
string weekday = Console.ReadLine();
int dayNumber = Convert.ToInt32(weekday);
if (dayNumber < 0 || dayNumber > 7)
{
    Console.WriteLine("Ошибка, нет такого дня недели");
}
else
{
    if (dayNumber == 6 || dayNumber == 7)
      {  Console.WriteLine(week[dayNumber - 1]);
    System.Console.WriteLine($"Выходной");
      }
else
    { Console.WriteLine(week[dayNumber - 1]); }
}

