// Exo 01 - Calculer les 25 premiers nombres de la suite de Fibonacci
/*
{
    const int NB_FIBONACCI = 25;
    Console.WriteLine($"1) Afficher les {NB_FIBONACCI} premiers nombres de la suite de Fibonacci");

    int nb1 = 0;
    int nb2 = 1;
    Console.Write("0, 1");

    for(int count = 2; count < NB_FIBONACCI; count++)
    {
        int temp = nb1 + nb2;
        nb1 = nb2;
        nb2 = temp;

        Console.Write($", {nb2}");
    }
}
Console.WriteLine();
Console.WriteLine();
*/


// Exo 02 - Calculer le factoriel d’un nombre entré au clavier
/*
{
    Console.Write("Factoriel du nombre : ");
    int nb = int.Parse(Console.ReadLine()!);

    int result = 1;
    int count = nb;
    while(count > 0)
    {
        result *= count;
        count--;
    }
    Console.WriteLine($"Le resultat de {nb}! est {result}.");
}
Console.WriteLine();
*/


// Exo 03 - Grâce à une boucle « for », calculez les x premiers nombre premier
{
    Console.Write("Nombre prémier désiré : ");
    int nbUserRequest = int.Parse(Console.ReadLine()!);

    int nbFound = 0;
    int nbOp = 0;

    // Le seul et unique nombre pair qui est nombre premier ( ´･･)ﾉ(._.`)
    if (nbUserRequest > 0) {
        Console.Write("2");
        nbFound++;
        nbOp++;
    }
    // Tout les nombres impair à tester
    for(int nbTest = 3; nbFound < nbUserRequest; nbTest += 2)
    {
        bool isPrime = true;
        double nbTestLimit = Math.Sqrt(nbTest);

        for (int div = 3; isPrime && nbTestLimit >= div ; div += 2)
        {
            nbOp++;
            if (nbTest % div == 0)
            {
                isPrime = false;
            }
        }

        if(isPrime)
        {
            Console.Write($", {nbTest}");
            nbFound++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Nb operation pour trouver : {nbOp}");
}
