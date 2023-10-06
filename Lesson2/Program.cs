Console.WriteLine("Введите первое число - ");
int inputData0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int inputData1 = int.Parse(Console.ReadLine());
if (inputData1 == inputData0 * inputData0)
{
    Console.WriteLine("да");
}
else System.Console.Write("нет");