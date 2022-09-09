using System;

class Program {
  public static void Main (string[] args) {
    const double PERCENT = 0.23;
    double profit = 0;
    double totalSales = 0;

    Console.Write("This program predicts the profit of sales based on the total amount of sales.");
    
    Console.WriteLine();

    Console.Write("Please enter the projected amount of sales: ");
    totalSales = int.Parse(Console.ReadLine());

    profit = PERCENT * totalSales;

    Console.WriteLine($"The projected amount of profit is {profit:c}");
      
  }
}