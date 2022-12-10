Console.WriteLine("Choose language, Выберите язык.  English, Русский");
string language = Console.ReadLine();

if (language == "Русский" || language == "русский")
{
    Console.WriteLine("Напишите число");
    double number = Convert.ToInt64(Console.ReadLine());
    byte help1 = 0;
    for (byte i = 1; i <= 100; i++)
    {
        help1++;
        Console.WriteLine($"{help1} процентов от числа {number} = {number/100*help1}");
    }
}
else if (language == "English" || language == "english"){
    Console.WriteLine("Write number");
    double number = Convert.ToInt64(Console.ReadLine());
    byte help1 = 0;
    for (byte i = 1; i <= 100; i++)
    {
        help1++;
        Console.WriteLine($"{help1} precent from number {number} = {number / 100 * help1}");
    }
}
else
{
    Console.WriteLine("Error, ошибка.");
}
