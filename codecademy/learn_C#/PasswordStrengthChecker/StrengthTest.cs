using System;

namespace PasswordChecker{
class Program{
    public static void Main(string[] args){
       //variables
      int score =0;
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*()_+=";
      Console.WriteLine("Enter your password");
      string password = Console.ReadLine();
      // check for certain characteristics. If found, increase score
      if(password.Length >= minLength){
        ++score;
      }
      if(Tools.Contains(password,uppercase)){
        ++score;
      }
      if(Tools.Contains(password,lowercase)){
        ++score;
      }
      if(Tools.Contains(password,digits)){
        ++score;
      }
      if(Tools.Contains(password,specialChars)){
        ++score;
      }
      if(password == "password" || password == "1234"){
        score = 0;
      }
       
      // show user results    
      switch (score){
       case 1:
         Console.WriteLine("Score: " + score + " Weak");
         break;
      case 2:
         Console.WriteLine("Score: " + score + " Decent");
         break;
       case 3:
         Console.WriteLine("Score: " + score +" Good enough");
         break;
       case 4:
         Console.WriteLine("Score: " + score + " Strong");
         break;
       case 5:
         Console.WriteLine("Score: " + score + " Uncrackable");
         break;
       default:
         Console.WriteLine("No Password Entered");
          break;
     }
      
    }
  }
}
