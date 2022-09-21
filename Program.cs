int getNumber(string message)
{
    Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

void Task10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    int number = getNumber("Введите трехзначное число");

    Console.WriteLine("Вторая цифра: " + Math.Abs(number % 100 / 10));
}
void Task13()
{
    //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    int number = Math.Abs(getNumber("Введите число"));

    if (number > 99)
    {
        while (number > 999)
        {
            number = number / 10;
        }

        Console.WriteLine("Третья цифра: " + number % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }

}
void Task15()
{
    // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    
    int numberDay = getNumber("Введите цифру, обозначающую день недели");

    string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

    if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine("Выходной!");
    }
    Console.WriteLine(days[numberDay - 1]);
}

Task10();
//Task13();
//Task15();