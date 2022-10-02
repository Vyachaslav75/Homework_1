//Домашнее задание задача 8
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
int i = 0;

Console.Write(userNumber + " -> ");

while (i + 2 <= userNumber)
{
    i += 2;
    if (i==2)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write(", "+i);
    }
    
}
