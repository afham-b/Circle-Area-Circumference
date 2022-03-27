using System;
using System.Linq;
using System.IO; 
using System.Text;


namespace Circle
{
  class Program
  {
    static void Main(string[] args)
    {
    //area fromula = pi*r^2
    //formula of a circumference = 2*pi*r
      double radius,area,circumference;
      double PI = 3.14;
      
      Console.WriteLine("What is the radius of your circle: ");
      radius = double.Parse(Console.ReadLine());
      //radius = Convert.ToDouble(Console.ReadLine());
      //radius = Convert.ToInt32(Console.ReadLine());
      area = PI * (radius * radius);
      circumference = 2 * PI * radius;

      Console.WriteLine("The circumference of your circle is: "+ circumference);
      Console.WriteLine("The area of your circle is: "+ area);
      Console.ReadKey();
      
    }
  }
}

