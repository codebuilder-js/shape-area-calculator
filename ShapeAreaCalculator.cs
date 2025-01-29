using System;
class ShapeAreaCalculator {
  static void Main() {
    string answer;
    float result;
    
    Console.WriteLine("What shape area would you like to find?");
    Console.Write("'R' for rectangle, any other key for circle: ");
    
    answer = Console.ReadLine();
    
    if(answer.ToLower() == "r") {
        Console.Write("Enter the height of the rectangle: ");
        float height = float.Parse(Console.ReadLine());
        
        Console.Write("Enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());
        
        result = height * width;
    } else {
        Console.Write("Enter the radius of the circle: ");
        float radius = float.Parse(Console.ReadLine());
        
        result = (float)Math.PI * (radius * radius);
    }
    
    Console.WriteLine("The result is: " + result);
    
    Console.ReadKey();
  }
}
