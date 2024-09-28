bool ContinueAsking = true;
int NumberOfYes = 3;

do
{

    Console.WriteLine($"I need {NumberOfYes} yes from you to finish this");
    string EnteredText = Console.ReadLine();

    if (EnteredText == "yes")
    {
        NumberOfYes = NumberOfYes - 1;
    }

    if(NumberOfYes == 0)
    {

        ContinueAsking = false;

    }

}
while (ContinueAsking == true);
Console.WriteLine("Its over");