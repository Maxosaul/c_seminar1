﻿// Напишите программу 
System.Console.WriteLine("Введите число "); // оповещение пользователя
int num = Convert.ToInt32(System.Console.ReadLine()); // конвертируем в целое число (32 бита), и сохраняем его в num

if(num<0 || num==0) // ||- логическое или, где одно из утверждений должна быть истиной
{
    System.Console.WriteLine("Число меньше нуля"); // проверка на правильность ввода числа, т.е. на натуральность
}
else
{
    int i =-1*num; // высчитываем то самое -n определяем начало счетчика
    while(i<=num)
    {
        System.Console.Write(i + " ");
        i++; //увеличиваем i на еденицу (i=i+i)
    }
}