int n = new Random().Next(0, 10000);
Console.WriteLine($"Выбрано число {n}");
if (n < 100){
    Console.WriteLine("Третьей цифры нет");
}
else{
    int thirdDigit = n % 100 / 10;
    Console.WriteLine($"Третья цифра заданного числа {n} равна {thirdDigit}");
}