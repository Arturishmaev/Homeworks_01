//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
   System.Console.WriteLine("Максимальное число : " + num1);
}
else
{
    System.Console.WriteLine("Максимальное число : " + num2);
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число :");
int num3 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
    System.Console.WriteLine("Ваше максимальное число : " + num1);
}
else if (num2 > num3)
{
    System.Console.WriteLine("Ваше максимальное число : " + num2);
}
else if (num3 > num1)
{
    System.Console.WriteLine("Ваше максимальное число : " + num3);
}


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число для проверки на четность : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    System.Console.WriteLine("Ваше число четное");
}
else
{
    System.Console.WriteLine("Ваше число нечетное");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.





