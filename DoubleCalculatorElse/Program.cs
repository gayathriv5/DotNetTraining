// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information


double i, j, res = 0;
string oper;

Console.Write("Value 1: ");
i = double.Parse(Console.ReadLine());

Console.Write("Value 2: ");
j = double.Parse(Console.ReadLine());

Console.Write("Enter operator(+,-,*,/) :");
oper = Console.ReadLine();

if (oper == "+")
{
    res = i + j;
}

else if (oper == "-")
{
    res = i - j;
}
else if (oper == "*")
{
    res = i * j;
}

else if (oper == "/")
{
    res = i / j;
}

else
{
    Console.WriteLine("Invalid");

}
Console.WriteLine($"Result: {res}");
