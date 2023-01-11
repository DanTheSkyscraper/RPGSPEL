public class WeaponChoice // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{

    public static string weaponChoice()
    {
        string weaponChoice = "";
        while(weaponChoice != "a" && weaponChoice != "b" && weaponChoice != "c" && weaponChoice != "d") // This while-loop will make it so that the player has to type either 'a', 'b', 'c' or 'd'.
        {
            weaponChoice = Console.ReadLine();
            if(weaponChoice != "a" && weaponChoice != "b" && weaponChoice != "c" && weaponChoice != "d")
            {
                Console.WriteLine("Please type either 'a', 'b', 'c' or 'd'. The answer should be in lowercase!");
            }
        }
        return weaponChoice; // This code will restart the while-loop if the player doesn't type 'a', 'b', 'c' or 'd'.
    }
}