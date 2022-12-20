int number;
int task;
int digit;

int SelectionTask()
{
    Console.Write("Выберите задачу (от 1 до 3): ");
    if (!int.TryParse(Console.ReadLine(), out int task) || task > 3 || task < 1)
    {
        task = SelectionTask();
    }
    return task;
}

//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

int SetThreeDigitNumber()
{
    Console.Write("Введите трёхзначное число: ");
    if (!int.TryParse(Console.ReadLine(), out int number) || number < 100 || number > 999)
    {
        number = SetThreeDigitNumber();
    }
    return number;
}

int GetSecondDigit(int number)
{
    if (number > 9)
    {
        while (number > 99)
        {
            number /= 10;
        }
        return number % 10;
    }
    return -1;
}

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

int SetLessSixDigitNumber()
{
    Console.Write("Введите число менее 100000: ");
    if (!int.TryParse(Console.ReadLine(), out int number) || number > 99999)
    {
        number = SetLessSixDigitNumber();
    }
    return number;
}

int GetThirdDigit(int number)
{
    if (number > 99)
    {
        while (number > 999)
        {
            number /= 10;
        }
        return number % 10;
    }
    return -1;
}

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

int SetDayOfTheWeek()
{
    Console.Write("Введите число дня нелели (от 1 до 7): ");
    if (!int.TryParse(Console.ReadLine(), out int digit) || digit < 1 || digit > 7)
    {
        digit = SetDayOfTheWeek();
    }
    return digit;
}

bool GetDayOff(int digit)
{
    if (digit < 6) return false;
    else return true;
}

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

task = SelectionTask();

if (task == 1)
{
    number = SetThreeDigitNumber();
    Console.WriteLine($"Вторая цифра числа: {GetSecondDigit(number)}");
}
else if (task == 2)
{
    number = SetLessSixDigitNumber();
    digit = GetThirdDigit(number);
    if (digit == -1) Console.WriteLine("Третьей цифры нет!");
    else Console.WriteLine($"Третья цифра числа: {digit}");
}
else if (task == 3)
{
    if (GetDayOff(SetDayOfTheWeek())) Console.WriteLine("Выходной!");
    else Console.WriteLine("Рабочий день");
}