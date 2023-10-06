// вычисление модуля числа
System.Console.WriteLine("Введите число ");
int num = int.Parse(System.Console.ReadLine());
if (num<0)
{
    num = num*-1;
}
System.Console.WriteLine("Получается " + num);