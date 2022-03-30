namespace AppLogic;

// Class with game logic in it
public class Logic
{
    // generates random and adds it into a List. 
    public List<int> GenerateRandom()
    {
        List<int> randomlist = new List<int>();
        // loops until i is bigger than 6.
        for (int i = 0; i < 6; i++)
        {
            // new Random.Next(1,42) generates random between 1 and 42
            // randomArray.add(new Random.Next(1,42)) adds generated random into list
            randomlist.Add(new Random().Next(1, 43));
        }

        // Returns generated randomList
        return randomlist;
    }

    public int FindRandom(List<int> randomList, int guess, int counter = 0 )
    {
        // checks if number is in correct range
        if (guess > 42 || guess< 1 )
        {
            // if not, code should throw new error
            throw new Exception("number must be between 1 and 42");
        }
        else
        {
            // returns Message 
            string message = guess + " was correct";
            counter += 1;
            if (!randomList.Contains(guess) )
            {
                message = guess + " was false";
                counter -= 1;
            }
            Console.WriteLine(message);

            return counter;
        }

    }
}