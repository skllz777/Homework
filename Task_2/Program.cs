Console.Clear();
Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int k = Convert.ToInt32(Console.ReadLine());
if (n > m)
    if (n > k)
    Console.WriteLine($"max: {n}");
    else
    Console.WriteLine($"max: {k}");
else if (m > k)
Console.WriteLine($"max: {m}");
else 
Console.WriteLine($"max: {k}");