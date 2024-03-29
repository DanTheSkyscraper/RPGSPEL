public class PlayerBattle2 // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{
    
    public static string playerBattleChoice2()
    {
        string playerBattleChoice2 = "";
        while(playerBattleChoice2 != "a" && playerBattleChoice2 != "d") // This while-loop will make it so that the player has to type either 'a' or 'd'.
        {
            playerBattleChoice2 = Console.ReadLine();
            if(playerBattleChoice2 != "a" && playerBattleChoice2 != "d")
            {
                Console.WriteLine("Please type either 'a' or 'd'. The answer should be in lowercase!");
            }
        }
        return playerBattleChoice2; // This code will restart the while-loop if the player doesn't type 'a' or 'd'.
    }
}