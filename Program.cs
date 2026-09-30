Console.WriteLine("Please enter an integer");
int number = Convert.ToInt32(Console.ReadLine());

if (number >0)
{
    Console.WriteLine("The number is positive");
}
else if (number < 0)
{
    Console.WriteLine("The number is negative");
}
else
{
    Console.WriteLine("The number is zero");
}