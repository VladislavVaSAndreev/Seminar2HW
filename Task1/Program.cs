int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validate3sign(int number)
{
    if (number >=100 && number <1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное");
    return false;
}
int num = ReadInt("Введите число >");
if (Validate3sign(num))
{
    int secondDigit = num%100/10;
    System.Console.WriteLine($"Вторая цифра числа {num} равна {secondDigit}");
}