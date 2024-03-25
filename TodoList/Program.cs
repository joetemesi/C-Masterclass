// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Hello, World!");
Console.WriteLine("What do you want to do today?\n");

Console.WriteLine("[S]see all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");
//Variable declarations and Initialization
//string userInput = "A";
//Console.WriteLine(userInput);
//userInput = "ABC\n";
//Console.WriteLine(userInput);

string userInput = Console.ReadLine().ToUpper(); //refactor to convert input to upper case
;

switch (userInput)
{
    case "S":
        PrintSelectedOption("See all Todos");
        break;
    case "A":
        PrintSelectedOption("Add a Todo"); 
        break;
    case "R":
        PrintSelectedOption("Remove a Todo"); 
        break;
    case "E":
        PrintSelectedOption("Exit"); 
        break;
    default: Console.WriteLine("Invalid choice");
        break;


}
//if (userInput == "S" || userInput == "s")
//{
//    PrintSelectedOption("See all Todos");
//}
    
//else if (userInput == "A" || userInput == "a")
//{
//    PrintSelectedOption("Add a Todo");
//}
//else if(userInput == "R" || userInput == "r")
//{
//    PrintSelectedOption("Remove a Todo");
//}
//if(userInput == "E" || userInput == "e") 
//{
//    PrintSelectedOption("Exit");
//}

void PrintSelectedOption(string selectedOption)
            {
                Console.WriteLine("Selected Option: " + selectedOption);
            }

//var result = Add(10, 5);
//Console.WriteLine("10 + 5: " + result);

//int Add(int a, int b)
//{
//    return a + b;
//}


//int myNumber = 1;
//Console.WriteLine(myNumber);
// myNumber = 123;
//Console.WriteLine(myNumber);

//var userInput = Console.ReadLine(); ///implicit declaration

//bool isUserInputABC = userInput == "ABC";


Console.ReadKey();
//Console.WriteLine("Hello, World!");
//Console.ReadKey();

