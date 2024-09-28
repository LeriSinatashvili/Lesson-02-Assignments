int StudentScore = 0;
String HaveMoreProducts = "";
int AverageScore = 0;
int NumberOfScores = 0;
int SumOfAllScores = 0;

do
{
    Console.WriteLine("Enter student scores and i will tell you average point");
    StudentScore = int.Parse(Console.ReadLine());

    SumOfAllScores = SumOfAllScores + StudentScore;
    NumberOfScores++;

    AverageScore = SumOfAllScores / NumberOfScores;

    Console.WriteLine("Have more scores ?");
    HaveMoreProducts = Console.ReadLine();

}
while (HaveMoreProducts == "yes" || HaveMoreProducts == "y");

Console.WriteLine("Students average score is ");
Console.WriteLine(AverageScore);