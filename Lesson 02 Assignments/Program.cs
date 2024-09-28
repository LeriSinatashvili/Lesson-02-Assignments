int SumOfProductPrice = 0;
String HaveMoreProducts = "";

do
{
    Console.WriteLine("Enter product price and i will sum tem for you");
    int ProductPrice = int.Parse(Console.ReadLine());

    SumOfProductPrice = SumOfProductPrice + ProductPrice;

    Console.WriteLine("Have more products ?");
    HaveMoreProducts = Console.ReadLine();

}
while (HaveMoreProducts == "yes" || HaveMoreProducts == "y");

Console.WriteLine("Sum of all your product price is");
Console.WriteLine(SumOfProductPrice);