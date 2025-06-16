// See https://aka.ms/new-console-template for more information
using System.Data.Common;

String name,location;
Console.Write("enter the name :");
name=Console.ReadLine();

Console.Write("Enter location  :");
location=Console.ReadLine();
Console.WriteLine($"Hello {name},located at {location}");
