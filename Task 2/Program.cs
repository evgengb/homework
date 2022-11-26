//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее

Console.Write ("Введите A ->" + " ");
string inputValue1 = Console.ReadLine();
int A = Convert.ToInt32(inputValue1);

Console.Write("Введите B ->" + " ");
string inputValue2 = Console.ReadLine();
int B = Convert.ToInt32(inputValue2);

Console.Write ("Введите C ->" + " ");
string inputValue3 = Console.ReadLine();
int C = Convert.ToInt32(inputValue3);

if(A>B && A>C)
{
    Console.Write("Наибольшее число" + " " + A + " ");
   
}
else 
    if(B>C)
    {
        Console.Write("Наибольшее число" + " " + B + " ");
        
    }
    else
    {
        Console.Write("Наибольшее число" + " " + C + " ");
        
    }

