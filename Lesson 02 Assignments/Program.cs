int FirstRow = 0;

while (FirstRow < 5)
{
    int OtherRows = 0;

    while (OtherRows < FirstRow + 1)
    {

        Console.Write("*");
        OtherRows++;
    }

    Console.WriteLine();
    FirstRow++;
}