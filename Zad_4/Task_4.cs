//Домашнее задание задача 4
Console.Write("Введите целое число a: ");
string userInput = Console.ReadLine() ?? "";
int userNumber_a = int.Parse(userInput);
Console.Write("Введите целое число b: ");
userInput = Console.ReadLine() ?? "";
int userNumber_b = int.Parse(userInput);
Console.Write("Введите целое число c: ");
userInput = Console.ReadLine() ?? "";
int userNumber_c = int.Parse(userInput);

Console.Write("a=" + userNumber_a + ", b=" + userNumber_b + ", c=" + userNumber_c + " -> ");
if (userNumber_a > userNumber_b)
{
    if (userNumber_a > userNumber_c)
    {
        Console.WriteLine(userNumber_a);
    }
    else
    {
        Console.WriteLine(userNumber_c);
    }
}
else
{
    if (userNumber_b > userNumber_c)
    {
        Console.WriteLine(userNumber_b);
    }
    else
    {
        Console.WriteLine(userNumber_c);
    }
}
