using System;
namespace changeConverter{
  class MainClass{
    public static void Main(string[] args){
      // variables
      int quarters;
      int dimes;
      int nickels;
      int pennies;
      double quarter = 0.25;
      double dime = 0.10;
      double nickel = 0.05;
      double penny = 0.01;
      double amount;
      double remainder;
      // start of program
      Console.WriteLine("Welcome to Money Maker! It takes the amount you enter and divides them into the minimum number of US coins to makeup that number");
      Console.WriteLine("Enter amount in format of \"00.00\"");
       amount = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("$" + amount + " is equal to:");
      // calculating min combination
      //Q's first
      quarters = (int)(Math.Floor(amount/quarter));
      remainder = amount%quarter;
      // then D's
      dimes = (int)(Math.Floor(remainder/dime));
      remainder = remainder%dime;
      // then N's
      nickels = (int)(Math.Floor(remainder/nickel));
      remainder = remainder%nickel;
      // leftover is pennies 
      pennies = (int)(remainder * 100);
      
      //display output
      Console.WriteLine("Quarters: " + quarters );
      Console.WriteLine("Dimes: " + dimes);
      Console.WriteLine("Nickels: " + nickels);
      Console.WriteLine("Pennies: " + pennies);
    }
  }
}
