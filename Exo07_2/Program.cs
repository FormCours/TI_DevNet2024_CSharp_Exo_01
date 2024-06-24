using Exo07_2.Models;

Equation equation = new Equation();

equation.A = 2;
equation.B = 9;
equation.C = -5;

equation.Resoudre(out double? X1, out double? X2);

Console.WriteLine($"X1 ► {X1} , X2 ► {X2}");
