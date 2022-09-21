void Task10(){
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Abs(number % 100 / 10));
}
void Task13(){

}
void Task15(){

}

Task10();
//Task13();
//Task15();