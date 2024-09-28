int SumOfNumbers = 0;
int i = 1;
int CountDownNumber = 5;

while (i <= 5)
{

    Console.WriteLine($"Enter numbers {CountDownNumber} times and i will sum them");
    int EnteredNumber = int.Parse(Console.ReadLine());

    SumOfNumbers = SumOfNumbers + EnteredNumber;
    CountDownNumber = CountDownNumber - 1;
    i++;

}

Console.WriteLine("Sum of entered numbers is " + SumOfNumbers);