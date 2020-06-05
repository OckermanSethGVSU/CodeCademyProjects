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
      
      if(String.Equals("spy",template)){
        // getting adjs
        Console.WriteLine("Enter 3 adjectives; Press enter after each word");
        string adj1 = Console.ReadLine();
        string adj2 = Console.ReadLine();
        string adj3 = Console.ReadLine();
        
        // getting nouns
        Console.WriteLine("Enter 4 nouns; Press enter after each word");
        string noun1 = Console.ReadLine();
        string noun2 = Console.ReadLine();
        string noun3 = Console.ReadLine();
        string noun4 = Console.ReadLine();
        
        Console.WriteLine("Enter 3 verbs; Press enter after each word");
        string verb1 = Console.ReadLine();
        string verb2 = Console.ReadLine();
        string verb3 = Console.ReadLine();
        
        string title = ($"{noun1} ... James {noun1}");
         story = $"\"What would you like to drink my friend,\" asked the bartender. \"I'll take a {noun2}, {verb1} please,\" replied James {noun1}. \"An odd choice,\" replied the bartender before handing him his drink that resembled boiled {noun4} more than what he ordered. All the same James wasn't here for the drinks, he was on a mission. If he wasn't careful Doctor {noun3} would infect the world with {adj1},{adj2} puppies; a horrible fate. James straightened his bowtie and {verb2} across the room towards what he suspected was a secret door. Villians and there {adj3} doors, no subtlety. Guess I'll go finish this before he took one last sip of his drink and {verb3} the door";
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(story);
        Console.WriteLine("\n");
        Console.WriteLine("To play again enter yes, to exit, enter anything else");
        play = Console.ReadLine().ToLower();
      }
      // party template option
      if(String.Equals("party",template)){
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
        
        string title = "Party";
         story = $"Pulling up to the house in our {noun1}, I felt {adj2}. I hopped out of my {noun1} and {verb1} my {noun2} before heading in. There was {noun3} everywhere. It covered the ceilings, the floors, and the walls. It was so {adj3}. It couldn't stop me from {verb2} though. I walked right up to the birthday boy and began to {verb2} and also {verb3}. Oh yeah. I was gonna be remembered for this!";
        Console.WriteLine(title);
        Console.WriteLine(story);
        Console.WriteLine("\n");
        Console.WriteLine("To play again enter yes, to exit, enter anything else");
