int ReadInt (string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool ValidateNumber(int number)
{
    if (number<100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int number = ReadInt("Введите число >");
if (ValidateNumber(number))
{
int thirdnum(int num)
{
    while (num >999)
    {
        num /=10;
    }
    return num %10;
} 
System.Console.WriteLine($"Третье число {thirdnum(number)}");
}

