/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Выполнить с помощью числовых операций (целочисленное деление, 
остаток от деления).
14212 -> нет
12821 -> да
23432 -> да 
*/
//Функиця определения полидромного числа.
void Pollidromcheck(int num)
{
    int first = num % 10;
    int second = num % 100 / 10;
    int fifth = num / 10000;
    int fourth = num / 1000 % 10;

    if (first == fifth && second == fourth) { Console.WriteLine("Да, это палиндромом."); }
    else { Console.WriteLine("Нет, это не палиндромом."); }
}

//Тело программы
Console.WriteLine("Введите пятизначное целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());

//проверка на положительное
if (num < 0) { Console.WriteLine("Ошибка! Вы ввели отрицательно число!"); return; }
else { Console.WriteLine($"Вы ввесли число: {num}"); }

// проверка на пятизначное
if ((num / 10000) > 0 && (num / 100000) == 0) { Console.WriteLine("Унаем яляется ли оно палидромом."); }
else { Console.WriteLine("Ошибка! Ваше число не пятизначное! Попробуйте еще."); return; }

//Вывод результата
Pollidromcheck(num);
