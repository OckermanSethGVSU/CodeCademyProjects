using System;
/**
*Codecademy Madlibs project with 
* a twist
*@author Seth Ockerman
*/
namespace MadLibs{
  class Program{  
    static void Main(string[] args){
      string play = "yes";
      string story;
      
      while(String.Equals("yes", play)){
      // alert user
      Console.WriteLine("Corny Mad Libs is starting. There are three templates; Enter \"pirate\", \"party\", or \"spy\". Othewise enter \"exit\" to exit");  
      string template = Console.ReadLine().ToLower();
        if(String.Equals("exit",template)){
          play = "exit";
        }
      
      // pirate template option
      if(String.Equals("pirate",template)){
        // getting adjs
        Console.WriteLine("Enter 3 adjectives; Press enter after each word");
        string adj1 = Console.ReadLine();
        string adj2 = Console.ReadLine();
        string adj3 = Console.ReadLine();
        
        // getting nouns
        Console.WriteLine("Enter 3 nouns; Press enter after each word");
        string noun1 = Console.ReadLine();
        string noun2 = Console.ReadLine();
        string noun3 = Console.ReadLine();
        
        Console.WriteLine("Enter 3 verbs; Press enter after each word");
        string verb1 = Console.ReadLine();
        string verb2 = Console.ReadLine();
        string verb3 = Console.ReadLine();
        
        string title = "Pirate Adventure";
         story = $"Arr. Prepare for a tale untold. The baddest pirate in all the land: Captain {noun1}. He was the most {adj1} pirate on all the seas. He was known for {verb1} his captives. This also made them eat {noun2} {verb2}ly. It is pretty scary to watch, especially because his first mate was {noun3}. He was also {adj2}. He was massive and always {verb3} before he went to bed. His most {adj3} deed ,indeed, was when he ate pinnapple on pizza. This make even Black Beard quake in his boots. Arr. The story of Captain {noun1} ";
        Console.WriteLine(title);
        Console.WriteLine(story);
        Console.WriteLine("\n");
        Console.WriteLine("To play again enter yes, to exit, enter anything else");
        play = Console.ReadLine().ToLower();
      }
      
      // Define user input and variables:


      // The template for the story:

       story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:
      }

    }
  }
}
