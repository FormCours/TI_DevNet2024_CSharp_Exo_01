// Exo 01 - Parse
{
    // Saisie
    Console.WriteLine("Veuillez encoder 2 nombre entier : ");
    Console.Write("Nb1: ");
    string input1 = Console.ReadLine()!;
    Console.Write("Nb2: ");
    string input2 = Console.ReadLine()!;

    // Convert
    int nb1;
    nb1 = int.Parse(input1);

    int nb2 = int.Parse(input2);

    // Traitement...
    int result = nb1 + nb2;

    // Afficher la réponse
    Console.WriteLine($"L'addition de {nb1} et {nb2} donne {result}");
}


// Exo 02 - TryParse
{
    // Saisie
    Console.WriteLine("Veuillez encoder 2 nombre entier : ");
    Console.Write("Nb1: ");
    string input1 = Console.ReadLine()!;
    Console.Write("Nb2: ");
    string input2 = Console.ReadLine()!;

    // Convert
    int nb1;
    bool test1 = int.TryParse(input1, out nb1);

    bool test2 = int.TryParse(input2, out int nb2);

    // Traitement...
    int result = nb1 + nb2;

    // Afficher la réponse
    Console.WriteLine($"L'addition de {nb1} et {nb2} donne {result}");

}



