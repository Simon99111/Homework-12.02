Console.WriteLine("Введите цифру");
int n = Convert.ToInt32(Console.ReadLine());
if (n > -1 && n < 10)
{
    if (n == 6 || n == 7) Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}
else
    Console.WriteLine("Вы ввели не цифру");