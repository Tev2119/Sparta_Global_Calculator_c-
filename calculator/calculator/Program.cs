using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        class AreaOfShapes
        {
            public static double Rectangle(double length, double breadth)
            {
                Console.WriteLine("Enter length of rectangle : ");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter breadth of rectangle : ");
                breadth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of rectangle: " + (length*breadth));
                Console.ReadKey();
                return length * breadth;
            }
            public static double Square(double length)
            {
                Console.WriteLine("Enter the Length of Side : ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Square: " + (length * length));
                Console.ReadKey();
                return length * length;

            }
            public static double Circle(double radius)
            {
                Console.WriteLine("Enter Radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your circle has an Area of: " + (Math.PI * radius * radius));
                Console.ReadKey();
                return Math.PI * radius * radius;
            }
        }
        class CalculatorParameters
        {
            public static double Addition(double num1, double num2)
            {
                Console.WriteLine(num1 + " " + "+" + " " + num2 + " = " + (num1 + num2));
                return num1 + num2;
            }
            public static double Subtraction(double num1, double num2)
            {
                Console.WriteLine(num1 + " " + "-" + " " + num2 + " = " + (num1 - num2));
                return num1 - num2;
            }
            public static double multiply(double num1, double num2)
            {
                Console.WriteLine(num1 + " " + "*" + " " + num2 + " = " + (num1 * num2));
                return num1 * num2;
            }
            public static double Divide(double num1, double num2)
            {
                Console.WriteLine(num1 + " " + "/" + " " + num2 + " = " + (num1 / num2));
                return num1 / num2;
            }
        }
        static void Main(string[] args)
        {
            string exit = "exit";
            do
            {
                Console.WriteLine("Would you like to calculate (A) or find the area of a shape (B): ");
                string calc = Console.ReadLine();
                if (calc == "A" || calc == "a")
                {
                    Console.Write("what is your first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("what is the next number please: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("what is your operator sir (/, *, +, -): ");
                    string opprand = Console.ReadLine();
                    switch (opprand)
                    {
                        case "+":
                            CalculatorParameters.Addition(num1, num2);
                            break;
                        case "-":
                            CalculatorParameters.Subtraction(num1, num2);
                            break;
                        case "/":
                           CalculatorParameters.Divide(num1, num2);
                            break;
                        case "*":
                            CalculatorParameters.multiply(num1, num2);
                            break;
                    }
                    //exit = Console.ReadLine();
                }
                else if (calc == "B" || calc == "b")
                {
                    string shape;
                    Console.WriteLine("Which shape Area are you interested; Circle(C), Square(D), Rectangle(E), to exit type(Yes): ");
                    shape = Console.ReadLine();
                    if (shape == "C" || shape == "c")
                    {
                        AreaOfShapes.Circle(0);
                    }
                    else if (shape == "D" || shape == "d")
                    {
                        AreaOfShapes.Square(0);
                    }
                    else if (shape == "E" || shape == "e")
                    {
                        AreaOfShapes.Rectangle(0, 0);
                    }
                    else
                    {
                        Console.WriteLine("innapropriate operator please retry or if you would like to exit type(Yes)");
                        shape = Console.ReadLine();
                    }
                }
                Console.ReadKey();
            }
            while(exit == "Yes");
        }
    }
}
