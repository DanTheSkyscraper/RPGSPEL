public class Startscene // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{
    public static string wakeUp()
    {
        string wakeUp = ""; // This while-loop is case sensitive. Only lowercase letters.
        while (wakeUp != "yes" && wakeUp != "no") // This while-loop will make it so that the player has to type either yes or no. If they don't, the 
        {
            wakeUp = Console.ReadLine();
            if (wakeUp != "yes" || wakeUp != "no")
            {
                Console.WriteLine("Please write yes or no! The answer should be in lowercase!");
            }

        }
        return wakeUp; // This code will restart the while-loop if the player doesn't type yes or no.

    }
}