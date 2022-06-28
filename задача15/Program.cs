Console.WriteLine("Напишите число от 1 до 7 для определения дня недели");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n== 7){
    Console.WriteLine("Ура, выходной!");
}
else if (n < 1 || n > 7) {
    Console.WriteLine("Ошибка ввода, введите число от 1 до 7");
}
else {
    Console.WriteLine("Будний день :(");
}
