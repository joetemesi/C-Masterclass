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

string userOperation = Console.ReadLine().ToUpper();


//if (userOperation == "A" || userOperation == "a")
if (userOperation == "A")
{
    //Console.WriteLine("The result is: " +(num1 + num2));
    int calculationResult = num1 + num2;
    Console.WriteLine(resultOfOperation(num1, num2, "+", calculationResult));
}
//else if(userOperation == "S" || userOperation == "s")
else if(userOperation == "S")
{
    //Console.WriteLine("The resulit is: " + (num1 - num2));
    int calculationResult = num1 - num2;
    Console.WriteLine(resultOfOperation(num1, num2, "-", calculationResult));
}
//else if (userOperation == "M" || userOperation == "m")
else if (userOperation == "M")
{
    //Console.WriteLine("The result is " + (num1 * num2));
    int calculationResult = num1 * num2;
    Console.WriteLine(resultOfOperation(num1, num2, "*", calculationResult));

    
}
else
{
    Console.WriteLine("Invalid operation, please choose from the options above");
}

string resultOfOperation (int num1, int num2, string @operator, int calculationResult)
{
    string result = string.Concat("The ", "result", " of ", num1, " ", @operator, " ", num2, " ", "=", " ", calculationResult);
    return result;
}
 
Console.ReadKey();







