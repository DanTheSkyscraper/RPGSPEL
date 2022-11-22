//The Game begins here!
string playAgain = "y";
while (playAgain == "y")
{
    string name;

    int unarmedMinDamage = 0;
    int unarmedMaxDamage = 10;
    int weaponMinDamage = 0;
    int weaponMaxDamage = 20;

    int playerHealth = 100;
    int enemyHumanHealth = 100;
    int enemyMonsterHealth = 150;

    Random generator = new Random();

    Console.WriteLine("You wake up in a dark room. The tattered curtains are closed, sunlight peeking through the multitude of holes dotting the biege fabric. You turn your head to see what your alarm clock says. It reads: '06:47'. Do you get out of bed? \n\n [Yes // No]");
    
    string wakeUp = "";
    while (wakeUp != "yes" && wakeUp != "no")
    {
        wakeUp = Console.ReadLine();
        if (wakeUp != "yes" || wakeUp != "no")
        {
            Console.WriteLine("Please write yes or no!!!!"); //gnäll
        }
    }



    if (wakeUp == "Yes")
    {
        Console.WriteLine();
        wakeUp =
    }
}
Console.ReadLine();





//Console.WriteLine("\n\n\n\n"); Det här är hur man gör mellanrum
