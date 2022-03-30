using System.Runtime.CompilerServices;

using ab2;
using Microsoft.Extensions.Logging;


namespace AB2;
class Program
{
    static void Main(string[] args )
    {   
        Console.WriteLine("Wähle eine Aufgabe: 5, 6 , 7, 7pro, 8, 8pro");
        string aufgabe = Console.ReadLine();

        switch (aufgabe)
        {
            case "5":
                Aufgabe5();
                break;
            case "6":
                Aufgabe6();
                break;
            case "7":
                Aufgabe7();
                break;
            case "7pro":
                Aufgabe7Pro();
                break;
            case "8":
                Aufgabe8();
                break;
            case "8pro":
                Aufgabe8Pro();
                break;
            default: 
                Aufgabe5();
                break;
        }
    }
    
    
    static void Aufgabe5()    {
        Console.WriteLine("AUFGABE 5");
        Console.WriteLine("Bitte Zahl eingeben");
        string inp = Console.ReadLine();
        try
        {
            int inpInt = Int32.Parse(inp);
            Console.WriteLine("Die Wurzel daraus ist " + Math.Sqrt(inpInt));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    static  void Aufgabe6()
    {
        // AUFGABE 6
        Console.WriteLine("AUFGABE 6");
        Console.WriteLine("Validate E-Mail");
        string mail = Console.ReadLine();

        if (!mail.Contains("@") || 
            mail.StartsWith("@") || 
            mail.EndsWith("@") || 
            !mail.Split('@')[1].Contains(".")
           )
        {
            Console.WriteLine("MAIL NOT VALID!");
        }
            
        {
                
        }

        // AUFGABE 6 PRO
        Console.WriteLine("AUFGABE 6 PRO");
        List<string> list = mail.Split('@').ToList();
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }       

    }

    static  void Aufgabe7()
    {
        // AUFGABE 7
        Console.WriteLine("AUFGABE 7");
        List<Person> people = new List<Person>();
        people.Add(new Person("P1", "p1", Sprache.Deutsch));
        people.Add(new Person("P2", "p2", Sprache.Französisch));
        people.Add(new Person("P3", "p3", Sprache.Englisch));

        foreach (Person p in people)
        {
            p.SageHallo();
        }
    }


    static void Aufgabe7Pro()
    {
        Console.WriteLine("Write path:");
        string path = "@";
        path +=Console.ReadLine();

        try
        {
            // Determine whether the directory exists.
            if (Directory.Exists(path))
            {
                // Delete the directory.
                Directory.Delete(path);
                Console.WriteLine("The directory was deleted successfully.");
            }
            else
            {
                // Try to create the directory.
                Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                    
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }

   static void Aufgabe8()
    {
        Console.WriteLine("Schreibe dein Passwort");
        string pw = Console.ReadLine();
        string generatedPw =  Tsbe.CodeCracker.MD5Hash.GeneratePassword(pw);
        Console.WriteLine(generatedPw);
    }

   // debugs person
   static void Aufgabe8Pro()
   {
       // AUFGABE 8 PRO
       // create a logger factory
       var loggerFactory = LoggerFactory.Create(
           builder => builder
               // add console as logging target
               .AddConsole()
               // add debug output as logging target
               .AddDebug()
               // set minimum level to log
               .SetMinimumLevel(LogLevel.Debug));
       // create a logger
       var logger = loggerFactory.CreateLogger<Program>();
       // logging
       logger.LogTrace("Trace message");
       logger.LogDebug("Debug message");
       logger.LogInformation("Info message");
       logger.LogWarning("Warning message");
       logger.LogError("Error message");
       logger.LogCritical("Critical message");
   }
} 

