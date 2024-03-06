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



//int myNumber = 1;
//Console.WriteLine(myNumber);
// myNumber = 123;
//Console.WriteLine(myNumber);

var userInput = Console.ReadLine(); ///implicit declaration

bool isUserInputABC = userInput == "ABC";


Console.ReadKey();
//Console.WriteLine("Hello, World!");
//Console.ReadKey();

