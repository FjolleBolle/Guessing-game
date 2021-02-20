using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;

        static void Main(string[] args)
        {
            /* TO DO: here is where you add your code! */
            bool exit = false;
            int trialRun = 0;
            string word1 = "Programmer";

            do
            {
                Console.WriteLine("Would you like to play a game?");
                Console.WriteLine("Welcome to my guessing game!!!! To begin please write: start");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "start":
                        Console.WriteLine("In this game you have 10 lives. Every time you guess wrong you will loose a life and get a hint about the word.");
                        Console.WriteLine("Please begin guessing.");
                        string first = Console.ReadLine();
                        if (first == word1)
                        {
                            Console.WriteLine("You are a god. How on earth did you get it this early?");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Well it is expected that you wouldn't get it right away, here is a hint");
                            Console.WriteLine("The word starts with a P");
                            trialRun++;
                        }
                        string second = Console.ReadLine();
                        if(second == word1)
                        {
                            Console.WriteLine("You are amazing at guessing words, good job dude");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Here is your second hint");
                            Console.WriteLine("The word describes a person");
                            trialRun++;
                        }
                        string third = Console.ReadLine();
                        if (third == word1)
                        {
                            Console.WriteLine("You are fairly good at word guessing");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fine fine here is another hint, good luck");
                            Console.WriteLine("The word is a profession, something you can do for a living");
                            trialRun++;
                        }
                        string fourth = Console.ReadLine();
                        if (fourth == word1)
                        {
                            Console.WriteLine("Very nice, you got it");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Here is your fourth hint, i am counting your trials");
                            Console.WriteLine("The word ends with an r");
                            trialRun++;
                        }
                        string fifth = Console.ReadLine();
                        if (fifth == word1)
                        {
                            Console.WriteLine("See not so hard when you use that brain of yours");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You need another hint come on my guy, fine here it is");
                            Console.WriteLine("The word has 10 letters, use you brain please");
                            trialRun++;
                        }
                        string sixth = Console.ReadLine();
                        if (sixth == word1)
                        {
                            Console.WriteLine("Took some time but you got it");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Oh come on how can i make it any easier?");
                            Console.WriteLine("It has something to do with computers and codes");
                            trialRun++;
                        }
                        string seventh = Console.ReadLine();
                        if (seventh == word1)
                        {
                            Console.WriteLine("Thank you, man you kinda suck at this");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Are you kidding me? You're that dumb, seriously? ");
                            Console.WriteLine("We are studying to become this. We are this everytime in school. Fucking hell dude");
                            trialRun++;
                        }
                        string eigth = Console.ReadLine();
                        if (eigth == word1)
                        {
                            Console.WriteLine("You are really bad at this. You suck so very much, at least you got it on you're EIGHTH TRY!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I am going to grab you're neck and litterally beat this word into you brain");
                            Console.WriteLine("I will fill in some of the blanks, okay? Here goes: Pr_g__m__r");
                            trialRun++;
                        }
                        string ninth = Console.ReadLine();
                        if (ninth == word1)
                        {
                            Console.WriteLine("Finally you got it thank fucking christ it only took you NINE TRIES YOU WASTE OF BREATH!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("THE WORD IS LITTERALLY: Programmer!!!!!");
                            trialRun++;
                        }
                        string tenth = Console.ReadLine();
                        if (tenth == word1)
                        {
                            Console.WriteLine("It seriously took you this long? Really? I am beyond dissapointed and have lost faith in the human race");
                            break;
                        }
                        else
                        {
                            trialRun++;
                        }
                        break;
                }
                if (trialRun == MaxTrials)
                {
                    Console.WriteLine("You have no more lives and you utterly stink. I hate you and you're entire familytree");
                    Console.WriteLine("Please just write 'exit' and end my suffering");
                    string input2 = Console.ReadLine();
                    switch (input2)
                    {
                        case "exit":
                            exit = true;
                        break;
                    }
                }
                Console.WriteLine("To exit please write: exit");
                string input3 = Console.ReadLine();
                switch(input3)
                {
                    case "exit":
                        exit = true;
                        break;
                }
            }
            while (!exit);
        }
    }
}
