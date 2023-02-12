Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
    n = n % 100 / 10;
    Console.WriteLine($"Вторая цифра числа = {n}");
}
else
    Console.WriteLine("Вы ввели не трехзначное число");