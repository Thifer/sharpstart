// See https://aka.ms/new-console-template for more information
//Отсортировать данные в нем по возрастанию.
    

int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

printarray(a);

int[] b = new int[a.Length];
int c = 0;

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        b[c] = a[i, j];
        c++;
    }
}

b = b.OrderBy(i => i).ToArray();
c = 0;

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = b[c];
        c++;

    }
}

printarray(a);

void printarray(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write(ints[i, j] + " ");
        }

        Console.WriteLine();
    }
}