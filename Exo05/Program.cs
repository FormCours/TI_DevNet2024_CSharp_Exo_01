// Exo 02 - Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).

{
    Console.Write("Nombre prémier désiré : ");
    int nbUserRequest = int.Parse(Console.ReadLine()!);
    int nbOp = 0;

    // La collection de nombre premier
    List<int> primes = new List<int>();

    // Le seul et unique nombre pair qui est nombre premier ( ´･･)ﾉ(._.`)
    if (nbUserRequest > 0)
    {
        primes.Add(2);
        nbOp++;
    }
    // Tout les nombres impair à tester
    for (int nbTest = 3; primes.Count < nbUserRequest; nbTest += 2)
    {
        bool isPrime = true;
        double nbTestLimit = Math.Sqrt(nbTest);

        for (int i = 1; isPrime && i < primes.Count && nbTestLimit >= primes[i]; i++)
        {
            nbOp++;
            if (nbTest % primes[i] == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime)
        {
            primes.Add(nbTest);
        }
    }
    Console.WriteLine($"Nombre premier : {string.Join(", ", primes)}");
    Console.WriteLine($"Nb operation pour trouver : {nbOp}");
}

// Pour info, nombre d'opération avec et sans la collection
/*
 *   // Exo 04
 *       10 =>        14 op
 *      100 =>      1008 op
 *    1 000 =>    40 580 op
 *   10 000 => 1 434 108 op
 *
 *   // Exo 05
 *       10 =>       14 op
 *      100 =>      827 op
 *    1 000 =>   25 134 op
 *   10 000 =>  684 044 op
 */