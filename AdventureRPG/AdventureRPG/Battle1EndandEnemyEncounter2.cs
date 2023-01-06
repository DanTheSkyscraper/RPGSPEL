using System;

public class Battle1EndandEnemyEncounter2 // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{
    public static void Battle1EndScene() // 'public static void ...()' is used to define a 'function' that is 'public', and that is related to the class as 'static'. Void is the return type for the method, which means that the method returns no value.
    {
        Console.WriteLine("\n\n After the battle, you stand there victoriously. This victory did not come without a cost. Despite what the Entity may have looked like, the injuries it inflicted upon you are, while not serious, enough to make you wince in pain. Despite this, you continue to move in the direction the man told you to go.");
        Console.WriteLine("\n In the distance, you can see a big wall made of what looks like scrap, street signs, cinder blocks and cars. A large banner hangs over the closed gate, the words ¨Safezone¨ written on it in black paint.");

        Console.WriteLine("\n At last, you arrive at the gate. There doesn't seem to be anyone around, though you do see a microphone hanging off of the wall next to the gate. Perhaps you need to speak to someone so that the gate opens?");
        Console.WriteLine("Grabbing the microphone, you decide to ask.");
        Console.WriteLine("\n ¨Hello? Anyone there? I was sent here by a man I met shortly after waking up here. Can someone please open the gate?¨");

        Console.WriteLine("\n You are met with silence. There has to be someone here. The man you met wouldn't have given you directions here if this place was abandoned, would he? Did he lie?");
        Console.WriteLine("A loud shriek suddenly interrupts your thoughts. Turning around, you see a much larger entity approaching you. It seems to resemble a deer.");

        Console.WriteLine("\n Despite feeling more exhausted than you have ever felt before, you lift your weapon up once again as you prepare to fight for your life.");

        Console.WriteLine("\n\n // YOU ARE NOW ENGAGED IN A BATTLE! //");
    }
}