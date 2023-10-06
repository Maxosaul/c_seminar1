//напишите программу которая будет выдовать по номеру день недели
Console.Write("Ведите число от 1 до 7: ");
int number1 = int.Parse(Console.ReadLine());
string [] days = {"Пн", "Вт", "Ср", "Чт","Пт","Сб", "Вс"};
if (number1>=1 && number1<=7)
{
    Console.WriteLine(days[number1-1]);
}
else 
{
    Console.WriteLine("Вы ввели неправельное число");
}
// else if (number1==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (number1==3)
// {
//     Console.WriteLine("Среда");
// }
// else if (number1==4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (number1==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (number1==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (number1==7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else 
// {
//     Console.WriteLine("Вы ввели неправельное число");
// }