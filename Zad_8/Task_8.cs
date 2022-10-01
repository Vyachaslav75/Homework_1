//Домашнее задание задача 8
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
int i = 2;

Console.Write(userNumber + " -> ");
Console.Write(i);
while (i + 2 <= userNumber)
{
    i += 2;
    Console.Write(", "+i);
}
