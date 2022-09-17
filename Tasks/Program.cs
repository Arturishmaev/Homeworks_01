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