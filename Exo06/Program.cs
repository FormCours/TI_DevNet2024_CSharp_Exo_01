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


