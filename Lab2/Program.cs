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

//q4
//create the calculator 
Boolean cont = true; 
while(cont == true)
{
    //press esc
    Console.WriteLine("press esc to quit");
    //get numbers 
    Console.WriteLine("First number: "); 
    double numA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("second number: ");
    double numB = Convert.ToDouble(Console.ReadLine());
    //get operation 
    Console.WriteLine($"1.Addition  2.Subtraction   3.Multiply  4.Divide    5.Mod");
    Console.WriteLine("Press a number to select the operation");
    double selection = Convert.ToDouble(Console.ReadLine());
    switch (selection)
    {
        case 1: Console.WriteLine($"{numA} + {numB} = {numA + numB}");
            break;
       case 2: Console.WriteLine($"{numA} - {numB} = {numA - numB}");
            break;
       case 3: Console.WriteLine($"{numA} x {numB} = {numA * numB}");
            break;
       case 4: Console.WriteLine($"{numA} / {numB} = {numA / numB}");
            break;
       case 5: Console.WriteLine($"{numA} % {numB} = {numA % numB}");
            break;

    }
    //giving an out 
    Console.WriteLine($"hit esc to continue, any other key to continue");
    if(Console.ReadKey().Key == ConsoleKey.Escape)
    {
        cont = false;
    }


}

