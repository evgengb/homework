// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N >>>");
string inputValue = Console.ReadLine();
int N = Convert.ToInt32(inputValue);

int A = 2;

while(A<=N)
{
    Console.WriteLine(A + " ");
    A=A+2;
}
