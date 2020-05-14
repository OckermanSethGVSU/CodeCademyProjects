using System;
/// <summary>
///Class that outputs a random creature to the 
///console
///Author: Seth Ockerman 
/// </summary>

namespace ExquisiteCorpse{
  class Program{
    // main method
    static void Main(string[] args){
     RandomMode();
    }
    /// <summary>
    ///outputs a creature to the console based on parameters
    /// <param name = head> the desired head as a string </param>
    /// <param name = body>  the desired body as a string </param>
    /// <param name = feet> the desired feet as a string </param>
    /// </summary>
    static void BuildACreature(string head, string body, string feet){
      int h = TranslateToNumber(head);
      int b = TranslateToNumber(body);
      int f = TranslateToNumber(feet);
      SwitchCase(h,b,f);
      }
    /// <summary>
    /// switch case for the creature method. Takes an int and 
    /// outputs the correlated type of body part
    /// <param name = head> the desired head as an int </param>
    /// <param name = body> the desired body as an int </param>
    // <param name = feet> the desired feet as an int </param>
    /// </summary>
    static void SwitchCase(int head, int body, int feet){
      // switch statment for ASCII head
      switch(head){
        case 1:
          BugHead();
          break;
        case 2:
          GhostHead();
          break;
        case 3:
           MonsterHead();
          break;
        default:
          break;
      } 
      // switch statment for ASCII body
      switch(body){
        case 1:
          BugBody();
          break;
        case 2:
          GhostBody();
          break;
        case 3:
          MonsterBody();
          break;
        default:
          break;
      }
      // switch statement for ASCII feet
      switch(feet){
        case 1:
          BugFeet();
          break;
        case 2:
          GhostFeet();
          break;          
        case 3:
          MonsterFeet();
          break;
        default:
          break;
      }
    }
    /// <summary>
    /// generates three random integers and then 
    // calls switchCase to output a creature to the console
    /// </summary>
    static void RandomMode(){
      Random randNum = new Random();
      int head = randNum.Next(1,4);
      int body = randNum.Next(1,4);
      int feet = randNum.Next(1,4);
      SwitchCase(head,body,feet);
    }
    /// <summary>
    /// translates a string input into the correlated integer
    /// <param name = creature> the creature you want: options are bug, ghost, monster </param>
    /// <returns> the desired creature as an int </returns>
    /// </returns>
    static int TranslateToNumber(string creature){
      creature = creature.ToLower();
      switch(creature){
        case "bug":
          return 1;
        case "ghost":
          return 2;
        case "monster":
          return 3;
        default:
          return 1;
      }
    }
    ///<summary>
    /// outputs ghosthead
    /// </summary>
    static void GhostHead(){
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }
    /// <summary>
    /// outputs ghostbody
    /// </summary>
    static void GhostBody(){
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }
    /// <summary>
    /// outputs ghost feet
    /// </summary>
    static void GhostFeet(){
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }
    /// <summary>
    /// outputs bug head
    /// </summary>
    static void BugHead(){
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }
    /// <summary>
    /// outputs bug body
    /// </summary>
    static void BugBody(){
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }
    /// <summary>
    /// outputs bug feet
    /// </summary>
    static void BugFeet(){
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }
    /// <summary>
    /// outputs monster head
    /// </summary>
    static void MonsterHead(){
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }
    /// <summary>
    /// outputs monster body
    /// </summary>
    static void MonsterBody(){
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }
    /// <summary>
    /// outputs monster feet
    /// </summary>
    static void MonsterFeet(){
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
