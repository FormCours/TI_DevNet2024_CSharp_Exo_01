using System.Text;

// Exo 02 - Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).

/*
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
*/

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

// Exo 03 - Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de ces deux nombres en ne convertissant que caractère par caractère. (Méthode « ToCharArray() » de la classe « string »).

// Saisie utilisateur
Console.WriteLine("Veuillez encoder les deux nombres a additionner : ");
Console.Write(" > ");
string val1 = Console.ReadLine()!;
Console.Write(" > ");
string val2 = Console.ReadLine()!;

// Convertir les valeurs en tableau de char et inversé (pour les process)
char[] nb1Reverse = val1.ToCharArray().Reverse().ToArray();
char[] nb2Reverse = val2.ToCharArray().Reverse().ToArray();

List<int> result = new List<int>();
int report = 0;

for(int i = 0; i < nb1Reverse.Length || i < nb2Reverse.Length;  i++)
{
    int elem1 = (i < nb1Reverse.Length) ? int.Parse(nb1Reverse[i].ToString()) : 0;
    int elem2 = (i < nb2Reverse.Length) ? (nb2Reverse[i] - '0') : 0;
    // NB: Le char '0' vaut la valeur 48 dans la table ASCII

    // Addition des 2 nombres et du report si necessaire
    int temp = elem1 + elem2 + report;

    // Calcul du report et du resultat
    report = temp / 10;
    result.Insert(0, temp % 10);
}
if(report != 0)
{
    result.Insert(0, report);
}

StringBuilder sb =  new StringBuilder();
foreach(int elem in result)
{
    sb.Append(elem);
}
string finalResult1 = sb.ToString();
string finalResult2 = string.Join("", result);

Console.WriteLine($"Resultat : {val1} + {val2} = {finalResult1}");

