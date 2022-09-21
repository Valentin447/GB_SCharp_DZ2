void Task10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Abs(number % 100 / 10));
}
void Task13()
{
    //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int numberAbs = Math.Abs(number);

    if (numberAbs > 99)
    {
        while (numberAbs > 999)
        {
            numberAbs = numberAbs / 10;
        }

        Console.WriteLine(numberAbs % 10);
    } 
    else 
    {
        Console.WriteLine("Третьей цифры нет");
    }

}
void Task15()
{
    // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    Console.Write("Введите цифру, обозначающую день недели: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

    if(number == 6 || number == 7){
        Console.WriteLine("Выходной!");
    } 
    Console.WriteLine(days[number - 1]);
}

//Task10();
//Task13();
Task15();