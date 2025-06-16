// See https://aka.ms/new-console-template for more information
bool Value;
Console.Write("Is Raining ? (true/false):");
Value =bool.Parse(Console.ReadLine());  


if (Value==true)
{
    Console.WriteLine("Take umberlla");
}
else
{

    Console.WriteLine("you need not take umbrella");
}