/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/ 
Console.WriteLine("Введите целое число:");
int num = int.Parse(Console.ReadLine());
int thirdDig = (int)Math.Log10(num)-2;
if (thirdDig < 0 )
{
    Console.WriteLine("No such digit");
}
else 
{
    Console.WriteLine((num % (int)Math.Pow(10, thirdDig + 1) / (int)Math.Pow(10, thirdDig)).ToString());
}