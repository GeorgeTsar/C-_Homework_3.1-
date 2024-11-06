using C__Homework_3._1;
using System;
using System.Runtime.ConstrainedExecution;

Console.WriteLine();

Employee Empl1 = new();
Empl1.PrintState();
Empl1.SetDescript("проверка турникетов");
Console.WriteLine();

Empl1.PrintState();

Console.WriteLine();

Airplane Air1 = new();
Air1.PrintState();

Console.WriteLine();

Air1.SetName("Ту-104");
Air1.SetManufacturer("Харьковский авиазавод");
Air1.SetYear(1955);
Air1.PrintState();

Console.WriteLine();

Matrix M1 = new(5, 5);
M1.RandomMatrix();
M1.PrintState();

Console.WriteLine();

M1.PrintMax();

Console.WriteLine();

M1.PrintMin();


