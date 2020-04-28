using System;

namespace ChooseYourOwnAdventure
{
  class Program{
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

     // get users name and gree them
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
     
        //begin story with choice
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine("Type Yes or No:");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
      // if not
      if(noiseChoice == "NO"){
          Console.WriteLine("Not much of an adventure if we don't leave our room!");
          Console.WriteLine("The End");
        }
      // if yes
      else if(noiseChoice == "YES"){
        // next dialog and next choice  
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
        Console.WriteLine("You walk towards it. Do you open it or knock?");
        // store second choice
        Console.WriteLine("Type Open or Knock");
        string doorChoice = Console.ReadLine();
        doorChoice = doorChoice.ToUpper();
        
        // second set of choices
        if(doorChoice == "KNOCK"){
          Console.WriteLine("A voice behind the door speaks. It says, Answer this riddle:");
          Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?");
          Console.WriteLine("Enter your answer");
          string answ = Console.ReadLine();
          answ = answ.ToLower();
          if(answ == "nothing"){
            Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door.");
            Console.WriteLine("THE END.");
          }
          else{
            Console.WriteLine("You answered incorrectly. The door doesn't open.");
            Console.WriteLine("THE END.");
          }
        }
        // user opens door
        else if(doorChoice == "OPEN"){
          Console.WriteLine("The door is locked! See if one of your three keys will open it");
          Console.WriteLine("Enter a number: 1, 2, or 3");
          string keyChoice = Console.ReadLine();
          keyChoice.ToUpper();
          // switch statments for three number choices 
          switch(keyChoice){
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice!");
              Console.WriteLine("The door opens and NOTHING is there. Strange...");
              Console.WriteLine("The end");
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open");
              Console.WriteLine("The end");
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open");
              Console.WriteLine("The end");
              break;
            default:
              Console.WriteLine("You tried brute force. Turns out it the door didn't like that. NOTHING came out of the door and swallowed you whole");
              Console.WriteLine("The End");
              break;
          }
          
        }
          // user either entered nothing or messed up typing. Still gives them an ending
          else{
            Console.WriteLine("You sit in indecision, unable to make a final choice. Years pass and your beard grows greyer and greyer before   you become what you came to find...");
            Console.WriteLine("NOTHING");
        }
      }
    }
  }
}



