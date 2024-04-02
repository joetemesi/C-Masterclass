// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Hello, World!");

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        // Call the method within the Main method
        int sum = Exercise.CalculateSumOfNumbersBetween(firstNumber, secondNumber);
        Console.WriteLine("Sum of numbers between " + firstNumber + " and " + secondNumber + " is: " + sum);
        Console.ReadKey();
    }
}
public class Exercise
{
    public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
    {
        //your code goes here
        int sum = 0;
        if (firstNumber > lastNumber)
        {
            sum = 0;
            return sum;
        }
        else if (firstNumber == lastNumber)
        {
            sum = firstNumber;
            return sum;
        }
        else
        {
            int currentNumber = firstNumber;
            while (currentNumber <= lastNumber)
            {
                sum += currentNumber;
                currentNumber++;
            }
            return sum;
        }
    }
}

