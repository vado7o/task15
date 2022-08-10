Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

var num = 0;

while(true) {
Console.WriteLine("Введите любое целое число от 1 до 7 включительно: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number)) {
    num = number;
    if(num > 7 || num < 1) {
        Console.WriteLine("Нет такого дня недели с числом " + num + "!");
    }
    else if(num == 6 || num == 7) {
        Console.WriteLine("Да, день недели под цифрой " + num + " является выходным!");
        break;
    }
    else {
        Console.WriteLine("Нет, день недели под цифрой " + num + " НЕ является выходным!");
    break;
    }
}
else Console.WriteLine("Некорректно введено число!");
}
