Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 1)
Console.WriteLine("Число является нечётным");
else
Console.WriteLine("Число является чётным");