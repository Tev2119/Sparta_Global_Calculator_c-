using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to calculate (A) or find the area of a shape (B): ");
            string calc = Console.ReadLine();
            if (calc == "A")
            {
                double num1 = 0;
                double num2 = 0;
                string opprand;
                double ans = 0;
                Console.Write("what is your first number: ");
                 num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("what next number please: ");
                 num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("what is your operator sir (/, *, +, -): ");
                opprand = Console.ReadLine();

                switch (opprand)
                {
                    case "+":
                        ans = num1 + num2;
                        break;
                    case "-":
                        ans = num1 - num2;
                        break;
                    case "/":
                        ans = num1 / num2;
                        break;
                    case "*":
                        ans = num1 * num2;
                        break;
                }
                Console.WriteLine(num1 + "" + opprand + "" + num2 + " = " + ans);
            }
            else if(calc == "B")
            {
                double side, area, radius, length, breadth;
                string shape;
                Console.WriteLine("Which shape Area are you interested; Circle(C), Square(D), Triangle(E): ");
                shape = Console.ReadLine();
                if (shape == "C")
                {
                    Console.WriteLine("Enter Radius: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    Console.WriteLine("Your circle has an Area of: " + area);
                    Console.ReadKey();
                }
                else if(shape == "D")
                {
                    Console.WriteLine("Enter the Length of Side : ");
                    side = Convert.ToDouble(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("Area of Square: " + area);
                    Console.ReadKey();
                }
                else if (shape == "E")
                {
                    Console.WriteLine("Enter length of rectangle : ");
                    length = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter breadth of rectangle : ");
                    breadth = Convert.ToDouble(Console.ReadLine());
                    area = length * breadth;
                    Console.WriteLine("Area of rectangle: " + area);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
           
        }
    }
}
