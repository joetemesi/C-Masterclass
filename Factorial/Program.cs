using System.Numerics;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        BigInteger factorialResult = Exercise.Factorial(int.Parse(Console.ReadLine()));
        Console.WriteLine(factorialResult);
        Console.ReadKey();

    }
}
public class Exercise
{
    public static BigInteger Factorial(int number)
    {
        //your code goes here
        BigInteger factorial = 1;
        if (number == 1 || number == 0)
        {
            return 1;
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
