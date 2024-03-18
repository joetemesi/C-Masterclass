// See https://aka.ms/new-console-template for more information

//This application is a simple calculator. The userwill input two
//numbers and the operation theywant to perform (addition,
//subtraction, multiplication), and the program shall print the
//operation and the result.

Console.WriteLine("Hello ");
Console.WriteLine("Please input the first number \n");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please input the Second number \n" );

int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers? \n");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userOperation = Console.ReadLine();


if (userOperation == "A" || userOperation == "a")
{
    Console.WriteLine("The result is: " +(num1 + num2));
}
else if(userOperation == "S" || userOperation == "s")
{
    Console.WriteLine("The resulit is: " + (num1 - num2));
}
else if (userOperation == "M" || userOperation == "m")
{
    Console.WriteLine("The result is " + (num1 * num2));
    
}
else
{
    Console.WriteLine("Invalid operation, please choose from the options above");
}

 
Console.ReadKey();







