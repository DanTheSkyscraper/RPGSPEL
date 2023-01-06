using System;

public class EnemyEncounter1 // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{

    public static void enemyscene1() // 'public static void ...()' is used to define a 'function' that is 'public', and that is related to the class as 'static'. Void is the return type for the method, which means that the method returns no value.
    {
        Console.WriteLine("\n\n You have choosen your weapon and have now started to make your way to the safozone the man told you about. Before you know it, you reach the grocery store and turn left. You abruptly halt to a stop.");
        Console.WriteLine("\n Just to your left, mere meters away, is a small, black amorphous mass of bubbles. It must have noticed you, since it is rapidly jumping forward in your direction.");

        Console.WriteLine("\n You prepare yourself, gripping your weapon firmly. You have no choice but to fight, because who knows what you'll encounter should you try to escape? With that in mind, you engage the entity.");

        Console.WriteLine("\n\n // YOU ARE NOW ENGAGED IN A BATTLE! //");
    }
}