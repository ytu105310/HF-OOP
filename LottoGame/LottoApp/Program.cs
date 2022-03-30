
using AppLogic;

namespace LottoGame;

public class AppGame
{

    static void Main(string[] args)
    {
     StartGame();
    }

    public static void StartGame()
    {
        int counter = 0; 
        Logic logic = new Logic();
        List<int> randomArray = logic.GenerateRandom();
        Console.WriteLine("The Game generated 6 random numbers, are you able to guess them ? ");
        // iterrates until user has entered six numbers
        for (int i = 0; i < 6; i++)
        {
            // reads and parses number
            // checks if number is in generated array
            try
            {    // tries to find number        
                int guess = Int32.Parse(Console.ReadLine());
               counter = logic.FindRandom(randomArray, guess, counter);
            }
            catch (Exception e)
            {
                // catches error if logic throws new error
                Console.WriteLine(e.Message);
                i -= 1;
            }
        }
        
        // shows generated number at the end of the game
        Console.WriteLine($"Numbers were {string.Join("\n", randomArray)}");
        Console.WriteLine($"{counter} of your guesses were correct");
    }
}