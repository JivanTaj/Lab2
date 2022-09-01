// See https://aka.ms/new-console-template for more information

//q1
//collect the input
Console.Write($"Enter the first number:  ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Enter the second number:  ");
double num2 = Convert.ToDouble(Console.ReadLine());

//add them and display 
Console.WriteLine($"{num1} + {num2} = {num1+num2}");


//q2
//get input 
Console.WriteLine("select a number to view a multiplication list");
double input = Convert.ToDouble(Console.ReadLine());
//get mult # 
Console.WriteLine("how far shall we multiply it?  ");
double maxNum = Convert.ToDouble(Console.ReadLine());
//display multiplication table 
for (int i = 0; i <= maxNum; i++)
{
    Console.WriteLine($"   {input} x {i} = {input*i}");
}
