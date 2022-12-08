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

    string wakeUp = Startscene.wakeUp();
    
    if (wakeUp == "no")
    {
        Console.WriteLine("You decided not to get up. You remained in bed and fell asleep again... [END]"); //WORK IN PROGRESS!!!!
    }
    else
    {
        // resten av spelet
        
        Text.firstscene();

        Console.WriteLine("¨My name is:");
        name = Console.ReadLine();

    }

    Console.WriteLine("Do you wish to play again? [y/n]"); // This is the end of the while-loop. This Console.WriteLine will give you the option to choose whether you want to restart the game or not. If 'y' is pressed, you start again. If you press 'n', you will exit the game.
    Console.ReadLine();
}
Console.ReadLine();





//Console.WriteLine("\n\n\n\n"); Det här är hur man gör mellanrum
