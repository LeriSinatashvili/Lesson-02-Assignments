bool ContinueAsking = true;

do
{
    Console.WriteLine("I will keep asking until you enter number lower than 10");
    int EnteredNumber = int.Parse(Console.ReadLine());

    if (EnteredNumber < 10)
    {
        ContinueAsking = false;
    }

}
while (ContinueAsking == true);
Console.WriteLine("Its over");