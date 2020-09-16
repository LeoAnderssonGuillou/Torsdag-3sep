using System;

namespace TorsSep4_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            string action1;
            action1 = Console.ReadLine();
            if (action1 == "embrace")
            {
                Embrace();
                string action2;
                action2 = Console.ReadLine();
                if (action2 == "good")
                {
                    Good();
                    Console.ReadLine();
                }
                else if (action2 == "further")
                {
                    Further();
                    Console.ReadLine();
                }
                else
                {
                    TryAgain();
                }
            }
            else if (action1 == "resist")
            {
                Resist();
                string action2;
                action2 = Console.ReadLine();
                if (action2 == "fight")
                {
                    Fight();
                    Console.ReadLine();
                }
                else if (action2 == "flee")
                {
                    Console.WriteLine("You go into hiding.");
                    Console.ReadLine();
                }
                else
                {
                    TryAgain();
                }
            }
            else
            {
                TryAgain();
            }
        }

        static void Intro()
        {
            Console.WriteLine("You feel a powerful entity in the shape of a dog stand before you. Although terrifying, you sense great potential in the power radiating from this dog. What will you do? (embrace / resist)");
        }
        static void TryAgain()
        {
            Console.WriteLine("Try again. Please type one of the options.");
            Console.ReadLine();
        }
        static void Embrace()
        {
            Console.WriteLine("You embrace the dog. You feel yourself becoming one with this primal entity. What will you do with this newfound power? Will you use it for good or try to take it further? (good / further)");
        }
        static void Resist()
        {
            Console.WriteLine("You resist the dogs embrace, fighting back against its forbidden powers. You know however, that the dog is now your enemy, and you have to chose to either fight it or flee for your life. What will you do? (fight / flee)");
        }
        static void Further()
        {
            Console.WriteLine("You search deep into yourself for the limits of this dog's powers. It quickly dawns on you that the fabric of space and time is on its knees before you. In a swift motion, you take over the world, enslaving humanity. All hail the emperor of reality itself!");
        }
        static void Good()
        {
            Console.WriteLine("You decide to use your power for the good of humanity. Using the mental capabilities of the dog, you create political and technological utopia. Furthermore, you devote your body to science so that the powers of the hound may be replicaded and integrated into society. Humanity will be sure to enjoy this canine utopia.");
        }
        static void Fight()
        {
            Console.WriteLine("You decide that such terrifying power may only lead to evil, and cannot be allowed to exist in this world. In that very moment, you use all the strength that you have to banish the dog to the dark realms. The beast fights back, but cannot avoid its inevitable punishment. A moment later you know that it is over, and no one will ever have to fear the hound again.");
        }
    }
}
