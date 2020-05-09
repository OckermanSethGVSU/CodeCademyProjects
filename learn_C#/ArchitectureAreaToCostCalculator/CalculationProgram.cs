using System;

namespace ArchitectArithmetic{
class Program{
  public static double rectangle(double l, double w ){
    return l*w;
  }
  public static double circle(double r){
    return Math.PI * Math.Pow(r,2);
  }
  public static double triangle(double b, double h){
    return (0.5 * b * h);
  }
  public static void Main(string[] args){
      double tri = triangle(500,750);
      double circleArea = circle(375);
      double rect = rectangle(1500,2500);
      double area = (tri + circleArea + rect);
      double cost = area * 180;
      cost = Math.Round(cost,2);
      Console.WriteLine($"The cost of your floor comes out to {cost} pesos. This was calculated by multiplying area by the cost of a square meter by the cost of 180 pesos");
    }
  }
}
