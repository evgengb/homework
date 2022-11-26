// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Ваше число >>>" + " ");
string inputValue = Console.ReadLine();
int N = Convert.ToInt32(inputValue);

if(N % 2 == 0)
{
    System.Console.WriteLine("Число" + " " + N + " " + "=> Четное");
}
else
{
    System.Console.WriteLine("Число" + " " + N + " " + "=> Нечетное");
}
