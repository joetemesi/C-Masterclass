
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");

        string input = Console.ReadLine();
        char character = input[0];
        int targetLength = int.Parse(Console.ReadLine());

        // Call the method within the Main method
        string myCharacters = Exercise.RepeatCharacter(character, targetLength);
        Console.WriteLine(myCharacters);
        
        Console.ReadKey();
    }
}
public class Exercise
{
    public static string RepeatCharacter(char character, int targetLength)
    {
        //your code goes here
        if (targetLength <= 1)
        {
            return character.ToString();
        }
        else
        {
            string myCharacter = character.ToString();
            do
            {

                myCharacter += character;
            }
            while (myCharacter.Length < targetLength);
            return myCharacter;
        }
    }
}
