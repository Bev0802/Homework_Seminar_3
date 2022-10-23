/*0Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
*/
//Функция расчета куба 
void Table(int number)
{
    int count = 1;
    while (count <= number)
    { Console.WriteLine($"{count,3}  | {count * count * count,6}"); 
    count++; 
    }
}

//Тело программы

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((num < 0) ? ("Вы ввели отрицательное число") : ($"Вы ввели число: {num}."));

Table(num);