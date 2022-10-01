//Домашнее задание задача 6
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
double userNumber = int.Parse(userInput);

Console.Write(userNumber + " -> ");
if (userNumber%2==0)
{
    Console.WriteLine(" да ");
}
else
{
    Console.WriteLine(" нет ");
}
