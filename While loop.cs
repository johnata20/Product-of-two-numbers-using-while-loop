int num1, num2, x = 1;

Console.WriteLine("Enter numbers to be multiplied:");
Console.Write("1st number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2nd number: ");
num2 = Convert.ToInt32(Console.ReadLine());

int prod = num1;

while (x < num2)
{
    prod = prod + num1;
    x++;
}

Console.WriteLine("Product : " + prod);
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
