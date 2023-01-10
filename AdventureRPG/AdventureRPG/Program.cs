//The Game begins here!
string playAgain = "y";
while (playAgain == "y") // This while loop will make it so that, once the game is over, the player can reset it by pressing "y".
{
    string name; 

    // These integers make it so that both the player and the AI entities have their minimum damage and maximum damage.
    int weaponMinDamage = 0; 
    int weaponMaxDamage = 25;
    int enemyEntity1MinDamage = 0;
    int enemyEntity1MaxDamage = 5;
    int enemyEntity2MinDamage = 0;
    int enemyEntity2MaxDamage = 20;

    // These integers make it so that both the player and the AI entities have health.
    int playerHealth = 100;
    int enemyEntityHealth1 = 50;
    int enemyEntityHealth2 = 120;

    Random generator = new Random(); // Random generator makes it so that, in this code, the damage the player and the AI deal to each other is randomized.

    // This is the intro to the game. The player is given a choice between continuing the game by waking up (typing 'yes'), or ending the game early by going back to sleep (typing 'no'). 
    Console.WriteLine("You wake up in a dark room. The tattered curtains are closed, sunlight peeking through the multitude of holes dotting the biege fabric. You turn your head to see what your alarm clock says. It reads: '06:47'. Do you get out of bed? \n\n [yes // no] \n (This is case sensitive. Please use lowercase letters when answering.)");

    string wakeUp = Startscene.WakeUp(); // This code is a method (More info on line 35). The difference with this code is that the player chooses either 'yes' or 'no'. If yes is choosen, the the game will continue. However, if the player chooses 'no', the game will end and the player will be asked if they want to restart.
    
    if (wakeUp == "no") // See line 25 for more info.
    {
        Console.WriteLine("You decided not to get up. You remained in bed and fell asleep again... \n\n [END]");
    }
    else
    {
        // The rest of the game
        
        Text.FirstScene(); // This code is a method. It is the same as 'Departure.departurescene();', EnemyEncounter1.enemyscene1();', etc in that they are all written in seperate files. These are then brought into 'Program.cs' with this code. Using methods is a good way to, for example, save space and make the entire code less cluttered, etc.  

        Console.WriteLine("\n My name is:"); // This code allows the player to write what the name of their character will be.
        name = Console.ReadLine();

        Departure.DepartureScene(); // See line 35 for more info.

        // This code allows the player to choose which weapon they want their character to use. 'a's is for knife, 'b' is for metal pole, 'c' is for baseball bat, and 'd' is for axe.
        Console.WriteLine("\n You have 4 choices. Kitchen Knife [a] / Metal pole [b] / Baseball bat [c] / Axe [d] \n (This is case sensitive. Please use lowercase letters when choosing your weapon.)");
        string weaponChoice = Console.ReadLine().ToLower(); // .ToLower() converts every character to lower case.
        if(weaponChoice == "a")
        {
            Console.WriteLine("You chose the Kitchen Knife");
            weaponChoice = "Kitchen Knife";
        }
        else if(weaponChoice == "b")
        {
            Console.WriteLine("You chose the Metal pole");
            weaponChoice = "Metal pole";
        }
        else if(weaponChoice == "c")
        {
            Console.WriteLine("You chose the Baseball bat");
            weaponChoice = "Baseball bat";
        }
        else
        {
            Console.WriteLine("You chose the Axe");
            weaponChoice = "Axe";
        }

        EnemyEncounter1.EnemyScene1(); // See line 35 for more info.

        // There are two of these while-loops. The way they work, is that as long as the health of the player character AND the AIs haven't reached 0, the game will continue. The code within the while-loop, (the fights), will repeat until one of them has their health reach 0.
        while(playerHealth > 0 && enemyEntityHealth1 > 0)
        {
            Console.WriteLine("A new round has started!");
            Console.WriteLine($"\n Health [{name}]: {playerHealth} hp -//- Health [Small Amorphous Mass]: {enemyEntityHealth1} hp");

            Console.WriteLine("\n\n It is now your turn to attack!");
            Console.WriteLine($"\n You attack the entity with your {weaponChoice}!");
            int playerDamage = generator.Next(weaponMinDamage, weaponMaxDamage); // 'generator.Next(weaponMinDamage, weaponMaxDamage);' in the while-loop is important, because it randomizes the damage the player character deals to the AI Entities. This specific line will randomize a number between 0 and 25.

            enemyEntityHealth1 -= playerDamage; // This code within the while-loop will subtract the health of the player and the AI Entities (See line 85, 108 and 115) with the damage they deal to each other.
            enemyEntityHealth1 = Math.Max(0, enemyEntityHealth1); // 'Math.Max' is a Math class method used to return the larger of two specified numbers. In this code, 'enemyEntityHealth1 = Math.Max(0, enemyEntityHealth1);' will not return 0, but 'enemyEntityHealth1', which is the health of 'enemyEntity1' (Small Amorphous Mass), and larger of the two numbers.
            Console.WriteLine($"\n You hit your opponent, dealing {playerDamage} damage to 'Small Amorphous Mass'.");

            Console.WriteLine("The 'Small Amorphous Mass' attacks you!");
            int enemyEntity1Damage = generator.Next(enemyEntity1MinDamage, enemyEntity1MaxDamage); // This code within the while-loop randomizes the damage the first AI Entity deals to the player, with a randomized number between 0 and 5. See line 76 for similar info.

            playerHealth -= enemyEntity1Damage; // See line 78 for more info.
            playerHealth = Math.Max(0, playerHealth); // 'Math.Max' is a Math class method used to return the larger of two specified numbers. In this code, 'playerHealth = Math.Max(0, playerHealth);' will not return 0, but 'playerHealth', which is the health of the player, and larger of the two numbers.
            Console.WriteLine($"'Small Amorphous Mass' lands a hit on you, dealing {enemyEntity1Damage} damage to you.");
        }

        if(playerHealth == 0) // Depending on the health of the player, the game will either stop or continue. If the health of the player reaches 0, they will lose. If not, the game will continue from line 95.
        {
            Console.WriteLine("\n\n You collapse to the ground, having fallen unconscious.");
            Console.WriteLine("\n YOU HAVE LOST");
        }
        else 
        {
            Battle1EndandEnemyEncounter2.Battle1EndScene(); // See line 35 for more info.

            while(playerHealth > 0 && enemyEntityHealth2 > 0) // See line 68 for more info.
            {
                Console.WriteLine("A new round has started!");
                Console.WriteLine($"\n Health [{name}]: {playerHealth} hp -//- Health [Deer Entity]: {enemyEntityHealth2} hp");

                Console.WriteLine("\n\n It is now your turn to attack!");
                Console.WriteLine($"\n You attack the entity with your {weaponChoice}!");
                int playerDamage = generator.Next(weaponMinDamage, weaponMaxDamage); // See line 76 for more info.

                enemyEntityHealth2 -= playerDamage; // See line 78 for more info.
                enemyEntityHealth2 = Math.Max(0, enemyEntityHealth2); // 'Math.Max' is a Math class method used to return the larger of two specified numbers. In this code, 'enemyEntityHealth2 = Math.Max(0, enemyEntityHealth2);' will not return 0, but 'enemyEntityHealth2', which is the health of 'enemyEntity2' (Deer Entity), and larger of the two numbers.
                Console.WriteLine($"\n You hit your opponent, dealing {playerDamage} damage to 'Deer Entity'.");

                Console.WriteLine("The 'Deer Entity' attacks you!");
                int enemyEntity2Damage = generator.Next(enemyEntity2MinDamage, enemyEntity2MaxDamage); // This code within the while-loop randomizes the damage the second AI Entity deals to the player, with a randomized number between 0 and 20. See line 76 for similar info.

                playerHealth -= enemyEntity2Damage; // See line 78 for more info.
                playerHealth = Math.Max(0, playerHealth); // 'Math.Max' is a Math class method used to return the larger of two specified numbers. In this code, 'playerHealth = Math.Max(0, playerHealth);' will not return 0, but 'playerHealth', which is the health of the player, and larger of the two numbers.
                Console.WriteLine($"'Deer Entity' lands a hit on you, dealing {enemyEntity2Damage} damage to you.");
            }

            if(playerHealth == 0) // Depending on the health of the player, the game will either stop or continue. If the health of the player reaches 0, they will lose. If not, the game will continue from line 125.
            {
                    Console.WriteLine("\n\n You collapse to the ground, having fallen unconscious.");
                    Console.WriteLine("\n YOU HAVE LOST");
            }
            else
            {
                Ending.EndingScene(); // See line 35 for more info.

                for(int i = 0; i < 4; i++) // This will run a for-loop in order to get 4 '...' before the game declares that the player has won.
                {
                    Console.WriteLine("\n ...");
                }

                Console.WriteLine("\n YOU HAVE WON THE GAME!");
            }
        }  
    }

    Console.WriteLine("\n Do you wish to play again? [y/n]"); // This is the end of the while-loop. This Console.WriteLine will give you the option to choose whether you want to restart the game or not. If 'y' is pressed, you start again. If you press 'n', you will exit the game.
    playAgain = Console.ReadLine();
}
Console.ReadLine();





//Ex: 'Console.WriteLine("\n\n (text)");'. \n is used to create space between each line in the console.
