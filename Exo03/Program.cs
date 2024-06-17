// Exo 01 - Calcule de la division entière, du modulo et de la division de deux entiers.
// Résultat attendu pour 5 et 2 🡪 Division entière : 2, Modulo: 1, Division: 2,5.


Console.WriteLine("Veuillez encoder deux nombres entiers : ");
Console.Write("> nb1 : ");
int nb1 = int.Parse(Console.ReadLine()!);
Console.Write("> nb2 : ");
int nb2 = int.Parse(Console.ReadLine()!);

int resIntDiv  = nb1 / nb2;
int resMod1 = nb1 - (resIntDiv * nb2);
int resMod2 = nb1 % nb2;
double resRealDiv = (double)nb1 / nb2;

Console.WriteLine("Resultat : ");
Console.WriteLine($"{nb1} DIV {nb2} = {resIntDiv}");
Console.WriteLine($"{nb1} % {nb2} = {resMod1}");
Console.WriteLine($"{nb1} % {nb2} = {resMod2}");
Console.WriteLine($"{nb1} / {nb2} = {resRealDiv}");
Console.WriteLine();


// Exo 02 - Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
// Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97. (utilisez la méthode « Substring » de la classe « string »).

Console.Write("Veuillez encoder votre compte BBAN : \n> ");
string compte = Console.ReadLine()!;

long valueAccount = long.Parse(compte.Substring(0, 10));
int validator = int.Parse(compte.Substring(10, 2));

int valueToCheck = (int)(valueAccount % 97);

if(valueToCheck == validator || (valueToCheck == 0 && validator == 97))
{
    Console.WriteLine("Votre numéro de compte est valide :)");
}
else
{
    Console.WriteLine("Votre numéro de compte est invalide (╯°□°）╯︵ ┻━┻");
}


// Exo 03 - Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) en IBAN (BExx-xxxx-xxxx-xxxx). Trouvez la démarche via un moteur de recherche.


// Valeur pour générer l'IBAN = BBAN + BE(1114) + 00
long temp = long.Parse(compte  + "1114" + "00");

// Chiffre de control : 98 - (Le reste de "temp" par 97)
// https://claudeleloup.developpez.com/tutoriels/access/calcul-du-code-iban/images/image2.png
int controlIBAN = (int)(98 - (temp % 97));

// Génération du IBAN : Code Pays + Control + Compte
// https://claudeleloup.developpez.com/tutoriels/access/calcul-du-code-iban/images/image1.png
string iban = "BE" + controlIBAN + compte;

Console.WriteLine($"Version IBAN : {iban}");