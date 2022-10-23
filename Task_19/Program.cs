/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Выполнить с помощью числовых операций (целочисленное деление, 
остаток от деления).
14212 -> нет
12821 -> да
23432 -> да 
*/
//Функция с разворотом и сравнением.(рабочий, но длинный вариант) 
//void PollidromCheckInverted(int number)
//{
//    int result = number % 10; int fifth = result * 10000;
//    result = number / 10; int fourth = (result % 10) * 1000;
//    result = result / 10; int third = (result % 10) * 100;
//    result = result / 10; int second = (result % 10) * 10;
//    int first = result/ 10; 
//    int inverted = fifth + fourth + third + second + first;
//    if (inverted == number) { Console.WriteLine("Да, это палиндромом.");}
//    else {Console.WriteLine("Нет, это не палиндромом.");}    
//}

//Функиця определения полидромного числа.
void Pollidromcheck(int number)
{
    int first = number % 10;
    int second = number % 100 / 10;
    int fifth = number / 10000;
    int fourth = number / 1000 % 10;

    if (first == fifth && second == fourth) { Console.WriteLine("Да, это палиндромом."); }
    else { Console.WriteLine("Нет, это не палиндромом."); }
}

////////////////Тело программы
Console.WriteLine("Введите пятизначное целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());

//проверка на положительное
if (num < 0) { Console.WriteLine("Ошибка! Вы ввели отрицательно число!"); return; }
else { Console.WriteLine($"Вы ввели число: {num}"); }

// проверка на пятизначное
if ((num / 10000) > 0 && (num / 100000) == 0) { Console.WriteLine("Узнаем яляется ли оно палидромом."); }
else { Console.WriteLine("Ошибка! Ваше число не пятизначное! Попробуйте еще."); return; }

//Вывод результата
//PollidromCheckInverted(num);

Pollidromcheck(num);
