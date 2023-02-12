Console.Write("Введите число ");
int k = Convert.ToInt32(Console.ReadLine());

if (k > 99)
{
    while (k > 999)
    {
        k = k / 10;
    }
    k = k % 10;
    Console.WriteLine($"Третья цифра числа = {k}");
}
else
    Console.WriteLine("Третьей цифры нет");