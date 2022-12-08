public class Startscene
{
    static public string wakeUp()
    {
        string wakeUp = "";
        while (wakeUp != "yes" && wakeUp != "no")
        {
            wakeUp = Console.ReadLine();
            if (wakeUp != "yes" || wakeUp != "no")
            {
                Console.WriteLine("Please write yes or no!"); //gnäll
            }

        }
        return wakeUp;

    }
}