public class Text // Class is visible in 4 different ways: Public, Private, Internal and Protected. Public is used here, and it allows us to access class via the objects we create of that class. Due to this, things like, for example, 'EnemyEncounter1.enemyscene1();' is possible. 'EnemyEncounter1' is the name of the object, followed by a period in the middle, and the the name of the class member, which is 'enemyscene1'.
{
    public static void FirstScene() // 'public static void ...()' is used to define a 'function' that is 'public', and that is related to the class as 'static'. Void is the return type for the method, which means that the method returns no value.
    {
        Console.WriteLine("\n You decide to get out of bed and begin the long process of waking yourself up. Halfway through your routine, you find yourself sitting in the kitchen eating your breakfast. As you sit there, you suddenly had a thought. \n \n ...Where is everyone? \n \n Your parents should be awake by now.");
        Console.WriteLine("\n Perhaps they had some business to attend to? That could be a reason why they are not here, though they could have told you so you knew beforehand. \n\n Deciding not to worry about that, you finish up and start preparing yourself to go to school. Approximately 5 minutes later, you lock the door behind you and head to the Bus Stop.");
        Console.WriteLine("\n ... \n \n Something strange is going on. It is a fact that the area where you live has some of the most crowded streets this side of the city, yet you have not seen hide nor hair of a single person ever since you stepped out of that door. No one is at the Bus Stop, and there is not a single vehicle driving on the road as far as the eye can see. You even tried calling your parents and even your classmates and what few teachers you have the phone number form yet no one answered. ");

        Console.WriteLine("\n It's almost as if-");
        Console.WriteLine("\n ¨So you found yourself here too..?¨");

        Console.WriteLine("\n You turn around just as the unknown voice finishes speaking. A rugged looking middle aged man, a least a head taller than you, stands to your left. You notice there is a large metal pole in his left hand and a large backpack on his back with a couple of odd looking objects sticking out.");
        Console.WriteLine("\n ¨Wha-What? What do you mean? Do you know what happened?¨");

        Console.WriteLine("\n He nodded his head. ¨I do. You find yourself in what is known as the 'Reverse'. It is a world parallell to our own. Do not misunderstand me however. Just because it is parallell to our own does not mean that it is safe. We do not know what they are or where they are from, but we refer to them simply as 'The entities'.¨");

        Console.WriteLine("\n ¨The fact that you are here means that you have ceased to exist in the real world. No one knows where we are, but every single person that has come here have learnt one thing: Do not, under any circumstances, try and act diplomatically towards the entities that reside here. They do not think. They do not feel. They do not sleep, nor do they need to eat and drink. The only things we have discovered that they do is wander and kill. We found that out the hard way. The fact that you have yet to encounter one is a miracle.");
        Console.WriteLine("\n ¨What is your name, boy?¨");
    }

}
