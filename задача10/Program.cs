int n;
n = new Random().Next(100, 1000);
Console.WriteLine($"Выбрано число {n}");
Console.WriteLine($"Вторая цифра заданного числа {n} равна {(n / 10) % 10}");
