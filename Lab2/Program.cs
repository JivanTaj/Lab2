// See https://aka.ms/new-console-template for more information

using ConsoleTables;

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


//q3
//making the table 
var table = new ConsoleTable("type", "byte(s) of mem", "Min", "max");
table.AddRow($"sByte", $"1", $"{sbyte.MinValue}", $"{sbyte.MaxValue}");
table.AddRow($"Byte", $"1", $"{byte.MinValue}", $"{byte.MaxValue}");
table.AddRow($"short", $"2", $"{short.MinValue}", $"{short.MaxValue}");
table.AddRow($"ushort", $"2", $"{ushort.MinValue}", $"{ushort.MaxValue}");
table.AddRow($"int", $"4", $"{int.MinValue}", $"{int.MaxValue}");
table.AddRow($"uint", $"4", $"{uint.MinValue}", $"{uint.MaxValue}");
table.AddRow($"long", $"8", $"{long.MinValue}", $"{long.MaxValue}");
table.AddRow($"ulong", $"8", $"{ulong.MinValue}", $"{ulong.MaxValue}");
table.AddRow($"float", $"4", $"{float.MinValue}", $"{float.MaxValue}");
table.AddRow($"double", $"8", $"{double.MinValue}", $"{double.MaxValue}");
table.AddRow($"decimal", $"16", $"{decimal.MinValue}", $"{decimal.MaxValue}");

//displaying the table 
Console.WriteLine(table);

