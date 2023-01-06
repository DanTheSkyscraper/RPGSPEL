using System;

public class Ending // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{

    public static void Endingscene() // 'public static void ...()' is used to define a 'function' that is 'public', and that is related to the class as 'static'. Void is the return type for the method, which means that the method returns no value.
    {
        Console.WriteLine("\n\n You fall to the ground, too tired and hurt to stand up.");
        Console.WriteLine("As you lay there, your vision starting to fade and the ringing in your ears getting louder and louder, you start to faintly hear voices behind you. You can't make out what they are saying, but they sound concerned. As more and more of your vision fades, you can barely feel someone slowly lift you up before placing you back down on your back.");

        Console.WriteLine("\n You can faintly see a couple of faces, partially covered by masks. One of them looks like they are talking to you, but you do not hear them.");
        Console.WriteLine("Right before you fall unconscious, you feel youself relax as you realize who they are. Rescue.");

        Console.WriteLine("\n\n You are safe.");
    }
}