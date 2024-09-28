Console.WriteLine("Tell me your transactions and i will tell you sum of your ballance");

String TransactionType = "";
decimal TransactionMoney = 0;
decimal SumOfIncomes = 0;
decimal SumOfExpenses = 0;
decimal SumOfBalance = 0;
String HaveMoreTransactions = "";

do
{
    Console.WriteLine("Tell me if it was Income or Expense");
    TransactionType = Console.ReadLine();
    Console.WriteLine("Tell me how much was it");
    TransactionMoney = decimal.Parse(Console.ReadLine());


    if (TransactionType == "Income")
    {
        SumOfIncomes = SumOfIncomes + TransactionMoney;
        SumOfBalance = SumOfBalance + TransactionMoney;
    }
    if (TransactionType == "Expense")
    {
        SumOfExpenses = SumOfExpenses + TransactionMoney;
        SumOfBalance = SumOfBalance - TransactionMoney;
    }

    Console.WriteLine("Have more transactions");
    HaveMoreTransactions = Console.ReadLine();

}
while (HaveMoreTransactions == "yes" || HaveMoreTransactions == "y");

Console.WriteLine("Sum of expenses are: " + SumOfExpenses);
Console.WriteLine("Sum of incomes are: " + SumOfIncomes);
Console.WriteLine("Your balance is: " + SumOfBalance);