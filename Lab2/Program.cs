// See https://aka.ms/new-console-template for more information

//collect the input
Console.Write($"Enter the first number:  ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Enter the second number:  ");
double num2 = Convert.ToDouble(Console.ReadLine());

//add them and display 
Console.WriteLine($"{num1} + {num2} = {num1+num2}");
