int demo = int.MaxValue;
demo++;

Console.WriteLine(demo);
Console.WriteLine();




Console.Write("Veuillez encoder un nombre \n> ");
int nbTarget = int.Parse(Console.ReadLine()! );

// Traitement
int nbCheck = (nbTarget / 2) * 2;

// Affichage 
string result;

if(nbTarget ==  nbCheck)
{
    result = "pair";
}
else
{
    result = "impair";
}

Console.WriteLine($"Le nombre {nbTarget} est {result}");
