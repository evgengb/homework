//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write ("Введите A ->" + " ");
string inputValue1 = Console.ReadLine();
int A = Convert.ToInt32(inputValue1);

Console.Write("Введите B ->" + " ");
string inputValue2 = Console.ReadLine();
int B = Convert.ToInt32(inputValue2);

if(A>B)
{
    Console.Write("Число" + " " + A + " " + "больше числа" + " " + B + " ");
}
else
{
    Console.Write("Число" + " " + B + " " + "больше числа" + " " + A + " ");
}

