using Exo06.Models;

int SIZE = 5;

Point?[,] myPoints = new Point?[SIZE, SIZE];

for (int i = 0; i < SIZE; i++)
{
    Point point;
    point.X = i + 1;
    point.Y = i + 1;

    myPoints[i, i] = point;
}


// La méthode "GetLength(index)" permet d'obtenir le nombre d'élément
// dans une des dimensions du tableau matriciel
Console.WriteLine($"Dim 0 : {myPoints.GetLength(0)} / Dim 1 : {myPoints.GetLength(1)} / Total : {myPoints.Length}");

for(int x = 0; x < myPoints.GetLength(0); x++)
{
    for (int y = 0; y < myPoints.GetLength(1); y++)
    {
        if (myPoints[x, y] != null)
        {
            Point p = (Point)myPoints[x, y];

            Console.CursorLeft = y * 12;
            Console.Write($"(X:{p.X} - Y:{p.Y})");
        }
    }
    Console.WriteLine();
}


