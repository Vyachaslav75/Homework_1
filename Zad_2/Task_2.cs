//Домашнее задание задача 2 
Console.Write("Введите целое число a: ");
string userInput = Console.ReadLine() ?? "";
int userNumber_a = int.Parse(userInput);
Console.Write("Введите целое число b: ");
userInput = Console.ReadLine() ?? "";
int userNumber_b = int.Parse(userInput);

if (userNumber_a > userNumber_b)
{
    Console.WriteLine("a=" + userNumber_a + ", b=" + userNumber_b + " -> " + "max = " + userNumber_a + ", min = " + userNumber_b);
}
else
{
    Console.WriteLine("a=" + userNumber_a + ", b=" + userNumber_b + " -> " + "max = " + userNumber_b + ", min = " + userNumber_a);
}