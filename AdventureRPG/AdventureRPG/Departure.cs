using System;

public class Departure // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{
    public static void departurescene() // 'public static void ...()' is used to define a 'function' that is 'public', and that is related to the class as 'static'. Void is the return type for the method, which means that the method returns no value.
    {   
        Console.WriteLine("\n ¨It is a pleasure to meet you. I would have liked to talk more, but we are currently in a dangerous part of town. I must stay here to greet anyone else who may have been brought here. Go down this road until you reach the grocery store over there, then turn left and continue down until you reach the metal barrier. That is the safezone.¨");
        Console.WriteLine("\n ¨Safezone?¨");
        Console.WriteLine("\n ¨You will learn about it later. Now, before you depart, I want you to take one of these weapons that I have brought with me. While it isn't much, you will at least be able to defend yourself.¨");

        Console.WriteLine("\n\n The man shows you the contents of his backpack. Which weapon will you choose?");
    }
}